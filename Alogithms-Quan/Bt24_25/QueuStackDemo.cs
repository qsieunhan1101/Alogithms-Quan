
using System;

namespace Alogithms_Quan.Bt24_25
{
    internal class QueuStackDemo
    {
        static void Main(string[] args)
        {

            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(30);
            queue.Enqueue(100);
            Console.WriteLine($"Head of Queue: {queue.Peak()}");
            while (!queue.IsEmpty())
                Console.WriteLine(queue.Dequeue());
            Console.ReadLine();
        }
    }
}
