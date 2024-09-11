using System;
using System.Runtime;

namespace Alogithms_Quan.Bt24_25
{
    internal class MyQueue<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public MyQueue()
        {
            head = null;
            tail = null;
        }
        /// <summary>
        /// Chen mot phan tu vao dau Queue
        /// </summary>
        /// <param name="data">phan tu can chen</param>
        public void Enqueue(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                tail = head;
            }
            else
            {

                //tail = tail.AddLast(data);
                Node<T> newNode = new Node<T>(data);
                tail.Next = newNode;
                tail = newNode;
            }
            
        }

        /// <summary>
        /// Xoa phan tu o dau Queue, Tra ve phan tu do
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (head == null)
                Console.WriteLine("LinkedList is empty");
            T data = head.Data;
            head = head.Next;
            return data;
        }
        /// <summary>
        /// Tra ve phan tu o dau Queue nhung khong xoa
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (head == null)
                Console.WriteLine("LinkedList is empty");
            return head.Data;
        }
    }

}
