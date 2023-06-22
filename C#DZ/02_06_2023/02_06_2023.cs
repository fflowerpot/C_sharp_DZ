using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DZ._02_06_2023
{
    ////клас для черги з пріорітетом

    //public class PriorityQueue<T>
    //{
    //    private Dictionary<T, int> items;
    //    private List<T> queue;

    //    public int Count { get { return queue.Count; } }

    //    public PriorityQueue()
    //    {
    //        items = new Dictionary<T, int>();
    //        queue = new List<T>();
    //    }

    //    public void Enqueue(T item, int priority)
    //    {
    //        items[item] = priority;
    //        int index = 0;
    //        while (index < queue.Count && items[queue[index]] <= priority)//підглянув код в мережі якщо я правильно розумію в items[queue[index]] <= priority - береться елемент з ліста за відповідним ітераторо який підставляється в Dictionary і за допомогою нього викликається його пріоритет який вже й порівнюється з новим пріортетом
    //        {
    //            index++;
    //        }
    //        queue.Insert(index, item);
    //    }

    //    public T Dequeue()
    //    {
    //        if (queue.Count == 0)
    //        {
    //            throw new InvalidOperationException("Queue is empty.");
    //        }

    //        T item = queue[0];
    //        queue.RemoveAt(0);
    //        items.Remove(item);
    //        return item;
    //    }

    //    public T Peek()
    //    {
    //        if (queue.Count == 0)
    //        {
    //            throw new InvalidOperationException("Queue is empty.");
    //        }

    //        return queue[0];
    //    }
    //}
    ////--//
    ////Кільцева Черга

    //public class CircularQueue<T>
    //{
    //    private T[] buffer;
    //    private int front;
    //    private int rear;
    //    private int count;

    //    public int Capacity { get; private set; }
    //    public int Count => count;
    //    public bool IsEmpty => count == 0;
    //    public bool IsFull => count == Capacity;

    //    public CircularQueue(int capacity)
    //    {
    //        if (capacity <= 0)
    //            throw new ArgumentException("Capacity must be greater than zero.");

    //        Capacity = capacity;
    //        buffer = new T[Capacity];
    //        front = 0;
    //        rear = -1;
    //        count = 0;
    //    }

    //    public void Enqueue(T item)
    //    {
    //        if (IsFull)
    //            throw new InvalidOperationException("Queue is full.");

    //        rear = (rear + 1) % Capacity;
    //        buffer[rear] = item;
    //        count++;
    //    }

    //    public T Dequeue()
    //    {
    //        if (IsEmpty)
    //            throw new InvalidOperationException("Queue is empty.");

    //        T item = buffer[front];
    //        front = (front + 1) % Capacity;
    //        count--;
    //        return item;
    //    }
    //    //виводить найстаріший елемент в черзі
    //    public T Peek()
    //    {
    //        if (IsEmpty)
    //            throw new InvalidOperationException("Queue is empty.");

    //        return buffer[front];
    //    }

    //    public void Clear()
    //    {
    //        front = 0;
    //        rear = -1;
    //        count = 0;
    //    }
    //}
    ////--//
    ////однозв’язний список
    //public class SinglyLinkedList<T>
    //{
    //    private class Node
    //    {
    //        public T Value { get; set; }
    //        public Node Next { get; set; }

    //        public Node(T value)
    //        {
    //            Value = value;
    //            Next = null;
    //        }
    //    }

    //    private Node head;
    //    private Node tail;
    //    private int count;

    //    public int Count => count;
    //    public bool IsEmpty => count == 0;

    //    public void AddFirst(T value)
    //    {
    //        Node newNode = new Node(value);

    //        if (IsEmpty)
    //        {
    //            head = newNode;
    //            tail = newNode;
    //        }
    //        else
    //        {
    //            newNode.Next = head;
    //            head = newNode;
    //        }

    //        count++;
    //    }

    //    public void AddLast(T value)
    //    {
    //        Node newNode = new Node(value);

    //        if (IsEmpty)
    //        {
    //            head = newNode;
    //            tail = newNode;
    //        }
    //        else
    //        {
    //            tail.Next = newNode;
    //            tail = newNode;
    //        }

    //        count++;
    //    }

    //    public void RemoveFirst()
    //    {
    //        if (IsEmpty)
    //            throw new InvalidOperationException("The list is empty.");

    //        if (head == tail)
    //        {
    //            head = null;
    //            tail = null;
    //        }
    //        else
    //        {
    //            head = head.Next;
    //        }

    //        count--;
    //    }

    //    public void RemoveLast()
    //    {
    //        if (IsEmpty)
    //            throw new InvalidOperationException("The list is empty.");

    //        if (head == tail)
    //        {
    //            head = null;
    //            tail = null;
    //        }
    //        else
    //        {
    //            Node currentNode = head;
    //            while (currentNode.Next != tail)
    //            {
    //                currentNode = currentNode.Next;
    //            }

    //            currentNode.Next = null;
    //            tail = currentNode;
    //        }

    //        count--;
    //    }

    //    public bool Contains(T value)
    //    {
    //        Node currentNode = head;
    //        while (currentNode != null)
    //        {
    //            if (currentNode.Value.Equals(value))
    //                return true;

    //            currentNode = currentNode.Next;
    //        }

    //        return false;
    //    }

    //    public void Clear()
    //    {
    //        head = null;
    //        tail = null;
    //        count = 0;
    //    }
    //}
    ////--//
    ////двозв’язковий список
    //public class DoublyLinkedList<T>
    //{
    //    private class Node
    //    {
    //        public T Value { get; set; }
    //        public Node Previous { get; set; }
    //        public Node Next { get; set; }

    //        public Node(T value)
    //        {
    //            Value = value;
    //            Previous = null;
    //            Next = null;
    //        }
    //    }

    //    private Node head;
    //    private Node tail;
    //    private int count;

    //    public int Count => count;
    //    public bool IsEmpty => count == 0;

    //    public void AddFirst(T value)
    //    {
    //        Node newNode = new Node(value);

    //        if (IsEmpty)
    //        {
    //            head = newNode;
    //            tail = newNode;
    //        }
    //        else
    //        {
    //            newNode.Next = head;
    //            head.Previous = newNode;
    //            head = newNode;
    //        }

    //        count++;
    //    }

    //    public void AddLast(T value)
    //    {
    //        Node newNode = new Node(value);

    //        if (IsEmpty)
    //        {
    //            head = newNode;
    //            tail = newNode;
    //        }
    //        else
    //        {
    //            newNode.Previous = tail;
    //            tail.Next = newNode;
    //            tail = newNode;
    //        }

    //        count++;
    //    }

    //    public void RemoveFirst()
    //    {
    //        if (IsEmpty)
    //            throw new InvalidOperationException("The list is empty.");

    //        if (head == tail)
    //        {
    //            head = null;
    //            tail = null;
    //        }
    //        else
    //        {
    //            head = head.Next;
    //            head.Previous = null;
    //        }

    //        count--;
    //    }

    //    public void RemoveLast()
    //    {
    //        if (IsEmpty)
    //            throw new InvalidOperationException("The list is empty.");

    //        if (head == tail)
    //        {
    //            head = null;
    //            tail = null;
    //        }
    //        else
    //        {
    //            tail = tail.Previous;
    //            tail.Next = null;
    //        }

    //        count--;
    //    }

    //    public bool Contains(T value)
    //    {
    //        Node currentNode = head;
    //        while (currentNode != null)
    //        {
    //            if (currentNode.Value.Equals(value))
    //                return true;

    //            currentNode = currentNode.Next;
    //        }

    //        return false;
    //    }

    //    public void Clear()
    //    {
    //        head = null;
    //        tail = null;
    //        count = 0;
    //    }
    //}



    //class Program
    //{
    //    //--1--//  -не певний що можна цей метод тут ставити але, так як він елементарний просто хотів показати що зробив
    //    public static void Swap<T>(ref T a, ref T b)
    //    {
    //        T temp = a;
    //        a = b;
    //        b = temp;
    //    }

    //    static void Main(string[] args)
    //    {
    //        //--2--//
    //        PriorityQueue<string> Pqueue = new PriorityQueue<string>();

    //        Pqueue.Enqueue("Item 1", 2);
    //        Pqueue.Enqueue("Item 2", 1);
    //        Pqueue.Enqueue("Item 3", 3);

    //        while (Pqueue.Count > 0)
    //        {
    //            string item = Pqueue.Dequeue();
    //            Console.WriteLine(item);
    //        }
    //        //--3--//
    //        CircularQueue<string> Cqueue = new CircularQueue<string>(5);
    //        Cqueue.Enqueue("A");
    //        Cqueue.Enqueue("B");
    //        Cqueue.Enqueue("C");

    //        string firstElement = Cqueue.Peek();
    //        Console.WriteLine(firstElement);
    //        //--4--//
    //        SinglyLinkedList<int> Squeue = new SinglyLinkedList<int>();
    //        Squeue.AddFirst(1);
    //        Squeue.AddFirst(6);
    //        Squeue.AddFirst(8);
    //        Squeue.AddFirst(5);
    //        Squeue.AddLast(55);
    //        //--5--//
    //        DoublyLinkedList<int> Dqueue = new DoublyLinkedList<int>();
    //        Dqueue.AddFirst(1);
    //        Dqueue.AddFirst(6);
    //        Dqueue.AddFirst(8);
    //        Dqueue.AddFirst(5);
    //        Dqueue.AddLast(55);
    //    }
    //}

}
