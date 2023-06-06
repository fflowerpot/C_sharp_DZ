using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DZ_19_05_2023
{
    //class Product
    //{
    //    public string Name { get; }
    //    public double Price { get; }
    //    public int Quantity { get; }

    //    public Product(string name, double price, int quantity)
    //    {
    //        Name = name;
    //        Price = price;
    //        Quantity = quantity;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<Product> products = new List<Product>
    //    {
    //        new Product("Товар 1", 100, 5),
    //        new Product("Товар 2", 200, 3),
    //        new Product("Товар 3", 300, 7),
    //        new Product("Товар 4", 400, 2),
    //        new Product("Товар 5", 500, 4)
    //    };

    //        // Action<T>
    //        Action<Product> displayProduct = (product) =>
    //        {
    //            Console.WriteLine($"Найменування: {product.Name}");
    //            Console.WriteLine($"Ціна: {product.Price}");
    //            Console.WriteLine($"Кількість на складі: {product.Quantity}");
    //            Console.WriteLine();
    //        };

    //        Console.WriteLine("Інформація про товари:");
    //        foreach (Product product in products)
    //        {
    //            displayProduct(product);
    //        }

    //        // Func<TResult>
    //        Func<Product, double> calculateRevenue = (product) =>
    //        {
    //            return product.Price * product.Quantity;
    //        };

    //        double totalRevenue = 0;
    //        foreach (Product product in products)
    //        {
    //            totalRevenue += calculateRevenue(product);
    //        }

    //        Console.WriteLine($"Потенційна виручка: {totalRevenue}");

    //        // Predicate<T>
    //        Predicate<Product> filterExpensiveProducts = (product) =>
    //        {
    //            return product.Price > 500;
    //        };

    //        List<Product> filteredProducts = products.FindAll(filterExpensiveProducts);

    //        Console.WriteLine("Дорогі товари:");
    //        foreach (Product product in filteredProducts)
    //        {
    //            displayProduct(product);
    //        }

    //        // Comparison<T>
    //        products.Sort((product1, product2) => product1.Name.CompareTo(product2.Name));

    //        Console.WriteLine("Сортування за назвою:");
    //        foreach (Product product in products)
    //        {
    //            displayProduct(product);
    //        }

    //        products.Sort((product1, product2) => product1.Price.CompareTo(product2.Price));

    //        Console.WriteLine("Сортування за ціною:");
    //        foreach (Product product in products)
    //        {
    //            displayProduct(product);
    //        }

    //        products.Sort((product1, product2) => product1.Quantity.CompareTo(product2.Quantity));

    //        Console.WriteLine("Сортування за кількістю товару на складі:");
    //        foreach (Product product in products)
    //        {
    //            displayProduct(product);
    //        }
    //    }
    //}

}
