using System;

namespace Alogithms_Quan.Bt24_25
{

    public class Queue
    {
        public LinkedListQueue list;
        public Queue()
        {
            list = new LinkedListQueue();
        }
        public void Enqueue(int value)
        {
            list.AddLast(value);
        }
        public int Dequeue()
        {
            int value = list.GetHead();
            list.RemoveHead();
            return value;
        }
        public bool IsEmpty()
        {
            return list.IsEmpty();
        }
        public int Peak()
        {
            return list.GetHead();
        }
    }
    public class LinkedListQueue
    {
        public NodeQueue head;
        public NodeQueue tail;
        public LinkedListQueue()
        {
            head = null;
            tail = null;
        }
        public void AddLast(int value)
        {
            if (head == null)
            {
                head = new NodeQueue(value);
                tail = head;
            }
            else
            {
                tail = tail.AddLast(value);
            }
        }

        public int GetHead()
        {
            if (head == null)
                Console.WriteLine("LinkedList is empty");
            return head.GetValue();
        }

        public void RemoveHead()
        {
            if (head == null)
                Console.WriteLine("LinkedList is empty");
            head = head.GetNext();
        }
        public bool IsEmpty()
        {
            return head == null;
        }
    }
    public class NodeQueue
    {
        public int number;
        public NodeQueue next;
        public NodeQueue(int value)
        {
            number = value;
            next = null;
        }
        public NodeQueue AddLast(int value)
        {
            NodeQueue newNode = new NodeQueue(value);
            next = newNode;
            return newNode;
        }
        public int GetValue()
        {
            return number;
        }
        public NodeQueue GetNext()
        {
            return next;
        }

    }

}
