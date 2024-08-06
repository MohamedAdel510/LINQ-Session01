using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            #region What is Linq

            //1- Local sequance (static).
            //Predicate<int> prd = (x) => { return x % 2 == 0; };
            //List<int> OddNumbers = Numbers.Where(X => X % 2 == 1).ToList();

            //foreach (int num in OddNumbers)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region LINQ Syntax

            #region Fluent syntax
            ////1 - Call "Linq operator" as static method 
            //var OddNumbers = Enumerable.Where(Numbers, X => X % 2 == 1);

            ////2 - call "Linq operstor" as extintion method {recomended}
            //var OddNumbers = Numbers.Where(X => X % 2 == 1);

            //foreach (var number in OddNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Query syntax
            //var OddNumbers = from N in Numbers
            //                 where N % 2 == 1
            //                 select N;

            //foreach (var number in OddNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #endregion

            #region Linq execution
            //var OddNumbers = Numbers.Where(X => X % 2 == 1).ToList(); // Where Executed with deferred execution

            //Numbers.AddRange(new[] { 11, 12, 13, 14, 15 }); 
            //foreach (var number in OddNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Data Setup
            //Console.WriteLine(ProductsList[0]);
            //Console.WriteLine(CustomersList[0]);
            #endregion

            #region Linq operators

            #region Filtration [Restriction] Operator - Where
            #region Get Elements Out Of Stock
            // Fluent
            //var Result = ProductsList.Where(p => p.UnitsInStock == 0);

            //Query
            //var Result = from P in ProductsList
            //             where P.UnitsInStock == 0
            //             select P;
            #endregion

            #region Get Elements In Stock And In Category Of Meat/Poultry 
            ////Fluent
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");

            //// Query
            //var Result = from P in ProductsList
            //             where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //             select P;
            #endregion

            #region Get Elements   Out Of Stock But In 10 Elements
            //// We need to use indexed where only valid with fluent syantax
            //var Result = ProductsList.Where((P, I) => I < 10 && P.UnitsInStock == 0);
            #endregion

            #endregion

            #region Transformation [Projection] Operators [Select , Select Many]

            #region Select Product Name
            //// Fluent 
            //var Result = ProductsList.Select(P => P.ProductName);

            //// Query
            //var Result = from P in ProductsList
            //             select P.ProductName;
            #endregion

            #region Select Customer Name
            //// Fluent 
            //var Result = CustomersList.Select(C => C.CustomerName);

            ////Query 
            //var Result = from C in CustomersList
            //             select C.CustomerName;
            #endregion

            #region Select Customer Orders
            ////Fluent
            //var Result = CustomersList.SelectMany(C => C.Orders);

            ////Query
            //var Result = from C in CustomersList
            //             from O in C.Orders
            //             select O;
            #endregion

            #region Select Product Id and Product Name 
            ////Fluent
            //var Result = ProductsList.Select(P => new  { ProductID = P.ProductID, ProductName = P.ProductName });

            ////Query
            //var Result = from P in ProductsList
            //             select new
            //             {
            //                 PId = P.ProductID,
            //                 PName = P.ProductName,
            //             };
            #endregion

            #region Select Product In Stock And Apply Discount 10 % On Its Price
            //// Fluent
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0)
            //    .Select(P => new
            //    {
            //PId = P.ProductID,
            //PName = P.ProductName,
            //OldPrice = P.UnitPrice,
            //NewPrice = P.UnitPrice * .9m
            //    });

            //// Query 
            //var Result = from P in ProductsList
            //             where P.UnitsInStock > 0
            //             select new
            //             {
            //                 PId = P.ProductID,
            //                 PName = P.ProductName,
            //                 OldPrice = P.UnitPrice,
            //                 NewPrice = P.UnitPrice * .9m
            //             };
            #endregion


            #region Indexed Select
            // Vaild only with fluent syntax
            //var Result = ProductsList.Select((P, I) => new
            //    {
            //        Index = I,
            //        PName = P.ProductName,
            //    });
            #endregion

            #endregion

            #region Ording Operators [Ascending , Descending , Reverse , ThenBy , ThenByDescending]
            #region Get Products Ordered By Price Asc
            ////Fluent
            //var Result = ProductsList.OrderBy(P => P.UnitPrice);

            ////Query
            //var Result = from P in ProductsList
            //             orderby P.UnitPrice
            //             select P;
            #endregion

            #region Get Products Ordered By Price Desc
            ////Fluent
            //var Result = ProductsList.OrderByDescending(P => P.UnitPrice);

            ////Query
            //var Result = from P in ProductsList
            //             orderby P.UnitPrice descending
            //             select P;
            #endregion

            #region Get Products Ordered By Price Asc and Number Of Items In Stock
            //var Result = ProductsList.OrderBy(P => P.UnitPrice).ThenByDescending(P => P.ProductName);

            #endregion

            #region Reverse
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0).Reverse();
            #endregion
            #endregion

            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //}

            #region Elements Operator - Immediate Execution [Valid Only With Fluent Syntax]

            #region [First - Last - FirstOrDefault - LastOrDefault]
            //var Result = ProductsList.First(); // Get First Element
            //Result = ProductsList.First(P => P.UnitsInStock == 0); // get first element match the conadition

            //Result = ProductsList.Last();// Last Element , 
            //Result = ProductsList.Last(P => P.UnitsInStock == 0);// Last Element Matches the Condition
            ////them all Throw exception if there is no element Found
            //// we use OrDefult To Handle it

            //Result = ProductsList.FirstOrDefault();
            //Result = ProductsList.LastOrDefault();
            #endregion

            #region [ ElementAt - ElementAtOrDefault ]
            //var Result = ProductsList.ElementAt(1);  
            //// Result = ProductsList.ElementAt(999);   // Will Throw Exception 
            //Result = ProductsList.ElementAtOrDefault(999);  // To Handel The Exception 
            #endregion

            #region [Single - SingleOrDefault]
            ////var Result = ProductsList.Single(P => P.UnitsInStock == 0); // Will Throw Exception 
            //// if there are many product Mathes the Condition or if there is no product

            var Result = ProductsList.SingleOrDefault(P => P.UnitsInStock == 0); 
            #endregion

            Console.WriteLine(Result?.ProductName ?? "Not Found");
            #endregion
            #endregion


        }
    }
}
