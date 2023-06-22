using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DZ._15_06_2023
{
    //class Program
    //{
    //    static void Main()
    //    {
    //        //Search();
    //        //Delete();
    //        //Show();
    //    }
    //    static void Search()
    //    {
    //        Console.WriteLine("Enter the folder path:");
    //        string folderPath = Console.ReadLine();

    //        Console.WriteLine("Enter the file mask:");
    //        string fileMask = Console.ReadLine();

    //        string[] files = Directory.GetFiles(folderPath, fileMask, SearchOption.AllDirectories);

    //        Console.WriteLine("Files found:");
    //        foreach (string file in files)
    //        {
    //            Console.WriteLine(file);
    //        }
    //    }
    //    static void Delete()
    //    {
    //        Console.WriteLine("Enter the folder path:");
    //        string folderPath = Console.ReadLine();

    //        Console.WriteLine("Enter the file mask:");
    //        string fileMask = Console.ReadLine();

    //        DeleteFiles(folderPath, fileMask);

    //        Console.WriteLine("Deletion completed.");
    //    }
    //    static void DeleteFiles(string folderPath, string fileMask)
    //    {
    //        string[] files = Directory.GetFiles(folderPath, fileMask);

    //        foreach (string file in files)
    //        {
    //            File.Delete(file);
    //            Console.WriteLine("File deleted: " + file);
    //        }

    //        string[] subDirectories = Directory.GetDirectories(folderPath);

    //        foreach (string subDirectory in subDirectories)
    //        {
    //            DeleteFiles(subDirectory, fileMask);
    //            Directory.Delete(subDirectory);
    //            Console.WriteLine("Directory deleted: " + subDirectory);//якщо в папці ще є файли просто викидає помилку
    //        }
    //    }
    //    static void Show()
    //    {
    //        Console.WriteLine("Enter the folder path:");
    //        string folderPath = Console.ReadLine();

    //        ShowFiles(folderPath);
    //    }
    //    static void ShowFiles(string folderPath)
    //    {
    //        DirectoryInfo di = new DirectoryInfo(folderPath);
    //        string[] files = Directory.GetFiles(folderPath);
    //        Console.WriteLine($"Directory name:\t{di.Name}");
    //        Console.WriteLine();
    //        foreach (string file in files)
    //        {
    //            Console.WriteLine(file);
                
    //        }

    //        string[] subDirectories = Directory.GetDirectories(folderPath);

    //        foreach (string subDirectory in subDirectories)
    //        {
    //            ShowFiles(subDirectory);
               
    //        }
    //    }
    //}


}
