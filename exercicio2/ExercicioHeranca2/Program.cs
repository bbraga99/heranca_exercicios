using System.Data;
using System.Globalization;
using ExercicioHeranca2.Entities;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine($"Product #{i+1} data: ");
                Console.Write("Common, used or imported? (c/u/i)");
                string option = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(option == "c")
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                } else if (option == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Product product = new UsedProduct(name,price,date);
                    products.Add(product);
                } else if (option == "i")
                {
                    Console.Write("Custom fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product product = new ImportedProduct(name,price,fee);  
                    products.Add(product);
                }
            }

            Console.WriteLine();

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}