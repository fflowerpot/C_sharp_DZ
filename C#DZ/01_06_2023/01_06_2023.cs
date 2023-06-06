using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DZ._01_06_2023
{
    //class Item
    //{
    //    public string Name { get; }
    //    public double Price { get; }

    //    public Item(string name, double price)
    //    {
    //        Name = name;
    //        Price = price;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Name} - {Price}";
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<Item> availableItems = new List<Item>()
    //    {
    //        new Item("Телефон", 1000),
    //        new Item("Ноутбук", 2000),
    //        new Item("Телевізор", 1500),
    //        new Item("Годинник", 500),
    //        new Item("Книга", 20)
    //    };

    //        Dictionary<Item, int> cart = new Dictionary<Item, int>();

    //        Console.WriteLine("Доступні товари:");
    //        for (int i = 0; i < availableItems.Count; i++)
    //        {
    //            Console.WriteLine($"{i + 1}." + availableItems[i]);
    //        }

    //        while (true)
    //        {
    //            Console.Write("Виберіть товар (або -1 для завершення покупок): ");
    //            int choice = int.Parse(Console.ReadLine());

    //            if (choice == -1)
    //                break;

    //            if (choice < 1 || choice > availableItems.Count)
    //            {
    //                Console.WriteLine("Невірний вибір товару. Спробуйте ще раз.");
    //                continue;
    //            }

    //            Item selected = availableItems[choice - 1];

    //            Console.Write("Введіть кількість товару: ");
    //            int quantity = int.Parse(Console.ReadLine());

    //            if (quantity < 1)
    //            {
    //                Console.WriteLine("Некоректна кількість товару. Спробуйте ще раз.");
    //                continue;
    //            }

    //            if (cart.ContainsKey(selected))
    //            {
    //                int currentQuantity = cart[selected];
    //                cart[selected] = currentQuantity + quantity;
    //            }
    //            else
    //            {
    //                cart[selected] = quantity;
    //            }
    //        }

    //        Console.Clear();
    //        Console.WriteLine("Ваш кошик:");

    //        double totalCost = 0;
    //        foreach (var entry in cart)
    //        {
    //            Item item = entry.Key;
    //            int quantity = entry.Value;
    //            double itemCost = item.Price * quantity;
    //            Console.WriteLine($"{item.Name} - {item.Price} x {quantity} = {itemCost}");
    //            totalCost += itemCost;
    //        }

    //        Console.WriteLine($"Загальна вартість: {totalCost}");
    //    }
    //}


}
