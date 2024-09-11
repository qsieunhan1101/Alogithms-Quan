using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogithms_Quan.Bt24_25
{
    public class MyStack<T>
    {
        private Node<T> head;
        private Node<T> tail;
        /// <summary>
        /// Chen mot phan tu o dau Stack
        /// </summary>
        /// <param name="data">doi tuong can them vao Stack</param>
        public void Push(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                tail = head;
            }
            else
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = head;
                head = newNode;
            }
        }
        /// <summary>
        /// Xoa va tra ve phan tu o dau Stack
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            T data = head.Data;
            head = head.Next;
            return data;
        }
        /// <summary>
        /// Tra ve phan tu o dau Stack
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            return head.Data;
        }

    }
}
