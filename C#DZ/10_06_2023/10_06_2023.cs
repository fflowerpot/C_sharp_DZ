using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace C_DZ._10_06_2023
{
    //----------------------------------------------------------------------------------1--------------------------------------------------------------//
    /*
     public class Program
     {
         public static void Main()
         {
             List<int> numbers = GenerateNumbers(100);
             List<int> primeNumbers = GetPrimeNumbers(numbers);
             List<int> fibonacciNumbers = GetFibonacciNumbers(numbers);

             SaveNumbersToFile(primeNumbers, "prime_numbers.txt");
             SaveNumbersToFile(fibonacciNumbers, "fibonacci_numbers.txt");

             Console.WriteLine("Statistics:");
             Console.WriteLine("Total numbers generated: " + numbers.Count);
             Console.WriteLine("Total prime numbers: " + primeNumbers.Count);
             Console.WriteLine("Total Fibonacci numbers: " + fibonacciNumbers.Count);
         }

         public static List<int> GenerateNumbers(int count)
         {
             Random random = new Random();
             List<int> numbers = new List<int>();

             for (int i = 0; i < count; i++)
             {
                 numbers.Add(random.Next(1, 100));
             }

             return numbers;
         }

         public static List<int> GetPrimeNumbers(List<int> numbers)
         {
             List<int> primeNumbers = new List<int>();

             foreach (int number in numbers)
             {
                 if (IsPrime(number))
                 {
                     primeNumbers.Add(number);
                 }
             }

             return primeNumbers;
         }

         public static bool IsPrime(int number)
         {
             if (number < 2)
             {
                 return false;
             }

             for (int i = 2; i <= Math.Sqrt(number); i++)
             {
                 if (number % i == 0)
                 {
                     return false;
                 }
             }

             return true;
         }

             public static List<int> GetFibonacciNumbers(List<int> numbers)
             {
                 List<int> fibonacciNumbers = new List<int>();

                 foreach (int number in numbers)
                 {
                     if (IsFibonacci(number))
                     {
                         fibonacciNumbers.Add(number);
                     }
                 }

                 return fibonacciNumbers;
             }

         public static bool IsFibonacci(int number)
         {
             // Перевірка, чи число є 0 або 1 (перші два числа Фібоначчі)
             if (number == 0 || number == 1)
             {
                 return true;
             }

             int prev = 0;
             int curr = 1;

             // Обчислення чисел Фібоначчі до отримання числа, яке більше або дорівнює заданому числу
             while (curr <= number)
             {
                 int next = prev + curr;
                 if (next == number)
                 {
                     return true;
                 }

                 prev = curr;
                 curr = next;
             }

             return false;
         }



         public static void SaveNumbersToFile(List<int> numbers, string filename)
         {
             using (StreamWriter writer = new StreamWriter(filename))
             {
                 foreach (int number in numbers)
                 {
                     writer.WriteLine(number);
                 }
             }
         }
     }
    */

    //-----------------------------------------------------------------------------2------------------------------------------------------------------//
    /*
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the word to search: ");
            string searchWord = Console.ReadLine();

            Console.WriteLine("Enter the word to replace: ");
            string replaceWord = Console.ReadLine();

            string filePath = "input.txt"; // Шлях до файлу

            string fileContent = File.ReadAllText(filePath);

            string modifiedContent = fileContent.Replace(searchWord, replaceWord);

            File.WriteAllText(filePath, modifiedContent);

            // Виведення статистики
            int occurrences = CountOccurrences(fileContent, searchWord);
            Console.WriteLine("Occurrences found: " + occurrences);

            Console.WriteLine("Word replaced successfully.");
        }

        // Метод для підрахунку кількості входжень слова в текст
        static int CountOccurrences(string text, string word)
        {
            string pattern = "\\b" + Regex.Escape(word) + "\\b";
            MatchCollection matches = Regex.Matches(text, pattern);
            return matches.Count;
        }
    }
    */


    //-----------------------------------------------------------------------------------------3--------------------------------------------------------//
    /*
     class Program
     {
         static void Main()
         {
             //в завданні треба було вводити вручну але я не хотів з цим бавитися з Console.WriteLine(); всеодно б записувалося в стрінг
             string filePath1 = "input.txt";
             string filePath2 = "tx.txt";
             Console.WriteLine();
             // Зчитування вмісту файлу
             string text = File.ReadAllText(filePath1);
             string mode = File.ReadAllText(filePath2);
             string[] moderationWords = mode.Split(' ');

             string moderatedText = ModerateText(text, moderationWords, '*');

             string moderatedTextFilePath = Path.Combine(Path.GetDirectoryName(filePath2), "moderated.txt");
             File.WriteAllText(moderatedTextFilePath, moderatedText); 
             Console.WriteLine("Moderation completed. Moderated text saved to: " + moderatedTextFilePath);
         }

         // Метод для підрахунку кількості входжень слова в текст
         static string ModerateText(string text, string[] moderationWords, char replacementChar)
         {
             foreach (string word in moderationWords)
             {
                 string pattern = "\\b" + Regex.Escape(word) + "\\b";
                 text = Regex.Replace(text, pattern, new string(replacementChar, word.Length), RegexOptions.IgnoreCase);
             }

             return text;
         }
    */

    //------------------------------------------------------------------------------------------4----------------------------------------------------//
    /*
    class Program
    {
        static void Main()
        {
           
            string filePath = "input.txt";

            string fileContent = File.ReadAllText(filePath);

            char[] charArray = fileContent.ToCharArray();
            Array.Reverse(charArray);
            string reversedContent = new string(charArray);

            string reversedFilePath = Path.Combine(Path.GetDirectoryName(filePath), "reversed.txt");
            File.WriteAllText(reversedFilePath, reversedContent);

            Console.WriteLine("File content reversed successfully. Reversed file created: " + reversedFilePath);
        }
    }
    */

    //------------------------------------------------------------------------------5-----------------------------------------------------------//
    /*
    class Program
    {
        static void Main()
        {

            List<int> numbers = GenerateNumbers(100000);

            string filePath = "numbers.txt";
            CreateNumberFile(filePath, numbers);

            string fileContent = File.ReadAllText(filePath);

            // Розділення чисел у файлі
            string[] numberStrings = fileContent.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Лічильники для статистики
            int positiveCount = 0;
            int negativeCount = 0;
            int twoDigitCount = 0;
            int fiveDigitCount = 0;

            // Перевірка та підрахунок чисел
            foreach (string numberString in numberStrings)
            {
                int number;
                if (int.TryParse(numberString, out number))
                {
                    if (number > 0)
                        positiveCount++;
                    else if (number < 0)
                        negativeCount++;

                    if (number >= 10 && number <= 99)
                        twoDigitCount++;
                    else if (number >= 10000 && number <= 99999)
                        fiveDigitCount++;
                }
            }

            Console.WriteLine("Positive numbers count: " + positiveCount);
            Console.WriteLine("Negative numbers count: " + negativeCount);
            Console.WriteLine("Two-digit numbers count: " + twoDigitCount);
            Console.WriteLine("Five-digit numbers count: " + fiveDigitCount);

            // Створення файлів з числами
            List<int> positiveNumbers = GetNumbersByCondition(numberStrings, x => int.Parse(x) > 0);
            CreateNumberFile("positive_numbers.txt", positiveNumbers);

            List<int> negativeNumbers = GetNumbersByCondition(numberStrings, x => int.Parse(x) < 0);
            CreateNumberFile("negative_numbers.txt", negativeNumbers);

            List<int> twoDigitNumbers = GetNumbersByCondition(numberStrings, x => int.Parse(x) >= 10 && int.Parse(x) <= 99);
            CreateNumberFile("two_digit_numbers.txt", twoDigitNumbers);

            List<int> fiveDigitNumbers = GetNumbersByCondition(numberStrings, x => int.Parse(x) >= 10000 && int.Parse(x) <= 99999);
            CreateNumberFile("five_digit_numbers.txt", fiveDigitNumbers);


        }

        static void CreateNumberFile(string fileName, List<int> numbers)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (int number in numbers)
                {
                    writer.WriteLine(number);
                }
            }
        }
        static List<int> GetNumbersByCondition(string[] numberStrings, Func<string, bool> condition)
        {
            List<int> numbers = new List<int>();
            foreach (string numberString in numberStrings)
            {
                int number;
                if (int.TryParse(numberString, out number) && condition(numberString))
                {
                    numbers.Add(number);
                }
            }
            return numbers;
        }
        public static List<int> GenerateNumbers(int count)
        {
            Random random = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                numbers.Add(random.Next(-99999, 99999));
            }

            return numbers;
        }
    }
    */
}

