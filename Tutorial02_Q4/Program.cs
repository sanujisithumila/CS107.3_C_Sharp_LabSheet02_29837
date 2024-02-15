using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial02_Q4
{
    using System;

    public class Product
    {
        private string productName;
        private double price;

        // Constructor
        public Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
        }

        // Method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"Price: ${price:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate objects using the constructor
            Product product1 = new Product("Laptop", 999.99);
            Product product2 = new Product("Smartphone", 699.99);
            Product product3 = new Product("Headphones", 49.99);

            // Display product details
            Console.WriteLine("Product 1 Details:");
            product1.DisplayProductDetails();

            Console.WriteLine("\nProduct 2 Details:");
            product2.DisplayProductDetails();

            Console.WriteLine("\nProduct 3 Details:");
            product3.DisplayProductDetails();
        }
    }
}
