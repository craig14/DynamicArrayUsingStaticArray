using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayUsingStaticArray
{
    public class SingleLinkedList<T>
    {
        private int size;
        private Node<T> head;
        private Node<T> tail;

        public SingleLinkedList()
        {
            size = 0;
            head = null;
            tail = null;
        }

        public class Node<T>
        {
            public T data;
            public Node<T> next;
            public Node(T data, Node<T> next)
            {
                this.data = data;
                this.next = next;
            }
        }

        public int Size() { return size; }

        public bool IsEmpty() { return size == 0; }

        public void AddNodeToHead(T data)//O(1)
        {
            if (IsEmpty())
            {
                head = tail = new Node<T>(data, null);
                size++;
                return;
            }
            Node<T> node = new Node<T>(data, head);
            node.next = head;
            head = node;

            size++;
        }

        public void AddNodeToTail(T data)//O(1)
        {
            if (IsEmpty())
            {
                head = tail = new Node<T>(data, null);
                size++;
                return;
            }
            Node<T> node = new Node<T>(data, null);
            tail.next = node;
            tail = node;
            size++;
        }

        public T RemoveNodeFromHead()//O(1)
        {
            T data;
            if (IsEmpty())
            {
                throw new InvalidOperationException("Linked List is empty!");
            }
            Node<T> deleteNode = head;
            head = head.next;
            data = deleteNode.data;
            deleteNode.next = null;
            size--;
            return data;
        }

        public T RemoveNodeFromTail()//O(n)
        {
            Node<T> temp = head;
            if (IsEmpty())
            {
                throw new InvalidOperationException("Linked List Empty");
            }
            for(int i=0; i < size - 1 ; i++)
            {
                temp = temp.next;
            }
            Node<T> deleteNode = tail;
            deleteNode.next = null;
            tail = temp;
            tail.next = null;
            size--;
            return deleteNode.data;
        }

        public int IndexOf(T data)//O(n)
        {
            Node<T> temp = head;
            int i = 0;
            while (temp.next != null) {
                if (temp.data == null ? data == null : temp.data.Equals(data))//handling scenario in case data is NULL
                {
                    return i;
                }
                temp = temp.next;
                i++;
            }
            return -1;
        }

        public bool Contains(T data)
        {
            return IndexOf(data) != -1;
        }

        public bool Remove(T data) 
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Linked List Empty");
            }

            Node<T> temp = head;
            Node<T> prev = head;
            while(temp != null)
            {
                if(temp.data == null ? data == null : temp.data.Equals(data))
                {
                    Node<T> deleteNode = temp;
                    prev.next = deleteNode.next;
                    deleteNode.next = null;
                    return true;
                }
                prev = temp;
                temp = temp.next;
            }
            return false;
        }

        public T GetHeadData()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Linked List Empty");
            }
            return head.data;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('[');
            for(Node<T> temp = head; temp.next != null; temp = temp.next)
            { 
                sb.Append(temp.data+", ");
            }
            if (!IsEmpty())
            {
                sb.Append(tail.data);
            }
            sb.Append(']');
            return sb.ToString();
        }
    }
}
