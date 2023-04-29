namespace RequiredMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new() { Name ="Deneme"};

            Console.WriteLine("Hello, World!");
        }
    }

    public class Product
    {        
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}