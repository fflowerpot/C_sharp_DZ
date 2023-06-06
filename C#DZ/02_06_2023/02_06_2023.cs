using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DZ._02_06_2023
{
    //клас для черги з пріорітетом

    public class PriorityQueue<T>
    {
        private Dictionary<T, int> items;
        private List<T> queue;

        public int Count { get { return queue.Count; } }

        public PriorityQueue()
        {
            items = new Dictionary<T, int>();
            queue = new List<T>();
        }

        public void Enqueue(T item, int priority)
        {
            items[item] = priority;
            int index = 0;
            while (index < queue.Count && items[queue[index]] <= priority)//підглянув код в мережі якщо я правильно розумію в items[queue[index]] <= priority - береться елемент з ліста за відповідним ітераторо який підставляється в Dictionary і за допомогою нього викликається його пріоритет який вже й порівнюється з новим пріортетом
            {
                index++;
            }
            queue.Insert(index, item);
        }

        public T Dequeue()
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T item = queue[0];
            queue.RemoveAt(0);
            items.Remove(item);
            return item;
        }

        public T Peek()
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return queue[0];
        }
    }

    class Program
    {
        //--1--//  -не певний що можна цей метод тут ставити але, так як він елементарний просто хотів показати що зробив
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            //--2--//
            PriorityQueue<string> queue = new PriorityQueue<string>();

            // Додавання елементів до черги з вказанням пріоритету
            queue.Enqueue("Item 1", 2);
            queue.Enqueue("Item 2", 1);
            queue.Enqueue("Item 3", 3);

            // Вилучення елементів з черги
            while (queue.Count > 0)
            {
                string item = queue.Dequeue();
                Console.WriteLine(item);
            }

        }
    }

}
