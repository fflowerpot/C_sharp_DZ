using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DZ._09_06_2023
{
//
//    //--1--//
//    public class Play : IDisposable
//    {
//        private bool disposed = false;

//        public string Title { get; set; }
//        public string Author { get; set; }
//        public string Genre { get; set; }
//        public int Year { get; set; }

//        private SomeResource resource1;
//        public Play(string title, string author, string genre, int year)
//        {
//            Title = title;
//            Author = author;
//            Genre = genre;
//            Year = year;
//            resource1 = new SomeResource();
//        }

//        public void DisplayInfo()
//        {
//            Console.WriteLine("Title: " + Title);
//            Console.WriteLine("Author: " + Author);
//            Console.WriteLine("Genre: " + Genre);
//            Console.WriteLine("Year: " + Year);
//        }

//        public void Dispose()
//        {
//            Dispose(true);
//            GC.SuppressFinalize(this);
//        }

//        protected virtual void Dispose(bool disposing)
//        {
//            if (!disposed)
//            {
//                if (disposing)
//                {
//                    resource1.Dispose();
//                }

//                disposed = true;
//            }
//        }

//        ~Play()
//        {
//            Dispose(false);
//        }
//    }

//    //--2--//
//    public class Shop : IDisposable
//    {
//        private bool disposed = false;

//        public string Name { get; set; }
//        public string Address { get; set; }
//        public ShopType Type { get; set; }

//        // Приклад ресурсів, що потребують очищення
//        private SomeResource resource1;

//        public Shop()
//        {
//            resource1 = new SomeResource();
//        }

//        public void Open()
//        {
//            Console.WriteLine("Shop is now open.");
//        }

//        public void Close()
//        {
//            Console.WriteLine("Shop is now closed.");
//        }

//        public void Dispose()
//        {
//            Dispose(true);
//            GC.SuppressFinalize(this);
//        }

//        protected virtual void Dispose(bool disposing)
//        {
//            if (!disposed)
//            {
//                if (disposing)
//                {
//                    resource1.Dispose();
//                }

//                disposed = true;
//            }
//        }

      
//        ~Shop()
//        {
//            Dispose(false);
//        }
//    }

//    public enum ShopType
//    {
//        Grocery,
//        Household,
//        Clothing,
//        Footwear
//    }

//    public class SomeResource : IDisposable
//    {
//        private bool disposed = false;
//        private List<string> t;

//        public SomeResource()
//        {
//            this.t = new List<string>();
//            while (true)
//            {
//                t.Add("bla");
//                if (t.Count() > 1000)
//                    break;
//            }
//        }

//        public void DoSomething()
//        {
//            Console.WriteLine("Doing something with SomeResource.");
//        }

//        public void Dispose()
//        {
//            Dispose(true);
//            GC.SuppressFinalize(this);
//        }

//        protected virtual void Dispose(bool disposing)
//        {
//            if (!disposed)
//            {
//                if (disposing)
//                {
//                    // Очищення ресурсів, що використовують об'єкти

//                    t.Clear(); // Очищення ресурсу t
//                }



//                disposed = true;
//            }
//        }

//        // Деструктор (Finalizer) для підтримки випадкового виклику Dispose()
//        ~SomeResource()
//        {
//            Dispose(false);
//        }
//    }


//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //--1--//
//            Play play = new Play("Hamlet", "William Shakespeare", "Tragedy", 1603);

//            play.DisplayInfo();

//            play = null;
//            GC.Collect();

//            // Затримка перед завершенням програми, хоча мб даремно того що він викликається коли сам захоче як я розумію
//            Console.ReadLine();
//            //--2--//

//            using (var shop = new Shop())
//            {
//                shop.Name = "My Shop";
//                shop.Address = "123 Main St";
//                shop.Type = ShopType.Grocery;

//                shop.Open();



//                shop.Close();
//            }

//            Console.WriteLine("Shop object disposed.");

//            Console.ReadLine();
//        }
//    }
}


