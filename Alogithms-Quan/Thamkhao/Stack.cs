using System;

namespace Alogithms_Quan.Bt24_25
{

    public class Stack
    {
        public LinkedListStack list;
        public Stack()
        {
            list = new LinkedListStack();
        }
        public void Push(int value)
        {
            list.AddHead(value);
        }
        public int Pop()
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
    public class LinkedListStack
    {
        public NodeStack head;
        public NodeStack tail;
        public LinkedListStack()
        {
            head = null;
            tail = null;
        }
        public void AddHead(int value)
        {
            if (head == null)
            {
                head = new NodeStack(value);
                tail = head;
            }
            else
                head = head.AddHead(value);
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
    public class NodeStack
    {
        public int number;
        public NodeStack next;
        public NodeStack(int value)
        {
            number = value;
            next = null;
        }
        public NodeStack AddHead(int value)
        {
            NodeStack newNode = new NodeStack(value);
            newNode.next = this;
            return newNode;
        }
        public int GetValue()
        {
            return number;
        }
        public NodeStack GetNext()
        {
            return next;
        }
    }

}
