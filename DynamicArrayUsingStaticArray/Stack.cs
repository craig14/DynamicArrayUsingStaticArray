using DynamicArrayUsingStaticArray.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayUsingStaticArray
{
    /// <summary>
    ///    Stack Implementation using LinkedList
    /// </summary>
    public class MyStack<T>
    {
        private ISingleLinkedList<T> list;

        public MyStack(SingleLinkedList<T> list) 
        {
            this.list = list;
        }

        public int Size() { return list.Size(); }

        public bool IsEmpty() { return list.IsEmpty(); }

        public void Push(T item)
        {
            list.AddNodeToHead(item);
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("No elements in stack!");
            }
            T data = list.RemoveNodeFromHead();
            return data;
        }

        public T Peek() 
        {
            return list.GetHeadData();
        }

        public override string ToString()
        {
            return list.ToString();
        }
    }
}
