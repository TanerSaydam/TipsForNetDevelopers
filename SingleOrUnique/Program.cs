using DataAccess.Context;
using DataAccess.Models;

namespace SingleOrUnique;

internal class Program
{
    static void Main(string[] args)
    {
        AppDbContext context = new();

        Product product = new()
        {
            Name = "Product 0"
        };
        context.Products.Add(product);
        context.SaveChanges();
        //Console.WriteLine(product?.Name);
    }
}