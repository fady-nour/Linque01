using Linque01.Data;
using System.Collections;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;
using System.Threading;

namespace Linque01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session 1
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
            #region Assignment 01
            #region Restriction Operators
            #region Q1
            //var result = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0);
            //result=from p in ListGenerator.ProductList
            //       where p.UnitsInStock == 0
            //       select p;
            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion
            #region Q2
            //var result = ListGenerator.ProductList.Where(p => p.UnitsInStock>0&&p.UnitPrice > 3);
            //result=from p in ListGenerator.ProductList
            //       where p.UnitPrice > 3 &&p.UnitsInStock > 0
            //       select p;
            //foreach (var unit in result) 
            //{ 
            //Console.WriteLine(unit);
            //}

            #endregion
            #region Q3
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Select((name,index) => new {Name =name,Value = index })
            //.Where(p => p.Name.Length < p.Value);
            //foreach (var item in result) 
            //{
            //Console.WriteLine(item);
            //}
            #endregion

            #endregion
            #region Element Operators
            #region Q1
            //var result = ListGenerator.ProductList.First(p => p.UnitsInStock==0);
            //Console.WriteLine(result);
            #endregion
            #region Q2
            //var result = ListGenerator.ProductList.FirstOrDefault(p => p.UnitPrice>1000);
            //Console.WriteLine(result);
            #endregion
            #region Q3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(p => p>5).ElementAt(1);
            //Console.WriteLine(result);
            #endregion
            #endregion
            #region Aggregate Operators
            #region Q1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(p => p %2 ==1);
            //Console.WriteLine(result);
            #endregion
            #region Q2
            //var result = ListGenerator.CustomersList.Select(x => new
            //{
            //    CustomerName =x.CustomerName,
            //    CountOrders=x.Orders?.Count() ??0
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q3
            //var resul = ListGenerator.ProductList.Select(p => new {Catagory=p.Category,
            //countProduct = p.ProductName.Count()});
            //foreach (var item in resul) 
            //{

            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);
            #endregion
            #region Q5

            //string[] Arr = File.ReadAllLines("dictionary_english.txt");
            //int total =Arr.Sum(x => x.Length);
            //Console.WriteLine(total);

            #endregion
            #region Q6
            //string[] Arr = File.ReadAllLines("dictionary_english.txt");
            //var words = Arr.Where(p => !string.IsNullOrEmpty(p)).ToList();
            //var result =words.OrderBy(p => p.Length).First();
            //Console.WriteLine(result);
            #endregion
            #region Q7
            //string[] arr = File.ReadAllLines("dictionary_english.txt");
            //var word = arr.Where(p => !string.IsNullOrEmpty(p)).ToList();
            //var result =word.OrderByDescending(p => p.Length).First();
            //Console.WriteLine(result);
            #endregion
            #region Q8
            //string[] arr = File.ReadAllLines("dictionary_english.txt");
            //var word = arr.Where(p => !string.IsNullOrEmpty(p)).ToList();
            //var result = word.Average(p => p.Length);
            //Console.WriteLine(result);
            #endregion
            #endregion
            #region Ordering Operators
            #region Q1
            //var result =ListGenerator.ProductList.OrderBy(x => x.ProductName);
            //foreach (var item in result) 
            //{
            //Console.WriteLine(item);
            //}

            #endregion
            #region Q2
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result =Arr.OrderBy(p => p ,StringComparer.OrdinalIgnoreCase).ToList();
            //foreach (String str in result) 
            //{
            //Console.WriteLine(str);
            //}
            #endregion
            #region Q3
            //var result = ListGenerator.ProductList.OrderByDescending
            //    (p => p.UnitsInStock).ToList ();
            //foreach (var item in result)
            //{ Console.WriteLine (item); }
            #endregion
            #region Q4
            //  string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //  var result = Arr.OrderBy(x => x.Length).ThenBy(p => p);
            //foreach (var x in result) {Console.WriteLine(x); }
            #endregion
            #region Q5
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result =Arr.OrderBy(x => x.Length).ThenBy(p =>StringComparer.OrdinalIgnoreCase);
            //foreach(var x in result) {Console.WriteLine(x); }
            #endregion
            #region Q6
            //var result =ListGenerator.ProductList.OrderByDescending(x => x.Category).ThenByDescending(p =>p.UnitPrice).ToList();
            //foreach (var item in result) {Console.WriteLine(item);}
            #endregion
            #region Q7
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result =Arr.OrderByDescending(x => x.Length).ThenByDescending(p=>StringComparer.OrdinalIgnoreCase).ToList();
            //foreach( var item in result ) {Console.WriteLine(item); }
            #endregion
            #region Q8
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.Where(p => p.Length > 1 && p[1]=='i').Reverse();
            //foreach (var item in result) {Console.WriteLine(item);}
            #endregion

            #endregion
            #region Transformation Operators
            #region Q1
            //var result =ListGenerator.ProductList.Select(x => x.ProductName).ToList();
            //foreach (var item in result) {  Console.WriteLine(item); }
            #endregion
            #region Q2
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(p => new {Uppercase=p.ToUpper(),
            //Lowercase=p.ToLower()});
            //foreach (var word in result) { Console.WriteLine(word); }
            #endregion
            #region Q3
            //var result = ListGenerator.ProductList.Select(p =>
            //new
            //{
            //    Catagory=p.Category,
            //    Productid=p.ProductID,
            //    Price=p.UnitPrice

            //});
            //foreach (var item in result) { Console.WriteLine(item); }
            #endregion
            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select ((value, index) => new { value, Match = (value == index) }) ;
            //foreach ( var item in result ) { Console.WriteLine($"{item.value} : {item.Match} "); }
            #endregion
            #region Q5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var result =from p in numbersA
            //from n in numbersB
            //where p < n
            //select new {P=p,N=n};
            //foreach (var x in result) 
            //{ Console.WriteLine($"{x.P} is less than {x.N}"); }
            #endregion
            #region Q6
            //var result = ListGenerator.CustomersList.SelectMany(p => p.Orders).Where(p=>p.Total <500);
            //foreach (var order in result) { Console.WriteLine(order); }
            #endregion
            #region Q7
            //var result = ListGenerator.CustomersList.SelectMany(c => c.Orders)
            //    .Where(p => p.OrderDate.Date.Year >= 1998);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #endregion


            #endregion
            #endregion

            #region Session 2
            #region Demo
            #region Casting operators
            //imediate excusion
            #region get product out of stock
            //List<Product> product = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0).ToList();
            //foreach (Product p in product) { Console.WriteLine(p); }
            //Product[] product = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0).ToArray();
            //foreach (Product p in product) { Console.WriteLine(p); }
            //Dictionary<long,Product> product = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID);
            // foreach(var p in product) { Console.WriteLine($"Key : {p.Key}"); Console.WriteLine($"value : {p.Value}"); }
            //Dictionary<long,string> product = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID,c=>c.ProductName);
            // foreach(var p in product) { Console.WriteLine($"Key : {p.Key}"); Console.WriteLine($"value : {p.Value}"); }
            //HashSet<Product> product = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0).ToHashSet();
            //  foreach(var p in product) { Console.WriteLine(p); }
            //oftype()
            //ArrayList arr= new ArrayList()
            //{
            //    "Ahmed",
            //    "mahmoud",
            //    "Ali",
            //    1,
            //    2,
            //    3

            //};

            //   var result = arr.OfType<string>();
            //  foreach(var i in result) {Console.WriteLine(i); }
            #endregion
            #endregion
            #region Generation operator
            //defered excusion valid only fluent syntax 
            // call static method 
            //var res = Enumerable.Range(0, 100);
            //res = Enumerable.Repeat(3,100);
            //var list = Enumerable.Empty<Product>();
            ////                 ===
            //List<Product> products = new List<Product>();
            //var list1 = Enumerable.Empty<int>();
            //List<int> p = new List<int>();
            //foreach (var x in res) {Console.Write(x);}


            #endregion
            #region set operation [union famly]
            //var seq1 = Enumerable.Range(0, 100);
            //var seq2 = Enumerable.Range(50, 100);
            //var res = seq1.Union(seq2);
            //foreach (var x in res)
            //    Console.WriteLine(x);

            //var res = seq1.Concat(seq2);
            // foreach (var x in res) 
            // Console.WriteLine(x);

            //var res = seq1.Intersect(seq2);
            //foreach (var x in res)
            //    Console.WriteLine(x);


            //var res = seq1.Except(seq2);
            //foreach (var x in res)
            //    Console.WriteLine(x);

            //var res = seq1.Concat(seq2);
            //res=res.Distinct();
            //foreach (var x in res)
            //    Console.WriteLine(x);

            #endregion
            #region Quantifier operators
            //var res = ListGenerator.ProductList.Any();
            //var res = ListGenerator.ProductList.Any(p =>p.UnitsInStock>100);
            //var res = ListGenerator.ProductList.All (p =>p.UnitsInStock>=0);
            //var seq1 = Enumerable.Range(0, 100);
            //var seq2 = Enumerable.Range(50, 100);
            //var res = seq1.SequenceEqual(seq2);
            //Console.WriteLine(res);
            #endregion
            #region zipping operators
            // string[] names = { "fady", "aymen", "hossam", "maged" };
            // int[] num =Enumerable.Range(1,10).ToArray();
            // char[] chars = { 'A', 'B', 'C','D' };
            // var res =names.Zip(chars);
            // var e=names.Zip(chars,num);
            ///*
            // * (fady,A)
            // * (aymen , B)
            // * (hossam ,C)
            // * 
            // * */
            //foreach(var s in  e)
            //     Console.WriteLine(s);

            #endregion
            #region Grouping operator
            #region get product group by cat
            //var res = ListGenerator.ProductList.GroupBy(p => p.Category);
            //res = from x in ListGenerator.ProductList
            //      group x by x.Category;

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item)
            //        Console.WriteLine(item2.ProductName);
            //}
            #endregion
            #region get product in stock group by cat
            //var res = ListGenerator.ProductList.Where(p => p.UnitsInStock > 0).GroupBy(x=>x.Category);
            //foreach (var item in res) 
            //{
            //Console.WriteLine(item.Key);
            //    foreach (var item2 in item) Console.WriteLine(item2);
            //}
            #endregion
            #region get product in stock groupe by cat that contain more than 10 product
            //var res = ListGenerator.ProductList.Where(p => p.UnitsInStock > 1)
            //    .GroupBy(x => x.Category).Where(p => p.Count() > 10);
            //res = from p in ListGenerator.ProductList
            //      where p.UnitsInStock>1
            //      group p by p.Category
            //      into cat 
            //      where cat.Count() > 10
            //      select cat;

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item) Console.WriteLine(item2.ProductName);
            //}
            #endregion
            #region get product in stock groupe by cat that contain more than 10 product
            //var res = ListGenerator.ProductList.Where(p => p.UnitsInStock > 1)
            //    .GroupBy(x => x.Category).Where(p => p.Count() > 10).Select(p => new
            //    {
            //        CatagoryName = p.Key,
            //        Countofproducr = p.Count()
            //    });

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion
            #region Partitioning operator
            //var res = ListGenerator.ProductList.Take(10);
            // res = ListGenerator.ProductList.Where(p=>p.UnitsInStock>0).Take(10);
            //foreach (var item in res) Console.WriteLine(item);
            //****************************************************************
            //var res = ListGenerator.ProductList.Skip(1);
            // res = ListGenerator.ProductList.Skip(1).Skip(10);

            //foreach (var item in res) Console.WriteLine(item);
            //*****************************************
            //var res = ListGenerator.ProductList.TakeLast(10);
            //**************************************
            //var res = ListGenerator.ProductList.SkipLast(10);
            //************************************************
            //var page1 = ListGenerator.ProductList.Take(10);
            //var page2 = ListGenerator.ProductList.Skip(10).Take(10);
            //var page3 = ListGenerator.ProductList.Skip(10).Skip(10).Take(10);
            //Console.WriteLine("==========================page1=================");
            //foreach ( var item in page1) Console.WriteLine(item);
            //Console.WriteLine("==========================page2=================");
            //foreach ( var item in page2) Console.WriteLine(item);
            //Console.WriteLine("==========================page3=================");
            ////foreach ( var item in page3) Console.WriteLine(item);
            //int[] arr = { 8, 9, 7, 4, 5, 3, 2, 1, 6 };

            //var res =arr.TakeWhile((i,v) => i < v);
            //res=arr.SkipWhile(n=>n %3!=0);
            //foreach(var i in res)Console.WriteLine(i);


            #endregion
            #region Let&&INTO
            List<string> list = new List<string>() { "FADY", "mohamed","hossam","menna"};
            //var res = from p in list
            //          select Regex.Replace(p, "[aeiouAEIOU]", string.Empty)
            //          into ewe
            //          where ewe.Length >3
            //          select ewe;
            //var res = from p in list
            //          let ewe= Regex.Replace(p, "[aeiouAEIOU]", string.Empty)
            //          where ewe.Length >3
            //          select ewe;
            //foreach (string s in res) Console.WriteLine(s);

            #endregion
            #endregion

            #endregion
            #region Assignment
            #region LINQ - Aggregate Operators


            #region Q1
            //var res = ListGenerator.ProductList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category)
            //    .Select(p => new
            //    {
            //        Catagory=p.Key,
            //        Totalunit =p.Sum(p=>p.UnitsInStock)

            //    });
            //foreach (var item in res) 
            //    Console.WriteLine(item);
            #endregion
            #region Q2
            //var res = ListGenerator.ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //    catagory=p.Key,
            //    ChepestPrice=p.Min(p=>p.UnitPrice)
            //});
            //foreach (var item in res) Console.WriteLine(item);
            #endregion
            #region Q3
            //var res = from p in ListGenerator.ProductList
            //        group p by p.Category
            //        into dd
            //        let pricecheper =dd.Min(p=>p.UnitPrice)
            //        select new
            //        {
            //            catagory=dd.Key,
            //            pricechepest= dd.Where(p=>p.UnitPrice == pricecheper)
            //        };
            //foreach (var item in res) Console.WriteLine(item);
            #endregion
            #region Q4
            //var res = ListGenerator.ProductList.GroupBy(p => p.Category).Select(p => new {
            //catagory=p.Key,
            //mostexpensive=p.Max(p=>p.UnitPrice)});
            #endregion
            #region Q5
            //var res = from p in ListGenerator.ProductList
            //          group p by p.Category
            //        into dd
            //          let priceExpensive = dd.Max(p => p.UnitPrice)
            //          select new
            //          {
            //              catagory = dd.Key,
            //              PriceExpensive = dd.Where(p => p.UnitPrice == priceExpensive)
            //          };
            //foreach (var item in res) Console.WriteLine(item);

            #endregion
            #region Q6
            //        var averagePrice = ListGenerator.ProductList.GroupBy(p => p.Category)
            //.Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) });
            //        foreach (var item in averagePrice) Console.WriteLine(item);
            #endregion
            #endregion
            #region LINQ - Set Operators
            #region Q1
            //var res = ListGenerator.ProductList.Select(p => p.Category).Distinct();
            //foreach (var item in res) Console.WriteLine(item);
            #endregion
            #region Q2
            //var res = ListGenerator.ProductList.Select(p => p.ProductName[0])
            //    .Union(ListGenerator.CustomersList.Select(p => p.CustomerName[0]);
            //foreach ( var item in res) Console.WriteLine(item);
            #endregion
            #region Q3
            //        var res = ListGenerator.ProductList.Select(p => p.ProductName[0])
            //.Intersect(ListGenerator.CustomersList.Select(c => c.CustomerName[0]));
            //        foreach (var c in res) Console.WriteLine(c);
            #endregion
            #region Q4
            //        var productOnlyLetters = ListGenerator.ProductList.Select(p => p.ProductName[0])
            //.Except(ListGenerator.CustomersList.Select(c => c.CustomerName[0]));
            //foreach ( var item in res) Console.WriteLine(item);
            #endregion
            #region Q5
            //        var res = ListGenerator.ProductList.Select(p => p.ProductName.Length >= 3 ?
            //                                                      p.ProductName.Substring(p.ProductName.Length - 3) : p.ProductName)
            //.Concat(ListGenerator.CustomersList.Select(c => c.CustomerName.Length >= 3 ?
            //                                                c.CustomerName.Substring(c.CustomerName.Length - 3) : c.CustomerName));
            //foreach ( var item in res) Console.WriteLine(item);
            #endregion
            #endregion
            #region LINQ - Partitioning Operators
            #region Q1
            //        var res = ListGenerator.CustomersList
            //.Where(c => c.City == "Washington")
            //.SelectMany(c => c.Orders)
            //.Take(3);
            //        foreach (var item in res)
            //        {
            //            Console.WriteLine(item);
            //        }

            #endregion
            #region Q2
            //        var ress = ListGenerator.CustomersList
            //.Where(c => c.City == "Washington")
            //.SelectMany(c => c.Orders)
            //.Skip(2);
            //        foreach (var item in ress)
            //        {
            //            Console.WriteLine(item);
            //        }

            #endregion
            #region Q3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((n, index) => n >= index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //;

            #endregion
            #region Q4
            //        var resul = numbers
            //.SkipWhile(n => n % 3 != 0);
            //        foreach (var item in resul)
            //        {
            //            Console.WriteLine(item);
            //        }
            #endregion
            #region Q5
            //        var resu = numbers
            //.SkipWhile((n, index) => n >= index);
            //        foreach (var item in resu)
            //        {
            //            Console.WriteLine(item);
            //        }
            #endregion
            #endregion
            #region Quantifiers
            #region Q1
            //var words = File.ReadAllLines("dictionary_english.txt");
            //bool res = words.Any(w => w.Contains("ei"));
            //Console.WriteLine(res);

            #endregion
            #region Q2
            //var re = ListGenerator.ProductList.GroupBy(p => p.Category).Where(p => p.Any(p => p.UnitsInStock == 0));
            //foreach (var item in re)
            //{
            //    Console.WriteLine(item.Key);
            //        foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}

            #endregion
            #region Q3
            // var re = ListGenerator.ProductList.GroupBy(p => p.Category).Where(p => p.All(p => p.UnitsInStock > 0));
            //foreach (var item in re)
            //{
            //    Console.WriteLine(item.Key);
            //        foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}

            #endregion
            #endregion
            #region Grouping Operators
            #region Q1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var groups = numbers.GroupBy(n => n % 5);

            //foreach (var g in groups)
            //{
            //    Console.WriteLine($"Number with Remainder {g.Key} divided by 5: \n{string.Join("\n", g)}");
            //}

            #endregion
            #region Q2
            //var words = File.ReadAllLines("dictionary_english.txt");

            //var res= words
            //    .GroupBy(w => w[0]);

            //foreach (var g in res)
            //{
            //    Console.WriteLine($"{g.Key}\n: {string.Join("\n", g)}");
            //}

            #endregion
            #region Q3
            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var res = Arr
            //    .GroupBy(w => new string(w.OrderBy(c => c).ToArray()));

            //foreach (var g in res)
            //{
            //    Console.WriteLine($"{string.Join("\n", g)}\n......");
            //}

            #endregion
            #endregion
            #endregion
            #endregion
        }
    }
}
