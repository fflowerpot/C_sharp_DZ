using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DZ._26_05_2023
{
    //class Backpack
    //{
    //    public string Color { get; set; }
    //    public string Brand { get; set; }
    //    public string Fabric { get; set; }
    //    public double Weight { get; set; }
    //    public double Volume { get; set; }
    //    public List<Item> Contents { get; private set; }

    //    public event Action<Item> ItemAdded;

    //    public Backpack(string color, string brand, string fabric, double weight, double volume)
    //    {
    //        Color = color;
    //        Brand = brand;
    //        Fabric = fabric;
    //        Weight = weight;
    //        Volume = volume;
    //        Contents = new List<Item>();
    //    }

    //    public void AddItem(Item item)
    //    {
    //        if (GetTotalOccupiedVolume() + item.Volume > Volume)
    //        {
    //            throw new Exception("Exceeded backpack volume.");
    //        }

    //        Contents.Add(item);
    //        ItemAdded?.Invoke(item);
    //    }

    //    public double GetTotalOccupiedVolume()
    //    {
    //        double totalVolume = 0;
    //        foreach (var item in Contents)
    //        {
    //            totalVolume += item.Volume;
    //        }
    //        return totalVolume;
    //    }
    //}

    //class Item
    //{
    //    public string Name { get; set; }
    //    public double Volume { get; set; }

    //    public Item(string name, double volume)
    //    {
    //        Name = name;
    //        Volume = volume;
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //--1--//
    //        string color = "yellow";

    //        Func<string, string> getRGBValue = delegate (string c)
    //        {
    //            switch (c.ToLower())
    //            {
    //                case "red":
    //                    return "255, 0, 0";
    //                case "orange":
    //                    return "255, 165, 0";
    //                case "yellow":
    //                    return "255, 255, 0";
    //                case "green":
    //                    return "0, 128, 0";
    //                case "blue":
    //                    return "0, 0, 255";
    //                case "indigo":
    //                    return "75, 0, 130";
    //                case "violet":
    //                    return "238, 130, 238";
    //                default:
    //                    return "Invalid color";
    //            }
    //        };

    //        string rgbValue = getRGBValue(color);
    //        Console.WriteLine($"RGB value for {color}: {rgbValue}");

    //        //--2--//
    //        Backpack backpack = new Backpack("Blue", "ABC Company", "Nylon", 1.5, 10);
    //        backpack.ItemAdded += item => Console.WriteLine($"Added item to backpack: {item.Name}");//підписуємо лямбда функцію виводу інформації на екран на подію яка викликається в методі добавити придмет

    //        try
    //        {
    //            Item item1 = new Item("Book", 2);
    //            backpack.AddItem(item1);

    //            Item item2 = new Item("Water Bottle", 0.5);
    //            backpack.AddItem(item2);

    //            Item item3 = new Item("Laptop acer", 4);
    //            backpack.AddItem(item3);

    //            Item item4 = new Item("Laptop hp", 4);
    //            backpack.AddItem(item3);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }

    //        Console.WriteLine($"Total occupied volume: {backpack.GetTotalOccupiedVolume()}");
    //        //--3--//
    //        int[] numbers = { 1, 21, 35, 44, 75, 63, 70, 48, 93, 11 };
    //        int count = numbers.Count(x => x % 7 == 0);//лямбда вираз виступає предикатом для функції Count
    //        Console.WriteLine($"Count of numbers divisible by seven: {count}");
    //        //--4--//
    //        int[] numbers1 = { -1, 21, -35, 44, 75, -63, 70, -48, 93, -11 };
    //        int count1 = numbers1.Count(x => x < 0);//лямбда вираз виступає предикатом для функції Count
    //        Console.WriteLine($"Count of numbers less then zero: {count1}");
    //        //--5--//
    //        int[] numbers2 = { -1, 21, -35, 44, 75, -35, 70, -48, 93, -35 };

    //        HashSet<int> uniqueNegativeNumbers = new HashSet<int>(numbers2.Where(number => number < 0));

    //        string result = string.Join(", ", uniqueNegativeNumbers);// хотів просто щоб було в рядок
    //        Console.WriteLine($"Unique numbers less then zero: {result}");
    //        //спочатку зробив так але виявилося що можна набагато простіше
    //        //Array.ForEach(numbers2, number =>
    //        //{
    //        //    if (number < 0 && uniqueNegativeNumbers.Add(number))
    //        //    {
    //        //        Console.WriteLine(number);
    //        //    }
    //        //});
    //        //--6--//
    //        string text = "This is a test text";
    //        string targetWord = "test";

    //        Func<string, string, bool> containsWord = (inputText, word) => inputText.Contains(word);

    //        bool containsTargetWord = containsWord(text, targetWord);
    //        Console.WriteLine($"Text {(containsTargetWord ? "contains" : "does not contain")} the word '{targetWord}'");

    //    }
    //}
}
