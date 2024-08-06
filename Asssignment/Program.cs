using System.Threading;
using static Asssignment.ListGenerator;
namespace Asssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Restriction Operators [where]

            #region Q1 Find all products that are out of stock.

            //var Result = ProductsList.Where(P => P.UnitsInStock == 0);

            #endregion

            #region Q2 Find all products that are in stock and cost more than 3.00 per unit

            //var Result = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

            #endregion

            #region Q3 Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where((E, I) => E.Length < I);
            #endregion

            #endregion

            #region Element Operators

            #region Q1 Get first Product out of Stock 

            //var Result = ProductsList.First(P => P.UnitsInStock == 0);
            //Console.WriteLine(Result);

            #endregion

            #region Q2 Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var Result = ProductsList.FirstOrDefault(P => P.UnitPrice > 1000);
            //Console.WriteLine(Result?.ProductName ?? "Not Found");

            #endregion

            #region Q3 Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var first = Arr.FirstOrDefault(P => P > 5);
            //var second = Arr.FirstOrDefault(P => P > 5 && P != first);
            //Console.WriteLine(second.ToString() ?? "Not found");

            #endregion

            #endregion

            #region Ordering Operators

            #region Q1 Sort a list of products by name

            //var Result = ProductsList.OrderBy(P => P.ProductName);

            #endregion

            #region Q2 Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(x => x);

            #endregion

            #region Q3 Sort a list of products by units in stock from highest to lowest.

            //var Result = ProductsList.OrderByDescending(P => P.UnitsInStock);

            #endregion

            #region Q4 Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var Result = Arr.OrderBy(E => E.Length).ThenBy(E => E);

            #endregion

            #region Q5  Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(E => E.Length).ThenBy(E => E);

            #endregion

            #region Q6  Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var Result = ProductsList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);

            #endregion

            #region Q7 Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy( E => E.Length).ThenByDescending( E => E );

            #endregion

            #region Q8 Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var Result = Arr.Where(E => E[1] == 'i').Reverse();

            #endregion

            #endregion

            #region Transformation Operators

            #region Q1 Return a sequence of just the names of a list of products

            //var Result = ProductsList.Select(P => P.ProductName);

            #endregion

            #region Q2 Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Result = words.Select(W => new
            //{
            //    L = W.ToLower(),
            //    U = W.ToUpper(),
            //});
            //foreach (var Item in Result)
            //{
            //    Console.WriteLine($"{Item.L} , {Item.U}");
            //}

            #endregion

            #region Q3 Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var Result = ProductsList.Select(P => new
            //{
            //    PId = P.ProductID,
            //    PName = P.ProductName,
            //    Price = P.UnitPrice
            //});

            #endregion

            #region Q4 Determine if the value of int in an array matches their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Select((E, I) => new
            //{
            //    Number = E,
            //    InPlace = E == I
            //});

            //Console.WriteLine("Number: In-Place?");
            //foreach (var Item in Result)
            //{
            //    Console.WriteLine($"{Item.Number}: {Item.InPlace}");
            //}

            #endregion

            #region Q5 Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            #endregion

            #region Q6 Select all orders where the order total is less than 500.00.

            //var Result = CustomersList.SelectMany(C => C.Orders).Where(O => O.Total < 500.00M);

            #endregion

            #region Q7 Select all orders where the order was made in 1998 or later

            //var Result = CustomersList.SelectMany(C => C.Orders).Where(O => O.OrderDate.Year == 1998);

            #endregion

            #endregion


            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item);
            //}
        }
    }
}
