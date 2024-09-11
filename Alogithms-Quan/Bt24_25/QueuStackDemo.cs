
using System;
using System.ComponentModel;

namespace Alogithms_Quan.Bt24_25
{
    internal class QueuStackDemo
    {
        static void Main(string[] args)
        {
            MyQueue<int> myQueue = new MyQueue<int>();

            MyStack<int> myStack = new MyStack<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);

            myQueue.Dequeue();
            int q = myQueue.Peek();
            Console.WriteLine("Lay ra phan tu hang dau "+ q);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            myStack.Pop();

            int s = myStack.Peek();
            Console.WriteLine("Lay ra phan tu hang dau " + s);

        }
    }
}
