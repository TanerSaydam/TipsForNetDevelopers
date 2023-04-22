using DataAccess.Context;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace EagerLazyLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new();
            //Lazy Loading - Tembel yükleme
            IList<Product> products = context.Products.ToList();

            foreach (var product in products)
            {
                string categoryName = product.Category.Name;
                Console.WriteLine(categoryName);
            }

            //Eager Loading
            //IList<Product> products = context.Products.Include(p=> p.Category).ToList();



            Console.WriteLine("Hello, World!");
        }
    }
}