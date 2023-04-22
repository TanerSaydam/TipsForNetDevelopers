using DataAccess.Context;
using DataAccess.Models;

namespace AsReadOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new();
            IReadOnlyList<Product> products = context.Products.ToList().AsReadOnly();

            products[0].Name = "Deneme 2";

            Console.WriteLine(products[0].Name);
        }
    }
}