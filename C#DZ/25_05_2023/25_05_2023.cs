using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DZ._25_05_2023
{
    // фібоначчі
    public static class IntExtensions
    {
        public static bool IsFibonacciNumber(this int number)
        {
            if (number < 0)
                return false;

            int a = 0;
            int b = 1;

            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return b == number;
        }
    }
    //кількість слів у рдку||кількість символів в останньому слові
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries).Length;// підглянув цей код в неті сподобалося що не рахує пусті під рядки коли два пробіли підряд наприклад
        }
        public static int LengthOfLastWord(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length > 0)
            {
                string lastWord = words[words.Length - 1];
                return lastWord.Length;
            }

            return 0;
        }
        //перевіряє правильність розстановки дужок за допомогою стеку
        public static bool BracketPlacement(this string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (IsOpeningParenthesis(c))
                {
                    stack.Push(c);
                }
                else if (IsClosingParenthesis(c))
                {
                    if (stack.Count == 0 || !AreParenthesesMatching(stack.Peek(), c))
                    {
                        return false;
                    }

                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
        private static bool IsOpeningParenthesis(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        private static bool IsClosingParenthesis(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }

        private static bool AreParenthesesMatching(char opening, char closing)
        {
            return (opening == '(' && closing == ')') || (opening == '[' && closing == ']') || (opening == '{' && closing == '}');
        }
    }
    //метод для фільтрації масиву за умовою
    public static class IntArrayExtensions
    {
        public static int[] Filter(this int[] array, Predicate<int> predicate)
        {
            int[] filteredArray = Array.FindAll(array, predicate);
            return filteredArray;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //--1--//
            Console.Write("Введіть число: ");
            int Number = int.Parse(Console.ReadLine());
            bool isFibonacci = Number.IsFibonacciNumber();

            Console.WriteLine($"{Number} is {(isFibonacci ? "a Fibonacci number" : "not a Fibonacci number")}");
            //--2--//
            string text = "Hello, world!";

            int wordCount = text.WordCount();
            Console.WriteLine($"Word count: {wordCount}");
            //--3--//
            int lengthOfLastWord = text.LengthOfLastWord();//рахує разом з '!', ящо добавити до розділювача то не рахуватиме

            Console.WriteLine($"Text: {text}");
            Console.WriteLine($"Length of Last Word: {lengthOfLastWord}");
            //--4--//
            string text1 = "({bla bla}[bla])";
            Console.WriteLine($"{text1} is {(text1.BracketPlacement() ? "valid" : "invalid")}");
            string text2 = "((bla bla}[bla])";
            Console.WriteLine($"{text2} is {(text2.BracketPlacement() ? "valid" : "invalid")}");
            //--5--//
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] evenNumbers = numbers.Filter(x => x % 2 == 0);
            Console.WriteLine("Парні числа:");
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            int[] highNumbers = numbers.Filter(x => x > 5);
            Console.WriteLine("Великі числа:");
            foreach (int number in highNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}


