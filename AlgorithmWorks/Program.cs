using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace AlgorithmWorks
{
    using Interval = System.ValueTuple<int, int>;
    class Program
    {
        static void Main(string[] args)
        {
            // var arr = new int[] { 1, 6, 5 }; //, 6, 21, 77, 4, 23, 9, 78, 90, 10 };
            // Array.ForEach(SelectionSort(arr), Console.WriteLine);

            // Console.WriteLine(rowSumOddNumbers(42));

            // Console.WriteLine(ToJadenCase("How can mirrors be real if our eyes aren't real"));

            // GetIntegersFromList(new List<object>(){ 1,2,"a","b", "123"}); // should return { 1, 2 }only

            // Console.WriteLine(NbYear(1500000, 0.25, 1000, 2000000));

            // Console.WriteLine(ToCamelCase("i-am_a-programmer"));

            //Console.WriteLine(GetReadableTime(0));
            //Console.WriteLine(GetReadableTime(5));
            //Console.WriteLine(GetReadableTime(60));
            //Console.WriteLine(GetReadableTime(86399));
            //Console.WriteLine(GetReadableTime(359999));

            // Console.WriteLine(FindEvenIndex(new int[] { 1, 2, 3, 4, -3, -2, -4 })); // 0
            // Console.WriteLine(FindEvenIndex(new int[] { 20, 10, -80, 10, 10, 15, 35 })); // 0
            //Console.WriteLine(FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 })); // 3
            //Console.WriteLine(FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 })); // 1
            //Console.WriteLine(FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 })); // -1
            //Console.WriteLine(FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 })); // 3


            //var sudoku = new int[][]
            //    {
            //      new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
            //      new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
            //      new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
            //      new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
            //      new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
            //      new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
            //      new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
            //      new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
            //      new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
            //    };

            //Console.WriteLine(ValidateSolution(sudoku));


            // Console.WriteLine(ConvertFrac(new long[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } }));
            // Console.WriteLine(ConvertFrac(new long[,] { { 6, 13 }, { 187, 1310 }, { 31, 41 } }));

            //Console.WriteLine(Fib(0)); //0
            //Console.WriteLine(Fib(1)); // 1
            //Console.WriteLine(Fib(2)); // 1
            //Console.WriteLine(Fib(3)); // 2
            //Console.WriteLine(Fib(4)); // 3
            //Console.WriteLine(Fib(5)); // 5
            //Console.WriteLine(Fib(6)); // 8

            //Console.WriteLine(ProductFib(48950000));

            // Console.WriteLine(Alphanumeric("Mazinkazier"));

            //Console.WriteLine(SumIntervals(new Interval[] { (4, 8), (6, 10), (8, 12) }));
            // Console.WriteLine(SumIntervals(new Interval[] { }));

            //Console.WriteLine(RomanNumerals.ToRoman(2));
            //Console.WriteLine(RomanNumerals.ToRoman(1));
            //Console.WriteLine(RomanNumerals.ToRoman(9));
            //Console.WriteLine(RomanNumerals.ToRoman(984));
            // Console.WriteLine(RomanNumerals.ToRoman(3984));
            //Console.WriteLine(RomanNumerals.ToRoman(1450));

            //Console.WriteLine(RomanNumerals.FromRoman("III")); // 3
            //Console.WriteLine(RomanNumerals.FromRoman("LIV")); // 54
            //Console.WriteLine(RomanNumerals.FromRoman("MMCDI")); // 2401
            // Console.WriteLine(RomanNumerals.FromRoman("MCDL")); // 1450
            // Console.WriteLine(RomanNumerals.FromRoman("MCMXC")); // 1990

            // Permutations.SinglePermutations("aabb").ForEach(s => Console.WriteLine(s));
            // Permutations.SinglePermutations("abcde").ForEach(s => Console.WriteLine(s));


            // Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.

            //Console.WriteLine(ParseInt("thirteen"));
            //Console.WriteLine(ParseInt("zero"));
            //Console.WriteLine(ParseInt("twenty-five"));
            //Console.WriteLine(ParseInt("twenty-five hundred"));
            //Console.WriteLine(ParseInt("twenty hundred"));
            //Console.WriteLine(ParseInt("sixteen hundred thousand"));
            //Console.WriteLine(ParseInt("one hundred sixteen thousand"));
            //Console.WriteLine(ParseInt("five hundred one thousand five hundred five"));
            //Console.WriteLine(ParseInt("five hundred and one thousand five hundred five"));

            // Console.WriteLine(NextBiggerNumber(134523));
            //Console.WriteLine(NextBiggerNumber(144));
            //Console.WriteLine(NextBiggerNumber(1234567890));
            //Console.WriteLine(NextBiggerNumber(1676702431));
            // Console.WriteLine(NextBiggerNumber(9876543210));

            //Console.WriteLine(BitwiseOperations(9));
            //Console.WriteLine(BitwiseOperations(529));
            //Console.WriteLine(BitwiseOperations(20));
            //Console.WriteLine(BitwiseOperations(1041));

            //Console.WriteLine(FindMissingElement(Array.Empty<int>()));
            //Console.WriteLine(FindMissingElement(new int[] { 2 }));
            //Console.WriteLine(FindMissingElement(new int[] { 1, 2, 5, 4 }));
            //Console.WriteLine(FindMissingElement(new int[] { 2, 1, 3, 7, 6, 5 }));

            Console.WriteLine(FindAbsoluteDistincCount(new int[] { 2147483647, 0 }));
            Console.WriteLine(FindAbsoluteDistincCount(new int[] { -1, 0 }));
            Console.WriteLine(FindAbsoluteDistincCount(new int[] { -1, 0, 1 }));
            Console.WriteLine(FindAbsoluteDistincCount(new int[] { -2147483648, 0, 1 }));

            Console.ReadLine();
        }

        public static int[] SelectionSort(int[] arr)
        {
            var arrIndex = arr.Length;

            for (int i = 0; i < arrIndex -1; i++)
            {
                var min = i;

                for (int j = i+1; j < arrIndex; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                SwapItems(arr, i, min);
            }

            return arr;
        }

        public static void SwapItems(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static string RemoveVowels(string str)
        {
            return Regex.Replace(str, "[aeiou]", "");
        }

        public static string HighAndLow(string numbers)
        {
            var intAtt = numbers.Split(" ").Select(int.Parse);
            return $"{intAtt.Max()} {intAtt.Min()}";


            //var intAtt = numbers.Split(" ").Select(int.Parse);
            //return $"{intAtt.Max()} {intAtt.Min()}";

            //int? max = null, min = null;
            //var newArr = numbers.Split(" ");

            //foreach (var val in newArr.Select(c => int.Parse(c)))
            //{
            //    if (!max.HasValue)
            //    {
            //        max = min = val;
            //        continue;
            //    }

            //    if (val > max) max = val;
            //    if (val < min) min = val;
            //}

            //return $"{max} {min}";
        }

        public static int SumMinTwo(int[] numbers)
        {
            return numbers.OrderBy(i => i).Take(2).Sum();

            //Array.Sort(numbers);
            //return numbers[0] + numbers[1];
        }

        // Sum between 2 given numbers
        public int GetSum(int a, int b)
        {
            // Math.Abs mutlak deger dondurur. Cozumu anlamadim :)
            return (a + b) * (Math.Abs(a - b) + 1) / 2;

            // return Enumerable.Range(a < b ? a : b, Math.Abs(a - b) + 1).Sum();

            //if (a == b) return a;
            //var sum = 0;

            //for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            //{
            //    sum += i;
            //}

            //return sum;
        }

        // piramit seklindeki tekil sayi dizilimindeki, n. seviyedeki sayilar toplami
        public static long rowSumOddNumbers(long n)
        {
            // Okay, here's how I derived the mathmatical formula to solve this kata.
            // It was a fun journey, even though it feels like I took the long way. 
            // Eventually ending up at the perfect solution was well worth it!
            //
            // 1 |         1
            // 2 |       3   5
            // 3 |     7   9  11
            // 4 |   13  15  17  19
            // 5 | 21  23  25  27  29
            // ...
            //
            // An important thing to know is the number that the requested row [n]
            // starts with. That provides a great anchor point for computing the
            // sum of the row. So finding that number is what I started out with.
            //
            // Given for example [n] = 4, rows 1, 2 and 3 must be skipped.
            // Those contain respectively 1, 2 and 3 odd numbers, which means that in
            // total 6 odd numbers must be skipped, in order to get to the starting
            // odd number 13 for row 4.
            // 
            // The number of odd numbers to skip can be computed, based on the row
            // number [n]. For [n] = 4, look again at the part of the triangle that has
            // to be skipped, only formatted a bit differently:
            //
            //   | .
            //   |   .
            // 1 |  1   .
            // 2 |  3  5   . 
            // 3 |  7  9  11  .
            //   +--------------
            //
            // Is can in fact be represented as a simple triange. Let's extend it into a rectangle.
            //
            //   | .x  x  x      ^     The rectangle has height [n] and width [n] - 1
            //   |   . x  x      |
            // 1 |  1   . x     [n]
            // 2 |  3  5   .     |
            // 3 |  7  9  11  .  v
            //   +--------------
            //   <-- [n]-1 -->
            //
            // This makes it clear how we can compute the surface of the triangle,
            // which represents the number of odds to skip! It's half the surface of
            // the above rectangle:
            //
            //   [skip] = ([n] - 1) * [n] / 2
            //
            // Given that we start at odd number 1 and have [skip] odds to skip, the
            // following formula delivers us the starting number for row [n]:
            //
            //   [start] = 1 + [skip] * 2 
            //
            // Okay, this is going very well. We know the odd number that the
            // requested row starts with. Let's see if this indeed works out as intended...
            //
            //   given [n] = 4
            //   [skip] = (4 - 1) * 4 / 2 = 6
            //   [start] = 1 + 6 * 2 = 13
            //
            // Hurray! Row 4 does start with 13, so we're on track. Now we have to find a
            // way to compute the total for row 4, which looks like:
            //
            //   13 + 15 + 17 + 19
            //
            // We might be tempted to simply write a loop here, which produces the values
            // of the row, after which they are added up to find the row sum. Let's no go
            // that way. Instead, we can also split this problem into two separate computations:
            //
            //   13 + 13 + 13 + 13
            //         2 +  4 +  6 + 
            //   -----------------
            //                  64
            //
            // See what I did there? I basically split the computation into two
            // surface computations: a rectangular one and a triangular one.
            // These two can be added up to get to the total for row 4.
            //
            // The surface of the rectangular part can simply be computed using:
            //
            //   [rectangle surface] = [n] * [start]
            //
            // For the triangular part, we have a triangle that can be represented like this:
            //    .
            //   1  . x x x   ^
            //   1  . x x x   |
            //   1 1  . x x   2 * ([n] - 1)
            //   1 1  . x x   |
            //   1 1 1  . x   |
            //   1 1 1  . x   v
            //   <---[n]--> 
            //
            // So the surface of the triangular part can be computed using:
            //
            //   [triangle surface] = [n] * (2 * ([n] - 1)) / 2
            //                      = [n] * ([n] - 1)
            //
            // Combining the rectangular en triangular parts brings us:
            //
            //   [sum of row] = [rectangle surface] + [triangle surface] 
            //                = [n] * [start] + [n] * ([n] - 1)
            //                = [n] * [start] + [n]^2 - [n]
            //
            // Substituting [start]:
            // 
            //   [sum of row] = [n] * (1 + [skip] * 2) + [n]^2 - [n]
            //
            // Substituting [skip]:
            //
            //   [sum of row] = [n] * (1 + (([n] - 1) * [n] / 2) * 2) + [n]^2 - [n]
            //
            // Okay, wow, man, hold on... this must be simplified.
            //
            //   [sum of row] = [n] * (1 + ([n] - 1) * [n]) + [n]^2 - [n]
            //                = [n] * (1 + [n]^2 - [n]) + [n]^2 - [n]
            //                = [n] + [n]^3 - [n]^2 + [n]^2 - [n]
            //                = [n]^3
            //
            // That's what I call simplified!!
            // So the final outcome of my journey, is the following formula:
            //
            //   Given row number [n] in the triangle of consecutive odd numbers,
            //   the row sum is [n]^3
            //
            // Okay, let's write up some code to make that work...
            //
            return (long)Math.Pow(n, 3);

            //FirstValue in row: n*(n-1)+1, in row there are n values: n*(n*(n-1)+1) the difference between first and
            //every next item can be described as (n-1)*n (e.g. 7,9,11 = 7*3 + 2 + 4 = 27)
            //thus: n*(n*(n-1)+1) + n*(n-1) = n*n*n
            // return n * n * n;

            //long startVal = (n * (n -1)) + 1;
            //long addSum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    addSum += 2*i;
            //}

            //return startVal*n + addSum;
        }

        public static string ToJadenCase(string phrase)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);

            // return String.Join(" ", phrase.Split(" ").Select(s => s[0].ToString().ToUpper()+ s.Substring(1)));
            // char.ToUpper(s[0]) + s.Substring(1) de denilmis.
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.OfType<int>().Cast<int>();
            // return listOfItems.OfType<int>().Cast<int>();
            // return listOfItems.Where(w => w is int).Select(s => (int)s);
        }

        // Nufus basta p0, her sene percent kadar artiyor + disardan aug kadar geliyor, kac yil gerekli ki p sayiya ulasilsin.
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int year;
            for (year = 0; p0 < p; year++)
                p0 += (int)(p0*percent/100) + aug;

            return year;

            //int passYear = 0;
            //while (p0 < p)
            //{
            //    p0 += (int)(p0 * percent/100) + aug;
            //    passYear++;
            //}

            //return passYear;
        }

        // Her bir otobus duraginda belirli sayida insan iniyor ve biniyor, bunlar bir liste ile veriliyor
        // tum liste islendikten sonra otobuste kac kisi var donecek.
        public static int Number(List<int[]> peopleListInOut)
        {
            return peopleListInOut.Sum(x => x[0] - x[1]);
            // return peopleListInOut.Select(x => x[0] - x[1]).Sum();

            // basit cozum
            //var totalPass = 0;
            //foreach (var inOut in peopleListInOut)
            //{
            //    totalPass += inOut[0] - inOut[1];
            //}

            //return totalPass;
        }

        //accum("abcd") -> "A-Bb-Ccc-Dddd"
        //accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
        //accum("cwAt") -> "C-Ww-Aaa-Tttt"
        public static String Accum(string s)
        {
            return string.Join("-", s.Select((x, i) => char.ToUpper(x)+new string(char.ToLower(x), i)));

            //string str = "";
            //for (int i = 1; i<s.Length+1; i++)
            //{
            //    var c = s[i-1];
            //    str += char.ToUpper(c);

            //    for (int j = 1; j<i; j++)
            //    {
            //        str += char.ToLower(c);
            //    }

            //    if (i < s.Length) str += "-";
            //}

            //return str;
        }

        // "the-stealth-warrior" gets converted to "theStealthWarrior"
        // "The_Stealth_Warrior" gets converted to "TheStealthWarrior"
        public static string ToCamelCase(string str)
        {
            // namissiz ilk kelimeyi gecmis, -h veya _h gibi iki harfi aramis, sonra bu grubu(- veya _ den sonra gelen karakter oluyor aslinda) upper ile dondurmus.
            return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());

            //var arr = str.Split('-', '_', StringSplitOptions.RemoveEmptyEntries);
            //var arr = str.Split(new char[] { '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
            //return string.Join("", arr.Select((s, i) => (i == 0 ? s[0].ToString() : s[0].ToString().ToUpper()) + s.Substring(1)));
        }

        // Verilen int second degerinden formatli saat yazdirma.
        public static string GetReadableTime(int seconds)
        {
            // Adam akilli abi :) seconds / 60 kaç dakika olduğu, bunun % 60 ise kac dak. kalan oldugu, seconds % 60 ise dogrudan kac sn kaldigini verir.
            return $"{seconds / 3600,0:D2}:{seconds / 60 % 60,0:D2}:{seconds % 60,0:D2}";

            //var hours = Math.DivRem(seconds, 3600, out int remMins);
            //var mins = Math.DivRem(remMins, 60, out int remSecs);

            //return $"{hours,0:D2}:{mins,0:D2}:{remSecs,0:D2}";
        }


        // array icinde en az 3 item var, biri haric digerleri ya tek ya cift, farkli olani bulucaz.
        //[2, 4, 0, 100, 4, 11, 2602, 36]
        //Should return: 11 (the only odd number)

        //[160, 3, 1719, 19, 11, 13, -21]
        //Should return: 160 (the only even number)
        public static int Find(int[] integers)
        {
            return integers.GroupBy(number => number % 2).Single(group => group.Count() == 1).First();

            //var evenArray = integers.Where(x => x % 2 == 0).Count() > 1;

            //return evenArray ? integers.First<int>(x => x % 2 == 1) : integers.First<int>(x => x % 2 == 0);
        }

        // sol taraf ve sag taraf toplandiginda esit olan index'i donduren algoritma,
        // eger toplam direk 0 olursa index olarak 0 donecek,
        // iki tane esit toplam index'i varsa, birincisini donecek.
        public static int FindEvenIndex(int[] arr)
        {
            // yoktan bir liste olusturmus sadece FindIndex ile toplamin esitlendigi yeri bulmak icin.
            return Enumerable.Range(0, arr.Length).ToList().FindIndex(i => arr[..i].Sum() == arr[(i + 1)..].Sum());


            //int leftSum = 0, rightSum = arr.Sum();

            //for (int i = 0; i < arr.Length; ++i)
            //{
            //    rightSum -= arr[i];

            //    if (leftSum == rightSum)
            //    {
            //        return i;
            //    }

            //    leftSum += arr[i];
            //}

            //return -1;


            //for (var i = 0; i < arr.Length; i++)
            //{
            //    if (arr.Take(i).Sum() == arr.Skip(i+1).Sum()) { return i; }
            //}
            //return -1;


            //if (arr.Skip(1).Sum() == 0) return 0;

            //int leftSum = 0, rightSum = 0;
            //for (int i = 0; i<arr.Count()-1; i++)
            //{
            //    leftSum += arr[i];

            //    for (int j = i+2; j< arr.Count(); j++)
            //    {
            //        rightSum += arr[j];
            //    }

            //    if (leftSum == rightSum)
            //        return ++i;

            //    rightSum = 0;
            //}

            //return -1;
        }

        // Sudoku Validate Solution
        public static bool ValidateSolution(int[][] board)
        {
            // Her bir row, column ve region icin tek sefere toplamlarini buluyor, sonra bunlarin 45'e esitligini kontrol ediyor.
            return Enumerable
                      .Range(0, 9)
                      .SelectMany(i => new[]
                      {
                              board[i].Sum(),
                              board.Sum(b => b[i]),
                              board.Skip(3 * (i / 3)).Take(3).SelectMany(r => r.Skip(3 * (i % 3)).Take(3)).Sum()
                      })
                      .All(i => i == 45);

            //int zeroCount = 0;
            //int[][] cellArrays = new int[9][];
            //int[][] colArrays = new int[9][];

            //for (int i = 0; i < board.Length; i++)
            //{
            //    // row checks
            //    if (board[i].GroupBy(i => i).Any(g => g.Count() > 1))
            //    {
            //        return false;
            //    }

            //    for (int j = 0; j < board[i].Length; j++)
            //    {
            //        if (colArrays[j] == null)
            //        {
            //            colArrays[j] = new int[9];
            //        }

            //        // increase ther zero count.
            //        if (board[i][j] == 0 && ++zeroCount > 1)
            //            return false;

            //        colArrays[j][i] = board[i][j];

            //        // cell index'leri icin once asagidaki gibi detayli yazdim, sonra genel formulu buldum.
            //        int cellIndexRow = (i / 3)*3 + (j / 3);
            //        int cellIndexColumn = j % 3 + (i % 3)*3;
            //        if (cellArrays[cellIndexRow] == null) cellArrays[cellIndexRow] = new int[9];
            //        cellArrays[cellIndexRow][cellIndexColumn] = board[i][j];

            //        //if (i < 3)
            //        //{
            //        //    // cellIndexColumn = j % 3 + i*3;
            //        //    if (j < 3)
            //        //    {
            //        //        cellIndexRow = 0;
            //        //    }
            //        //    else if (j < 6)
            //        //    {
            //        //        cellIndexRow = 1;
            //        //    }
            //        //    else
            //        //    {
            //        //        cellIndexRow = 2;
            //        //    }
            //        //}
            //        //else if (i < 6)
            //        //{
            //        //    if (j < 3)
            //        //    {
            //        //        cellIndexRow = 3;
            //        //        // cellIndexColumn = j % 3 + (i % 3)*3;
            //        //    }
            //        //    else if (j < 6)
            //        //    {
            //        //        cellIndexRow = 4;
            //        //        //cellIndexColumn = j % 3 + (i % 3)*3;
            //        //    }
            //        //    else
            //        //    {
            //        //        cellIndexRow = 5;
            //        //        //cellIndexColumn = j % 3 + (i % 3)*3;
            //        //    }
            //        //}
            //        //else
            //        //{
            //        //    if (j < 3)
            //        //    {
            //        //        cellIndexRow = 6;
            //        //        //cellIndexColumn = j % 3 + (i % 3)*3;
            //        //    }
            //        //    else if (j < 6)
            //        //    {
            //        //        cellIndexRow = 7;
            //        //        //cellIndexColumn = j % 3 + (i % 3)*3;
            //        //    }
            //        //    else
            //        //    {
            //        //        cellIndexRow = 8;
            //        //        //cellIndexColumn = j % 3 + (i % 3)*3;
            //        //    }
            //        //}
            //    }
            //}

            //for (int i = 0; i < 9; i++)
            //{
            //    // column and cell array checks
            //    if (colArrays[i].GroupBy(i => i).Any(g => g.Count() > 1) || cellArrays[i].GroupBy(i => i).Any(g => g.Count() > 1))
            //        return false;
            //}

            //return true;
        }

        // Verilen kesirli sayilari ortak payda altinda toplayan uygulama.
        // 1/3, 1/4 ==> 4/12, 3/12 seklinde cikacak
        // alt tarafi ortak bolenlerin en buyugu
        public static string ConvertFrac(long[,] lst)
        {
            // OBEB Ortak bolenlerin en buyugu, yani 5 ve 10 icin 10
            long gcd(long a, long b) => b != 0 ? gcd(b, a % b) : a;

            // OKEK Ortak katlarin en kucugu, yani 5 ve 10 icin 5
            long lcm(long a, long b) => a * b / gcd(a, b);

            // verilen diziden bir array olusturmak icin guzel yontem
            var fracs = Enumerable.Range(0, lst.GetLength(0)).Select(i => (lst[i, 0], lst[i, 1])).ToArray();
            var cd = fracs.Aggregate(1L, (acc, f) => lcm(f.Item2, acc));
            var ans = string.Join(string.Empty, fracs.Select(f => $"({f.Item1 * cd/f.Item2},{cd})"));
            return ans;

            //long lastIndex = 1;
            //long[] denArray = new long[lst.GetLength(0)];
            //for (int i = 0; i<lst.GetLength(0); i++)
            //{
            //    denArray[i] = lst[i, 1];
            //    lastIndex *= lst[i, 1];
            //}

            //long commonDen = 0;
            //for (int i = 1; i <= lastIndex; i++)
            //{
            //    var found = true;
            //    for (int j = 0; j < denArray.Length; j++)
            //    {
            //        if (i % denArray[j] != 0)
            //        {
            //            found = false;
            //            break;
            //        }
            //    }

            //    if (found)
            //    {
            //        commonDen = i;
            //        break;
            //    }
            //}

            //var sBuilder = new StringBuilder();
            //for (int i = 0; i<lst.GetLength(0); i++)
            //{
            //    var val = lst[i, 0]*(commonDen / lst[i, 1]);
            //    sBuilder.Append($"({val},{commonDen})");
            //}

            //return sBuilder.ToString();
        }

        // Fib(n) * Fib(n+1) >= prod olan sayiyi bulacaz, esitse 1, degilse 0 dondurecez.
        public static ulong[] ProductFib(ulong prod)
        {
            // zaten fibonacci dongusunde donuyorsun, neden her bir sayiyi ayri ayri hesaplayip isleme sokuyorsun :)
            ulong[] result = { 0, 1, 0 };
            ulong next = 1;
            while (result[0] * result[1] < prod)
            {
                next = result[0] + result[1];
                result[0] = result[1];
                result[1] = next;
            }
            if (result[0] * result[1] == prod)
                result[2] = 1;
            return result;

            //for (ulong i = 0; i<prod+1; i++)
            //{
            //    var fib1 = Fib(i); // ayri ayri hesaplamaya gerek yok, benim hatam bu imis...
            //    var fib2 = Fib(i+1);
            //    var mulValue = fib1 * fib2;
            //    if (mulValue == prod)
            //        return new ulong[] { fib1, fib2, 1 };
            //    else if (mulValue > prod)
            //        return new ulong[] { fib1, fib2, 0 };
            //}

            //return null;
        }

        // Bu sekilde yazinca Fib metodunu timeout'a dustu, alttaki gibi yazinca gecti
        // ama aslinda is fibonacci dongusu icinde carpma yapilip dogrudan kontrol yapilmasiymis
        //public static ulong Fib(ulong a)
        //{
        //    if (a == 0) return 0;
        //    if (a == 1) return 1;

        //    return Fib(a-1) + Fib(a-2);
        //}

        public static ulong Fib(ulong a)
        {
            if (a == 0 || a == 1) return a;

            ulong sum = 0;
            ulong first = 0;
            ulong second = 1;
            for (ulong i = 2; i<=a; i++)
            {
                sum = first + second;
                first = second;
                second = sum;
            }

            return sum;
        }


        public static bool Alphanumeric(string str)
        {
            return new Regex("^[a-zA-Z0-9]+$").Match(str).Success;
            //if (!String.IsNullOrEmpty(str))
            //{
            //    return String.IsNullOrEmpty(Regex.Replace(str, @"[a-zA-Z0-9]", ""));
            //}

            //return false;
        }


        public static int SumIntervals((int, int)[] intervals)
        {
            var list = intervals
              .SelectMany(i => Enumerable.Range(i.Item1, i.Item2 - i.Item1));

            return list.Distinct().Count();

            //// HashSet unique bir liste, ayni degeri add etsen bile patlatmiyor ama eklemiyor da.
            //var list = new HashSet<int>();

            //foreach (var iner in intervals)
            //{
            //    for (int i = iner.Item1; i<iner.Item2; i++)
            //    {
            //        list.Add(i);
            //    }
            //}

            //return list.Count;
        }

        public static int MaxSequence(int[] arr)
        {

            return arr.Aggregate((0, 0), (t, c) => (Math.Max(0, t.Item1 + c), Math.Max(t.Item2, t.Item1 + c))).Item2;

            //if (arr.Length == 0) return 0;
            //if (arr.All(i => i < 0)) return 0;
            //if (arr.All(i => i >= 0)) return arr.Sum(i => i);

            //int sum = 0, maxSum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i; j<arr.Length; j++)
            //    {
            //        sum += arr[j];

            //        if (sum > maxSum) maxSum = sum;
            //    }

            //    sum = 0;
            //}

            //return maxSum;
        }

        public static int[] Snail(int[][] array)
        {
            var outside = new int[][]
            {
        // top (left to right)
        array[0],
        // right (top to bottom)
        array.Skip(1).Take(array.Length - 2).Select(x => x[x.Length - 1]).ToArray(),
        // bottom (right to left)
        array.Length > 1 ? array.Last().Reverse().ToArray() : new int[] {},
        // left (bottom to top)
        array.Skip(1).Take(array.Length - 2).Reverse().Select(x => x[0]).ToArray()
            };

            // Get the inside to recursively pass back into this Snail method
            var inside = array
              .Skip(1)
              .Take(array.Length - 2)
              .Select(x => x.Skip(1).Take(x.Length - 2).ToArray())
              .ToArray();

            // Return a flattened array
            return outside
              .SelectMany(x => x)
              .Concat(inside.Length > 0 ? Snail(inside) : new int[] { })
              .ToArray();
        }

        public static int[] Snail2(int[][] array)
        {
            int left = 0;
            int right = array[0].Length - 1;
            int top = 0;
            int bottom = array.Length - 1;

            List<int> result = new List<int>();
            while (true)
            {
                if (left > right)
                {
                    return result.ToArray();
                }

                if (left == right)
                {
                    for (int i = top; i <= bottom; i++)
                    {
                        result.Add(array[i][right]);
                    }

                    return result.ToArray();
                }

                for (int i = left; i < right; i++)
                {
                    result.Add(array[top][i]);
                }

                for (int i = top; i < bottom; i++)
                {
                    result.Add(array[i][right]);
                }

                for (int i = right; i > left; i--)
                {
                    result.Add(array[bottom][i]);
                }

                for (int i = bottom; i > top; i--)
                {
                    result.Add(array[i][left]);
                }

                left++;
                right--;
                top++;
                bottom--;
            }
        }

        // text içinde verilen sayıyı int olarak geri döndürme,
        // "two hundred forty-six" gibi.
        public static int ParseInt(string s)
        {
            var textNumbers = s.Replace(" and", "").Split(" ");
            var total = 0;

            // format separateNumber | bigNumber+separateNumber + pointer
            // first check pointNumbers
            // then check 
            
            // first check million
            if (textNumbers.Contains(NumberTestParser.MILLION))
            {
                return 1000000;
            }
            else if (textNumbers.Contains(NumberTestParser.THOUSAND))
            {
                var thoIndex = Array.FindIndex(textNumbers, e => e == NumberTestParser.THOUSAND);
                var firstPart = NumberTestParser.GetHundred(textNumbers[..thoIndex]);
                total = firstPart * 1000;

                if (thoIndex+1 < textNumbers.Length)
                {
                    var secondPart = NumberTestParser.GetHundred(textNumbers[++thoIndex..]);
                    total += secondPart;
                }
            }
            else
            {
                var secondPart = NumberTestParser.GetHundred(textNumbers);
                total += secondPart;
            }

            return total;
        }

        // verilen long degerinin rakamlarindan en buyuk sayiyi cikartir...
        public static long ToBiggerNumber(long n)
        {
            var digits = n.ToString().Select(s => int.Parse(s.ToString())).ToArray();
            
            Array.Sort(digits, new Comparison<int>((x, y) => y.CompareTo(x)));

            // yukaridaki tek seferde yapar...
            // Array.Sort(digits);
            // Array.Reverse(digits);
            var value = long.Parse(string.Join("", digits));
            if (value == n)
                return -1;

            return value;
        }

        // verilen long degerinin rakamlarindan en buyuk sayiyi cikartir...
        public static long NextBiggerNumber(long n)
        {
            var digits = n.ToString().Select(s => int.Parse(s.ToString())).ToArray();
            var swapIndex1 = 0;
            var swapIndex2 = 0;
            long tempNumber = 0;

            for (int i=digits.Length -1; i>0; i--)
            {
                var first = digits[i];
                for (int j = i-1; j>=0; j--)
                {
                    var second = digits[j];
                    if (first > second)
                    {
                        digits[i] = second;
                        digits[j] = first;
                        
                        long tValue = long.Parse(string.Join("", digits));
                        if (tempNumber == 0)
                        {
                            tempNumber = tValue;
                            swapIndex1 = i;
                            swapIndex2 = j;
                        }
                        else if(tValue < tempNumber)
                        {
                            tempNumber = tValue;
                            swapIndex1 = i;
                            swapIndex2 = j;
                        }
                        digits = n.ToString().Select(s => int.Parse(s.ToString())).ToArray();
                        break;
                    }
                }
            }

            if (swapIndex1 == 0 && swapIndex2 == 0)
                return -1;

            var temp = digits[swapIndex2];
            digits[swapIndex2] = digits[swapIndex1];
            digits[swapIndex1] = temp;

            Array.Sort(digits, swapIndex2+1, digits.Length - (swapIndex2+1));

            var value = long.Parse(string.Join("", digits));

            return value;
        }

        public static long NextBiggerNumber1(long n)
        {
            static string Nums(long num) => string.Concat(num.ToString().OrderByDescending(i => i));
            var num = Nums(n);
            if (num == n.ToString()) return -1;
            do
            {
                n++;
            } while (Nums(n) != num);

            return n;
        }

        // Create a function named divisors/Divisors that takes an integer n > 1 and returns an array with all of the integer's divisors(except for 1 and the number itself), from smallest to largest. If the number is prime return the string '(integer) is prime' (null in C#
        public static int[] Divisors(int n)
        {
            var divisors = new List<int>();
            // burada ben n-1 e kadar yap demiştim, elemanlar Math.Sqrt(n) kullanmışlar, daha mantıklı.
            for (int i = (int)Math.Sqrt(n); i >1 ; i--)
            {
                if (n % i == 0)
                    divisors.Add(i);
            }

            if (divisors.Count > 0)
            {
                divisors.Reverse();
                return divisors.ToArray();
            }

            return null;
        }

        public static int BitwiseOperations(int n)
        {
            var binary = Convert.ToString(n, 2);
            int zCount = 0, maxZero = 0;
            bool start = false;

            foreach (var bit in binary)
            {
                if (bit.Equals('0'))
                {
                    zCount++;
                    start = true;
                }
                else
                {
                    if (start && zCount > maxZero)
                    {
                        maxZero = zCount;
                    }
                    zCount = 0;
                    start = false;
                }
            }

            return maxZero;
        }

        public static int FindMissingElement(int[] A)
        {
            Array.Sort(A);
            if (A.Length == 0)
                    return 1;

            for (int i = 0; i< A.Length; i++)
            {
                if (A[i] != i+1)
                    return i+1;
            }

            return A.Length + 1;
        }

        // Verilen dizideki elemanların mutlak değerlerini alıp, kaç tane farklı sayı var onu döndürür.
        // long'a çevirdik çünkü -2147483648 değeri int'in max değeri 2147483647 den büyük oluyor.
        public static int FindAbsoluteDistincCount(int[] A)
        {
            return A.Select(s => Math.Abs((long)s)).GroupBy(g => g).Count();
        }

        // [-100, 1, 2, 3, 7, 5] en küçük pozitif missing eleman 4.
        public static int FindMissingMinPositiveNumber(int[] A)
        {
            Array.Sort(A);
            var positiveNumberArray = A.Where(w => w > 0).ToArray();
            if (positiveNumberArray.Count() == 0)
                return 1;

            // bunun performansi çok kötü çıktı, Any veya Contains, büyük array'ler için 6 sn den uzun sürdü, Except olan geçti.
            // return Enumerable.Range(1, positiveNumberArray.Max(m => m)+1).First(s => !positiveNumberArray.Any(s));
            return Enumerable.Range(1, positiveNumberArray.Max(m => m)+1).Except(positiveNumberArray).Min();

            // array Union ve Intgersect ornekleri.
            //int[] arr1 = new int[] { 45, 26, 99, 55, 36 };
            //int[] arr2 = new int[] { 45, 26, 99, 20, 36 };
            //var res = arr1.Union(arr2).Except(arr1.Intersect(arr2));
        }
    }

    public class RomanNumerals
    {
        private static readonly string[] R = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        private static readonly int[] N = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        public static string ToRoman1(int n)
        {
            Console.WriteLine(n);
            var s = new StringBuilder();
            for (var i = 0; i < N.Length; i++)
            {
                while (n >= N[i])
                {
                    s.Append(R[i]);
                    n -= N[i];
                }
            }
            return s.ToString();
        }

        public static int FromRoman1(string romanNumeral)
        {
            Console.WriteLine(romanNumeral);
            var v = 0;
            var s = romanNumeral;
            for (var i = 0; i < N.Length; i++)
            {
                while (s.Substring(0, Math.Min(s.Length, R[i].Length)) == R[i])
                {
                    s = s.Substring(R[i].Length);
                    v += N[i];
                }
            }
            return v;
        }


        static Dictionary<int, (string, int)[]> ConversionList = new Dictionary<int, (string, int)[]>()
        {
            {3, new (string, int)[] { ("M", 1), ("MM", 2), ("MMM",3)} },
            {2, new (string, int)[] { ("C", 1), ("CC", 2), ("CCC", 3), ("CD", 4), ("D", 5), ("DC", 6), ("DCC", 7), ("DCCC", 8), ("CM", 9)} },
            {1, new (string, int)[] { ("X", 1), ("XX", 2), ("XXX", 3), ("XL", 4), ("L", 5), ("LX", 6), ("LXX", 7), ("LXXX", 8), ("XC", 9)} },
            {0, new (string, int)[] { ("I", 1), ("II", 2), ("III", 3), ("IV", 4), ("V", 5), ("VI", 6), ("VII", 7), ("VIII", 8), ("IX", 9)} }
        };

        public static string ToRoman(int n)
        {
            var str = new StringBuilder();
            var sN = n.ToString();
            var placeHolder = sN.Length -1;
            for(int i= 0; i < sN.Length; i++)
            {
                if (sN[i] != '0')
                    str.Append(ConversionList[placeHolder][int.Parse(sN[i].ToString()) -1].Item1);
                placeHolder--;
            }

            return str.ToString();
        }

        public static int FromRoman(string romanNumeral)
        {
            var str = new StringBuilder();
            bool found = false;

            foreach (var item in ConversionList)
            {
                found = false;
                foreach (var check in item.Value.Reverse())
                {
                    if (romanNumeral.StartsWith(check.Item1))
                    {
                        romanNumeral = romanNumeral.Remove(0, check.Item1.Length);
                        str.Append(check.Item2);
                        found = true;
                    }
                }

                if (!found) str.Append("0");
            }

            return int.Parse(str.ToString());
        }
    }

    public class Permutations
    {
        public static List<string> SinglePermutations1(string s)
        {
            if (s.Length < 2)
            {
                return new List<string> { s };
            }
            var result = new HashSet<string>();
            foreach (var sub in SinglePermutations1(s.Substring(1)))
            {
                for (int i = 0; i <= sub.Length; i++)
                {
                    result.Add(sub.Substring(0, i) + s[0] + sub.Substring(i));
                }
            }
            return result.ToList();
        }

        public static List<string> SinglePermutations(string s)
        {
            var list = new List<string>();

            if (s.Length == 1)
            {
                list.Add(s);
                return list;
            }

            RecPer(list, "", s);

            return list.Distinct().ToList();
        }

        public static void RecPer(List<string> list, string pre, string rem)
        {
            if (rem.Length == 1)
                list.Add(pre + rem);
            else
            {
                for (int i = 0; i< rem.Length; i++)
                {
                    RecPer(list, pre + rem[i].ToString(), rem.Remove(i, 1));
                }
            }
        }
    }

    public class NumberTestParser
    {
        public static readonly Dictionary<string, int> separateNumbers = new()
        {
            {"zero", 0 },
            {"one", 1 },
            {"two", 2 },
            {"three", 3 },
            {"four", 4 },
            {"five", 5 },
            {"six", 6 },
            {"seven", 7 },
            {"eight", 8 },
            {"nine", 9 },
            {"ten", 10 },
            {"eleven", 11 },
            {"twelve", 12 },
            {"thirteen", 13 },
            {"fourteen", 14 },
            {"fifteen", 15 },
            {"sixteen", 16 },
            {"seventeen", 17 },
            {"eighteen", 18 },
            {"nineteen", 19 },
            {"twenty", 20 },
            {"thirty", 30 },
            {"forty", 40 },
            {"fifty", 50 },
            {"sixty", 60 },
            {"seventy", 70 },
            {"eighty", 80 },
            {"ninety", 90 }
        };

        public static readonly string MILLION = "million";
        public static readonly string THOUSAND = "thousand";
        public static readonly string HUNDRED = "hundred";

        public static readonly Dictionary<string, int> pointNumbers = new()
        {
            {"million", 1000000 },
            {"thousand", 1000 },
            {"hundred", 100 }
        };

        public static int GetHundred(string[] textNumbers)
        {
            var add = GetBasicNumber(textNumbers[0]);
            // that should be 100
            if (textNumbers.Length > 1 && textNumbers[1] == NumberTestParser.HUNDRED)
                add *= add>9 ? 10 : 100;
            if (textNumbers.Length > 2)
                add += GetBasicNumber(textNumbers[2]);

            return add;
        }

        public static int GetBasicNumber(string text)
        {
            int add = 0;
            int firstPart = 0;
            int secondPart = 0;

            if (text.Contains("-"))
            {
                var splText = text.Split("-");
                firstPart = NumberTestParser.separateNumbers[splText[0]];
                secondPart = NumberTestParser.separateNumbers[splText[1]];
                add = firstPart + secondPart;
            }
            else
            {
                add = NumberTestParser.separateNumbers[text];
            }

            return add;
        }
    }
}


