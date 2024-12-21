using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmWorks.Proxify
{
    public interface IInvoiceRepository
    {
    }
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly IQueryable<Invoice> invoices;
        public InvoiceRepository(IQueryable<Invoice> invoices)
        {
            if (invoices == null)
            {
                throw new ArgumentNullException($"parameter should not be null : {nameof(invoices)}");
            }
            this.invoices = invoices;
        }

        /// <summary>
        /// Should return a total value of an invoice with a given id. If an invoice does not exist null should be returned.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <returns></returns>
        public decimal? GetTotal(int invoiceId)
        {
            var invoice = this.invoices.FirstOrDefault(f => f.Id == invoiceId);
            if (invoice == null)
            {
                return null;
            }

            return invoice.InvoiceItems.Sum(s => s.Count * s.Price);
        }

        /// <summary>
        /// Should return a total value of all unpaid invoices.
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalOfUnpaid()
        {
            return invoices.Where(w => w.AcceptanceDate == null).Sum(i => i.InvoiceItems.Sum(s => s.Count * s.Price));
        }

        /// <summary>
        /// Should return a dictionary where the name of an invoice item is a key and the number of bought items is a value.
        /// The number of bought items should be summed within a given period of time (from, to). Both the from date and the end date can be null.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public IReadOnlyDictionary<string, long> GetItemsReport(DateTime? from, DateTime? to)
        {
            IQueryable<Invoice> scopedInvoiceList = this.invoices;

            if (from.HasValue)
            {
                scopedInvoiceList = scopedInvoiceList.Where(w => w.CreationDate >= from);
            }
            if (to.HasValue)
            {
                scopedInvoiceList = scopedInvoiceList.Where(w => w.CreationDate <= to);
            }

            return scopedInvoiceList.SelectMany(s => s.InvoiceItems).GroupBy(g => g.Name)
                .Select(s => new KeyValuePair<string, long>(s.First().Name, s.Sum(c => c.Count))).ToDictionary(d => d.Key, v => v.Value);
        }
    }

    // Please do not uncomment the classes.
    public class Invoice
    {
        // A unique numerical identifier of an invoice (mandatory)
        public int Id { get; set; }
        // A short description of an invoice (optional).
        public string Description { get; set; }
        // A number of an invoice e.g. 134/10/2018 (mandatory).
        public string Number { get; set; }
        // An issuer of an invoice e.g. Metz-Anderson, 600  Hickman Street,Illinois (mandatory).
        public string Seller { get; set; }
        // A buyer of a service or a product e.g. John Smith, 4285  Deercove Drive, Dallas (mandatory).
        public string Buyer { get; set; }
        // A date when an invoice was issued (mandatory).
        public DateTime CreationDate { get; set; }
        // A date when an invoice was paid (optional).
        public DateTime? AcceptanceDate { get; set; }
        // A collection of invoice items for a given invoice (can be empty but is never null).
        public IList<InvoiceItem> InvoiceItems { get; }

        public Invoice()
        {
            InvoiceItems = new List<InvoiceItem>();
        }
    }

    public class InvoiceItem
    {
        // A name of an item e.g. eggs.
        public string Name { get; set; }
        // A number of bought items e.g. 10.
        public uint Count { get; set; }
        // A price of an item e.g. 20.5.
        public decimal Price { get; set; }
    }
}
