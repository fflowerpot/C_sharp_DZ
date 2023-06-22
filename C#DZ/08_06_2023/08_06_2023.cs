using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DZ._08_06_2023
{

    ////--1--//
    //public class EmployeeManagementApp
    //{
    //    private Dictionary<string, string> employeeCredentials;

    //    public EmployeeManagementApp()
    //    {
    //        employeeCredentials = new Dictionary<string, string>();
    //    }

    //    public void AddEmployee(string username, string password)
    //    {
    //        if (employeeCredentials.ContainsKey(username))
    //        {
    //            Console.WriteLine("Employee with the provided username already exists.");
    //            return;
    //        }

    //        employeeCredentials.Add(username, password);
    //        Console.WriteLine("Employee added successfully.");
    //    }

    //    public void RemoveEmployee(string username)
    //    {
    //        if (employeeCredentials.Remove(username))
    //        {
    //            Console.WriteLine("Employee removed successfully.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Employee with the provided username does not exist.");
    //        }
    //    }

    //    public void UpdateEmployeeCredentials(string username, string newPassword)
    //    {
    //        if (employeeCredentials.ContainsKey(username))
    //        {
    //            employeeCredentials[username] = newPassword;
    //            Console.WriteLine("Employee credentials updated successfully.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Employee with the provided username does not exist.");
    //        }
    //    }

    //    public string GetEmployeePassword(string username)
    //    {
    //        if (employeeCredentials.TryGetValue(username, out string password))
    //        {
    //            return password;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Employee with the provided username does not exist.");
    //            return null;
    //        }
    //    }
    //}
    ////--2--//
    //public class EnglishFrenchDictionary
    //{
    //    private Dictionary<string, List<string>> dictionary;

    //    public EnglishFrenchDictionary()
    //    {
    //        dictionary = new Dictionary<string, List<string>>();
    //    }

    //    public void AddWord(string word, List<string> translations)
    //    {
    //        dictionary[word] = translations;
    //        Console.WriteLine("Word added successfully.");
    //    }

    //    public void RemoveWord(string word)
    //    {
    //        if (dictionary.Remove(word))
    //        {
    //            Console.WriteLine("Word removed successfully.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Word not found in the dictionary.");
    //        }
    //    }

    //    public void RemoveTranslation(string word, string translation)
    //    {
    //        if (dictionary.ContainsKey(word))
    //        {
    //            List<string> translations = dictionary[word];
    //            if (translations.Remove(translation))
    //            {
    //                Console.WriteLine("Translation removed successfully.");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Translation not found for the word.");
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Word not found in the dictionary.");
    //        }
    //    }

    //    public void ChangeWord(string currentWord, string newWord)
    //    {
    //        if (dictionary.TryGetValue(currentWord, out List<string> translations))
    //        {
    //            dictionary.Remove(currentWord);
    //            dictionary[newWord] = translations;
    //            Console.WriteLine("Word changed successfully.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Current word not found in the dictionary.");
    //        }
    //    }

    //    public void ChangeTranslation(string word, string currentTranslation, string newTranslation)
    //    {
    //        if (dictionary.ContainsKey(word))
    //        {
    //            List<string> translations = dictionary[word];
    //            int index = translations.IndexOf(currentTranslation);
    //            if (index != -1)
    //            {
    //                translations[index] = newTranslation;
    //                Console.WriteLine("Translation changed successfully.");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Current translation not found for the word.");
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Word not found in the dictionary.");
    //        }
    //    }

    //    public void SearchTranslation(string word)
    //    {
    //        if (dictionary.TryGetValue(word, out List<string> translations))
    //        {
    //            Console.WriteLine("Translations for the word '{0}':", word);
    //            foreach (string translation in translations)
    //            {
    //                Console.WriteLine(translation);
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Word not found in the dictionary.");
    //        }
    //    }
    //}
    ////--3--//
    //public class CafeQueueApp
    //{
    //    private Queue<string> queue;
    //    private Dictionary<string, bool> reservedTables;

    //    public CafeQueueApp()
    //    {
    //        queue = new Queue<string>();
    //        reservedTables = new Dictionary<string, bool>();
    //    }

    //    public void EnqueueVisitor(string visitorName)
    //    {
    //        queue.Enqueue(visitorName);
    //        Console.WriteLine($"{visitorName} has joined the queue.");
    //    }

    //    public void BookReservedTable(string visitorName)
    //    {
    //        reservedTables[visitorName] = true;
    //        Console.WriteLine($"{visitorName} has booked a reserved table.");
    //    }

    //    public void SeatNextVisitor()
    //    {
    //        if (reservedTables.Count > 0)
    //        {
    //            foreach (var kvp in reservedTables)
    //            {
    //                if (kvp.Value)
    //                {
    //                    reservedTables[kvp.Key] = false;
    //                    Console.WriteLine($"{kvp.Key} has been seated at a reserved table.");
    //                    return;
    //                }
    //            }
    //        }

    //        if (queue.Count > 0)
    //        {
    //            string nextVisitor = queue.Dequeue();
    //            Console.WriteLine($"{nextVisitor} has been seated.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("No visitors in the queue.");
    //        }
    //    }
    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //--1--//
    //        EmployeeManagementApp app = new EmployeeManagementApp();

    //        app.AddEmployee("john.doe", "password123");
    //        app.AddEmployee("jane.smith", "password456");
    //        app.AddEmployee("mike.williams", "password789");

    //        string password = app.GetEmployeePassword("john.doe");
    //        Console.WriteLine("Password for john.doe: " + password);

    //        app.UpdateEmployeeCredentials("john.doe", "newpassword");

    //        app.RemoveEmployee("jane.smith");

    //        string nonExistingPassword = app.GetEmployeePassword("non.existing");
    //        Console.WriteLine("Password for non.existing: " + nonExistingPassword);
    //        //--2--//

    //        EnglishFrenchDictionary dictionary = new EnglishFrenchDictionary();

    //        List<string> translations1 = new List<string> { "bonjour", "salut" };
    //        dictionary.AddWord("hello", translations1);

    //        List<string> translations2 = new List<string> { "maison", "demeure" };
    //        dictionary.AddWord("house", translations2);

    //        dictionary.RemoveWord("hello");

    //        dictionary.RemoveTranslation("house", "demeure");

    //        dictionary.ChangeWord("house", "home");

    //        dictionary.ChangeTranslation("home", "maison", "foyer");

    //        dictionary.SearchTranslation("home");

    //        //--3--//
    //        CafeQueueApp cafe = new CafeQueueApp();

    //        cafe.EnqueueVisitor("Visitor 1");
    //        cafe.EnqueueVisitor("Visitor 2");
    //        cafe.EnqueueVisitor("Visitor 3");

    //        cafe.BookReservedTable("Reserved Visitor");

    //        cafe.SeatNextVisitor(); 
    //        cafe.SeatNextVisitor(); 
    //        cafe.SeatNextVisitor(); 
    //        cafe.SeatNextVisitor(); 
    //        cafe.SeatNextVisitor(); 
    //    }
    //}

}
