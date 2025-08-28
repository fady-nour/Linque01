using Linque01.Data;

namespace Linque01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo
            #region implicitly type local variable
            #region var 
            //must be intialize 
            // cant intialize null cant convert data type
            //use in lically    (data type detect at compile time)
            //var x = null;   in valid 
            //var x; invlid 
            //cant use as parameter or return datatype

            #endregion
            #region Dynamic
            //dynamic not must intialize 
            //can convert data type
            dynamic y = 50;
            y = "fady";
            //data type detect run time 
            //most recomended var because type safty

            #endregion
            #endregion
            #region Extension method
            //int x = 12345;
            //int d=x.Reverse();
            //Console.WriteLine(d);
            //var emp = new { id = 1, name = "fady", salary = 500 };
            //Console.WriteLine(emp.GetType());
            //var emp1 = new { Id = 1, name = "fady", salary = 500 };
            //Console.WriteLine(emp1.GetType());
            //var emp2 = new { id = 5, name = "fady", salary = 5000 };
            //Console.WriteLine(emp2.GetType());
            //var emp3 = new { id = 1, name = "fady", salary = 500, age = 24 };
            //Console.WriteLine(emp3.GetType());
            #endregion
            #region Linque
            //List<int> numbers =new List<int>() {1,2,3,4,5,6,7,8,9,10 };
            //numbers.Where(num => num == 0).ToList();

            //        List <int> oddnum=numbers.Where(num => num % 2 == 1).ToList();
            //foreach (int num in oddnum)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
            #region Fluent Syntax
            // class member static method enurable
            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var e =Enumerable.Where(Numbers,Number => Number % 2 == 1);
            ////extention method
            //var r = Numbers.Where(Number => Number % 2 == 1);
            #endregion
            #region Query syntax
            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9};
            //var odd = from x in list where x%2==1 select x;
            //foreach (var x in odd) { Console.WriteLine(x); }
            #endregion
            #region Linque Excusion ways 
            #region Deferred excustion
            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //var oddnum = list.Where(n => n % 2 == 1);
            //list.AddRange(new int[] { 11, 12, 13, 14, 15 });
            //foreach (var item in oddnum)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Immediate excusion
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var oddnum = list.Where(n => n % 2 == 1).ToList();
            //list.AddRange(new int[] { 11, 12, 13, 14, 15 });
            //foreach (var item in oddnum)
            //{
            //    Console.WriteLine(item);
            //}
            //casting aggregate element

            #endregion
            #endregion
            #region Data setup
            //Console.WriteLine(ListGenerator.ProductList[0]);
            //Console.WriteLine(ListGenerator.ProductList[1]);
            //Console.WriteLine(ListGenerator.ProductList[2]);
            #endregion
            #region FILTERation restriction
            #region Get element out of stock
            // //fluent syntax
            // var result = ListGenerator.ProductList.Where(x => x.UnitsInStock == 0);
            // //query syntax
            //result =from p in ListGenerator.ProductList
            //        where p.UnitsInStock == 0
            //        select p;

            // foreach (var unit in result) 
            // {
            // Console.WriteLine(unit);


            // }
            #endregion
            #region catagory meat orpoulrty
            //var result =ListGenerator.ProductList.Where(x => x.UnitsInStock ==0 && x.Category =="Meat/Poultry");
            //result = from x in ListGenerator.ProductList
            //         where x.UnitsInStock == 0 && x.Category == "Meat/Poultry"
            //         select x;

            //foreach (var x in result) 
            //{
            //Console.WriteLine(x);
            //}


            #endregion
            #region 
            //var result = ListGenerator.ProductList.Where((P,I) => I<10 && P.UnitsInStock == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region orders
            #region asc
            //var result =ListGenerator.ProductList.OrderBy(x => x.UnitPrice);
            //result =from c in ListGenerator.ProductList
            //      orderby c.UnitPrice
            //       select c;
            //foreach (var item in result)
            //{ 
            //Console.WriteLine(item);

            //}
            #endregion
            #region dec
            //var result = ListGenerator.ProductList.OrderByDescending(x => x.UnitPrice).ThenByDescending(x => x.UnitsInStock);
            //result = from c in ListGenerator.ProductList
            //         orderby c.UnitPrice descending
            //         select c;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region get product name

            //var result = ListGenerator.ProductList.Select(p =>p.ProductName);
            //result =from p in ListGenerator.ProductList
            //        select p.ProductName;
            //foreach (var item in result) 
            //{ 
            //Console.WriteLine(item);
            //}

            #endregion
            #region get customer name
            //var result = ListGenerator.CustomerList.Select(p => p.CustomerName);
            //result = from p in ListGenerator.CustomerList
            //         select p.CustomerName;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Get Customer orders
            // var result = ListGenerator.CustomerList.SelectMany(p => p.Orders);
            //result = from p in ListGenerator.CustomerList
            //         from o in p.Orders
            //          select o;
            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion
            #region Prodict Id && ProductName
            //var result = ListGenerator.ProductList.Select(p => new { ProductId = p.ProductID, Name = p.ProductName });
            //result = from i in ListGenerator.ProductList
            //         select new
            //         {
            //             ProductId = i.ProductID,
            //             Name = i.ProductName,

            //         };
            //foreach (var item in result) 
            //{ 
            //Console.WriteLine(item);
            //}
            #endregion
            #region example
            //var result = ListGenerator.ProductList.Where(p => p.UnitsInStock > 0)
            //    .Select(p => new { oldprice = p.UnitPrice, newprice = p.UnitPrice - (1/10 * p.UnitPrice) });
            //foreach (var item in result) 
            //{
            //Console.WriteLine(item);
            //}
            #endregion
            #region  element operator 
            // var result = ListGenerator.ProductList.First();

            // Console.WriteLine(result);
            //var result = ListGenerator.ProductList.Last();
            // Console.WriteLine(result);
            //var result = ListGenerator.ProductList.FirstOrDefault();
            //Console.WriteLine(result);
            //var result = ListGenerator.ProductList.LastOrDefault();
            //Console.WriteLine(result);
            //var result = ListGenerator.ProductList.ElementAt(0);
            //var result = ListGenerator.ProductList.ElementAtOrDefault(22);
            //Console.WriteLine(result);
            // List<int> numbers = new List<int> { 42 };
            //var result = numbers.Single();
            //Console.WriteLine(result);
            //List<int> numbers = new List<int> {  };
            //var result = numbers.SingleOrDefault();
            //Console.WriteLine(result);


            #endregion
            #region Aggregate
            //var result = ListGenerator.ProductList.Count();
            //var result = ListGenerator.ProductList.Count(p => p.UnitsInStock==0);
            // Console.WriteLine(result);
            // var result = ListGenerator.ProductList.Min(p=> p.UnitPrice);
            //  Console.WriteLine(result);

            //var re = ListGenerator.ProductList.Max(p=> p.UnitPrice);
            //Console.WriteLine(re);
            //var gd = ListGenerator.ProductList.Sum(p=> p.UnitPrice);
            //Console.WriteLine(gd);
            //var kj = ListGenerator.ProductList.Average(p=> p.UnitPrice);
            //Console.WriteLine(kj);
            //string[] Names = { "Fady", "Abdelnour", "Lotfy" };
            //var result = Names.Aggregate((S1,S2) => $"{S1} {S2}");
            //Console.WriteLine(result);
            #endregion
            #endregion
            #endregion
        }
    }
}
