using System.Runtime.Intrinsics.X86;
using static DemoG01.Data.ListGenerator;

namespace AssSoulation
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            #region Element Operators
            #region Q1
            //var res = ProductList?.First();
            #endregion

            #region Q2
            //var res = ProductList?.FirstOrDefault(p=>p.UnitPrice  > 1000);
            #endregion

            #region Q3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Where(n=> n >  5).Skip(1).First();
            //Console.WriteLine(res);
            #endregion

            #endregion

            #region Aggregate Operators
            #region Q1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Count(n => n % 2 != 0);
            //Console.WriteLine(res);
            #endregion

            #region Q2

            //var res = CustomerList.Select(g => new
            //{
            //    g.CustomerName,
            //    order = g.Orders.Count()
            //});
            //Console.WriteLine(string.Join("\n" , res));
            #endregion


            #region Q3
            //var res = ProductList.GroupBy(c=>c.Category).Select((c)=>new {Name = c.Key , Count = c.Count()} );
            //Console.WriteLine(string.Join("\n" , res));
            #endregion


            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Sum();
            #endregion

            #region Q5
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var res  = words.Select(w => new { Word = w, w.Length });
            #endregion


            #region Q6

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var res  = words?.MinBy(w => w.Length )?.Length;
            //Console.WriteLine(res);
            #endregion

            #region Q7
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var res  = words?.MaxBy(w => w.Length )?.Length;
            //Console.WriteLine(res);
            #endregion

            #region Q8
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var res = words?.Average(w => w.Length);
            //Console.WriteLine(res);
            #endregion

            #region Q9
            //var res = ProductList?.GroupBy(p => p.Category).Select(c => new
            //{
            //    Category = c.Key,
            //    InStock = c.Sum(p => p.UnitsInStock)
            //});
            //Console.WriteLine(string.Join("\n" , res));
            #endregion

            #region Q10

            //var res = ProductList?.GroupBy(p => p.Category).Select(c => new
            //{
            //    Category = c.Key,
            //    UnitPrice  = c.Min(p => p.UnitPrice)
            //});
            //Console.WriteLine(string.Join("\n" , res));

            #endregion

            #region Q11

            //var res = from p in ProductList
            //          group p by p.Category into g
            //          let minPrice = g.Min(x => x.UnitPrice)
            //          from p2 in g
            //          where p2.UnitPrice == minPrice
            //          select p2;
            //Console.WriteLine(string.Join("\n" , res));

            #endregion
            #endregion


        }
    }
}
