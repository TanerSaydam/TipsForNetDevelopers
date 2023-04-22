using DataAccess.Context;

namespace AnyAllMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new();

            bool result = context.Products.Any();

            bool result2 = context.Products.Any(p => p.Name == "Product 1");

            bool result3 = context.Products.All(p=> p.Name == "Product 1");

            Console.WriteLine("Hello, World!");
        }
    }
}