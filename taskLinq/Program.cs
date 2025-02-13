using System.ComponentModel;
using taskLinq;
using static taskLinq.ListGenerators;
namespace taskLinq
{
    public class CaseSenstive : IComparer<string>
    {

        public int Compare(string? x, string? y)
        {
            if (string.IsNullOrEmpty(x) && string.IsNullOrEmpty(y)) return 0;
            if (string.IsNullOrEmpty(x)) return -1;
            if (string.IsNullOrEmpty(y)) return 1;

            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);

        }
    }
}
public class Program
    {
        static void Main(string[] args)
        {
        //1
        //var result = ProductList.Where(a=>a.UnitsInStock==0).ToList();
        //foreach (var i in result)
        //{
        //    Console.WriteLine(i);
        //}
        //2
        //var result = ProductList.Where((a) => a.UnitPrice > 3 && a.UnitsInStock != 0).ToList();
        //foreach (var i in result)
        //{
        //    Console.WriteLine(i);
        //}
        //3
        //List<string> numbers = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
        //var result = numbers.Select((x, i) => new {word = x , value = i})
        //    .Where(p=>p.word.Length < p.value);
        //foreach (var x in result)
        //{
        //    Console.WriteLine(x);
        //}

        //-----------------------------------------------------------
        //1
        //var result = ProductList.Where(p=>p.UnitsInStock==0).Take(1);
        //foreach (var item in result)
        //{
        //    Console.WriteLine($"{item.ProductName} - - {item.UnitsInStock}");
        //}
        //2
        //var result = ProductList.Where(p => p.UnitPrice > 1000).FirstOrDefault();
        //Console.WriteLine(result);
        //3
        //List<int> numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];
        //var result = numbers.Where(n => n >= 5).Skip(1).FirstOrDefault();
        //Console.WriteLine($"Second number greater than 5 : {result}");
        //-----------------------------------------------------------
        //1
        //var result = ProductList.DistinctBy(a=>a.ProductName);
        //foreach (var i in result) 
        //{
        //    Console.WriteLine(i);
        //}
        //2
        //var result = ProductList.Select(p => p.ProductName[0])
        //    .Concat(CustomerList.Select(c => c.CompanyName[0]).Distinct());
        //foreach (var i in result)
        //{
        //    Console.WriteLine(i);
        //}
        //3
        //var result = ProductList.Select(p => p.ProductName[0])
        //    .Intersect(CustomerList.Select(c => c.CompanyName[0]).Distinct());
        //foreach (var i in result)
        //{
        //    Console.WriteLine(i);
        //}
        //4
        //var result = ProductList.Select(p => p.ProductName[0])
        //    .Except(CustomerList.Select(c => c.CompanyName[0]).Distinct());
        //foreach (var i in result)
        //{
        //    Console.WriteLine(i);
        //}
        //5
        //var result = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3))
        //    .Concat(CustomerList.Select(c => c.CompanyName.Substring(c.CompanyName.Length - 3)).Distinct());
        //foreach (var i in result)
        //{
        //    Console.WriteLine(i);
        //}
        //-----------------------------------------------------------------
        //1
        //List<int> numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];
        //var result = numbers.Where(x => x%2 != 0);
        //Console.WriteLine(result.Count());
        //2
        //var result = CustomerList.Where(p => p.Orders.Any()).Select(c => new {c.CompanyName , c.Orders });
        //foreach (var item in result)
        //{
        //    Console.WriteLine($"Name : {item.CompanyName} - No of Orders {item.Orders.Count()}");
        //}
        //3
        //var categoryCounts = ProductList.GroupBy(p => p.Category)
        //    .Select(g => new { Category = g.Key, Count = g.Count() });
        //foreach (var item in categoryCounts)
        //{
        //    Console.WriteLine(item);
        //}
        //4
        //List<int> numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];
        //var result = numbers.Sum(x => x);
        //Console.WriteLine(result);
        //5
        //string[] character = File.ReadAllLines("dictionary_english.txt");
        //int result = character.Sum(c => c.Length);
        //Console.WriteLine(result);
        //6
        //var result = ProductList.GroupBy(a => a.Category)
        //    .Select(p => new { categoryName = p.Key, numInStock = p.Sum(p => p.UnitsInStock) });
        //foreach (var item in result)
        //{
        //    Console.WriteLine($"{item.categoryName} - {item.numInStock}");
        //}
        //7
        //string[] character = File.ReadAllLines("dictionary_english.txt");
        //int result = character.Min( c=> c.Length);
        //Console.WriteLine(result);
        //8
        //var result = ProductList.GroupBy(a => a.Category)
        //    .Select(a => new { CategoryName = a.Key, minPrice = a.Min(p => p.UnitPrice) });
        //foreach (var item in result)
        //{
        //    Console.WriteLine($"{item.CategoryName} - {item.minPrice}");
        //}
        //9(Let)


        //10
        //string[] characters = File.ReadAllLines("dictionary_english.txt");
        //var result = characters.Max(c => c.Length);
        //Console.WriteLine(result);
        //11
        //var result = ProductList.GroupBy(p => p.Category)
        //    .Select(p => new { Category = p.Key, maxPrice = p.Max(p=>p.UnitPrice) });
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //12
        //var resault = ProductList.GroupBy(p => p.Category)
        //    .Select(p => new { Category = p.Key, ProductName = p.MaxBy(p => p.UnitPrice) });
        //foreach (var item in resault)
        //{
        //    Console.WriteLine($"{item.Category} - {item.ProductName.ProductName}");
        //}
        //13
        //string[] characters = File.ReadAllLines("dictionary_english.txt");
        //var result =characters.Average(x => x.Length);
        //Console.WriteLine(result);
        //14
        //var result = ProductList.GroupBy(p => p.Category)
        //    .Select(p => new { Category = p.Key, AvgPrice = p.Average(p => p.UnitPrice) });
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //----------------------------------------------------------------
        //1
        //var result = ProductList.OrderBy(p => p.ProductName);
        //foreach (var item in result) 
        //{
        //Console.WriteLine(item);
        //}
        //2
        //string[] word = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //var sortedWords = word.OrderBy(p => p, new CaseSenstive());
        //foreach (var item in word)
        //{
        //    Console.WriteLine(item); 
        //}
        //3
        //var result = ProductList.OrderByDescending(p => p.UnitsInStock);
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //4
        //List<string> numbers = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
        //var result = numbers.OrderBy(n=> n.Length).ThenBy(n=>n);
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //5
        //List<string> word = ["aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"];
        //var result = word.OrderBy(x => x).ThenBy(p=>p.ToLower());
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //6
        //var result = ProductList.OrderBy(p => p.Category)
        //    .ThenByDescending(p => p.UnitPrice);
        //foreach (var item in result)
        //{
        //    Console.WriteLine($"{item.Category} - {item.UnitPrice}");
        //}
        //7
        //List<string> word = ["aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"];
        //var result = word.OrderBy(x => x.Length).ThenByDescending(p => p.ToUpper());
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //8
        //string[] word = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        //var result = word.Where(p =>p[1] == 'i').Reverse();
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //--------------------------------------------------------------
        //1
        //var result = CustomerList.Where(p => p.Country == "Mexico")
        //    .SelectMany(x=>x.Orders).OrderBy(o=>o.OrderDate).Take(3);
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //2
        //var result = CustomerList.Where(p=>p.Country=="Mexico")
        //    .SelectMany(x=>x.Orders).OrderBy(o=>o.OrderDate).Skip(2);
        //foreach (var item in result)
        //{
        //    Console.WriteLine($"{item.OrderID} - {item.OrderDate}");
        //}
        //3
        //List<int> numbers = [ 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 ];
        //var result = numbers.TakeWhile((p, i) => p > i);
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //4
        //List<int> numbers = [ 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 ];
        //var result = numbers.SkipWhile(n=>n%3 !=0 );
        //foreach (int item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //5
        //List<int> numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];
        //var result = numbers.SkipWhile((n,i) => n >= i);
        //foreach (int item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //-----------------------------------------------------------------
        //1
        //var result = ProductList.Select(p => p.ProductName);
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //2
        //List<string> words = ["aPPLE", "BlUeBeRrY", "cHeRry"];
        //var result = words.Select(p=>new {Upper = p.ToUpper(),Lower=p.ToLower()});
        //foreach (var item in result)
        //{
        //    Console.WriteLine($"Upper : {item.Upper} - - Lower : {item.Lower}");
        //}
        //3
        //var result = ProductList.Select(p => new { p.ProductID , p.ProductName, price = p.UnitPrice });
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //4
        //List<int> numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];
        //var result = numbers.Select((x, i) => new {Num = x , y = (x==i)});
        //foreach (var item in result)
        //{
        //    Console.WriteLine($"{item.Num}: {item.y}");
        //}
        //5
        //List<int> numbersA = [ 0, 2, 4, 5, 6, 8, 9 ];
        //List<int> numbersB = [ 1, 3, 5, 7, 8];
        //var result = from a in numbersA
        //             from b in numbersB
        //             where a < b
        //             select $"{a} is less than {b}";
        //Console.WriteLine("Pairs where a < b:");
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //6
        //var result = CustomerList.SelectMany(x => x.Orders).Where(o => o.Total < 500);
        //foreach (var item in result)
        //{
        //    Console.WriteLine($"Order ID : {item.OrderID} ==> Price : {item.Total}");
        //}
        //7
        //var result = CustomerList.SelectMany(x => x.Orders).Where(o => o.OrderDate.Year >= 1998);
        //foreach (var item in result)
        //{
        //    Console.WriteLine($"Order ID : {item.OrderID}  -- Order Date : {item.OrderDate}");
        //}
        //-------------------------------------------------------------------------------------
        //1
        //string[] characters = File.ReadAllLines("dictionary_english.txt");
        //var result = characters.Contains("ei");
        //Console.WriteLine( $"Is it contain the substring 'ei'? : Answer : {result}");
        //2
        //var result = ProductList
        //    .Where(p => p.UnitsInStock == 0)
        //    .GroupBy(p => p.Category)
        //    .Select(s => new { Category = s.Key, Product = ProductList.Where(p => p.Category == s.Key) });
        //foreach (var item in result)
        //{
        //    Console.WriteLine($"Categories that have at least one product that is out of stock : {item.Category}");
        //    foreach (var item1 in item.Product)
        //    {
        //        Console.WriteLine($" - {item1.ProductName} - {item1.UnitsInStock}");
        //    }
        //3
        //var result = ProductList.GroupBy(p => p.Category)
        //    .Where(p => p.All(p=>p.UnitsInStock != 0))
        //    .Select(p => new {Category =  p.Key, Product = p.ToList()  });
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item.Category);
        //    foreach (var item1 in item.Product)
        //    {
        //        Console.WriteLine($" - {item1.ProductName} - {item1.UnitsInStock}");
        //    }
        //}
        //----------------------------------------------------------------------------------------------
        //1
        //int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        //var result = numbers.GroupBy(n => n % 5).OrderBy(n => n.Key);
        //foreach (var item in result)
        //{
        //    Console.WriteLine($"Numbers with a remainder of {item.Key} when divided by 5: {string.Join(" ", item)}");
        //}
        //2
        //string[] cahracters = File.ReadAllLines("dictionary_english.txt");
        //var result = cahracters.GroupBy(p => char.ToLower(p[0]))
        //    .OrderBy(p => p.Key);
        //foreach (var item in result)
        //{
        //    Console.WriteLine($"Words that start with '{item.Key}': {string.Join(",", item.Take(10))}");
        //}
        //3




    }
}    

