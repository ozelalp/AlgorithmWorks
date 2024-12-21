using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace APIWorks.Controllers
{
    public class ApiController : Controller
    {
        public const string CountryCodeHeaderName = "x-test-country-code";

        private readonly IRepository _repository;

        public ApiController(
            IRepository repository
        )
        {
            _repository = repository;
        }

        // Return UnauthorizedResult() or OkObjectResult(ICollection<Store>)
        public IActionResult GetStores()
        {
            if (!CheckHeaderAndSetUserCountryCode(Request.Headers, out string userCountyCode))
            {
                return Unauthorized();
            }
            _repository.GetStores((s) => s.CountryCode == userCountyCode).First();
            return Ok(_repository.GetStores((s) => s.CountryCode == userCountyCode));
        }

        // Return UnauthorizedResult(), NotFoundResult(), ForbidResult() or OkObjectResult(Store)
        public IActionResult GetStore(int storeId, bool includeCustomers = false)
        {
            // get the header CountryCodeHeaderName
            if (!CheckHeaderAndSetUserCountryCode(Request.Headers, out string userCountyCode))
            {
                return Unauthorized();
            }

            // get Store by Id
            var storeList = _repository.GetStores((s) => s.StoreId == storeId, includeCustomers);
            if (storeList == null || storeList.Count == 0)
            {
                return NotFound();
            }

            // get the store by checking it's CountryCode.
            var store = storeList.FirstOrDefault(f => f.CountryCode == userCountyCode);
            if (store == null)
            {
                return Forbid();
            }

            return Ok(store);
        }

        // Return UnauthorizedResult(), BadRequestResult() or OkObjectResult(Customer)
        public IActionResult CreateCustomer(Customer customer)
        {
            if (!CheckHeaderAndSetUserCountryCode(Request.Headers, out string userCountyCode))
            {
                return Unauthorized();
            }

            if (!ValidateCustomer(customer, userCountyCode))
            {
                return BadRequest();
            }

            return Ok(_repository.AddCustomer(customer));
        }

        private bool CheckHeaderAndSetUserCountryCode(IHeaderDictionary headers, out string userCountyCode)
        {
            userCountyCode = "";
            var headerFound = Request.Headers.TryGetValue(CountryCodeHeaderName, out StringValues codeList);
            if (!headerFound || codeList.Count > 1 || string.IsNullOrEmpty(codeList[0]) || string.IsNullOrWhiteSpace(codeList[0]))
            {
                return false;
            }

            userCountyCode = codeList[0];
            return true;
        }

        private bool ValidateCustomer(Customer customer, string userCountyCode)
        {
            // check the store by Id and CountryCode
            var storeList = _repository.GetStores((s) => s.StoreId == customer.StoreId && s.CountryCode == userCountyCode);
            if (storeList == null)
            {
                return false;
            }

            // validate email
            if (string.IsNullOrEmpty(customer.Email) || string.IsNullOrWhiteSpace(customer.Email))
            {
                return false;
            }

            try
            {
                var email = new MailAddress(customer.Email);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }

    public interface IRepository
    {
        ICollection<Store> GetStores(Func<Store, bool> filter, bool includeCustomers = false);
        ICollection<Customer> GetCustomers(int storeId);
        Customer AddCustomer(Customer customer);
    }

    public class Store
    {
        public int StoreId { get; set; }
        public string CountryCode { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
