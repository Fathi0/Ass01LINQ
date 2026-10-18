namespace Ass01LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //var result = ProductList.Where(P => P.Category == "Seafood");
            //foreach(var P in result)
            //{
            //    Console.WriteLine(P);
            //}
            //Q2
            //var result = ProductList.Select(P => P.ProductName);
            //foreach(var name in result)
            //{
            //    Console.WriteLine(name);
            //}
            //Q3
            //var result = ProductList.OrderBy(P => P.UnitPrice);
            //foreach(var P in result)
            //{
            //    Console.WriteLine(P);
            //}
            //Q4
            //var result = ProductList.Where(P => P.UnitPrice >= 10 && P.UnitPrice <= 30);
            //foreach (var P in result)
            //{
            //    Console.WriteLine(P);

            //}
            //Q5
            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Condiments");
            //foreach (var P in result)
            //{
            //    Console.WriteLine(P);
            //}
            //Q6
            //var result = ProductList.Select(P => new
            //{
            //    Name = P.ProductName,
            //    Price = P.UnitPrice,
            //    StokStatus = P.UnitsInStock > 0 ? "Avilable" : "Out Of Stock"
            //});
            //foreach(var P in result)
            //{
            //    Console.WriteLine($"{P.Name},{P.Price},{P.StokStatus}");
            //Q7
            //var result = ProductList.Select((P, I) => $"{I + 1}.{P.ProductName}");
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Q8
            //var result = ProductList.OrderBy(P=>P.Category).ThenByDescending(P=>P.UnitPrice);
            //foreach(var item in result)
            //{
            //    Console.WriteLine($"{item.Category} - {item.ProductName} - {item.UnitPrice}");
            //}
        }
    }
}
