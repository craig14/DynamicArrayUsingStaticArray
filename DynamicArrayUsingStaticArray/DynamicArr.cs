using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayUsingStaticArray
{
    public class DynamicArr
    {
        
        int[] arr;
        int length;
        int capacity;

        public DynamicArr() { length = 0; capacity = 2; arr = new int[capacity];}

        public void Add(int item) {
            
            if(length+1 > capacity)
            {
                capacity = 2*length;
                int[] newArr = new int[capacity];
                for(int i = 0; i < length; i++)
                {
                    newArr[i] = arr[i];
                }
                arr = newArr;
            }
            arr[length++] = item;
        }

        public void Clear()
        {
            arr = new int[2];
            length = 0;
            capacity = 2;
        }

        public bool Contains(int item)
        {
            return arr.Contains(item);
        }

        public int IndexOf(int item)
        {
            for(int i = 0;i < length;i++)
            {
                if (arr[i] == item) return i;
            }
            return -1;
        }

        public void Insert(int item)
        {
            if(length+1 > capacity)
            {
                capacity = 2*length;
                int[] newArr = new int[capacity];
                for (int i = 0; i < length; i++)
                {
                    newArr[i] = arr[i];
                }
                arr = newArr;
            }
            arr[length++] = item;
        }

        public void Delete(int index)
        {
            if((index < 0) || (index > length - 1))
            {
                throw new IndexOutOfRangeException();
            }
            for(int i = 0, j = 0; i < length - 1; i++, j++)
            {
                if (i == index)
                {
                    j++;
                }
                arr[i] = arr[j];
            }
            length--;
            capacity--;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(length);
            sb.Append('[');
            if(length > 0)
            {
                for (int i = 0; i < length - 1; i++)
                {
                    sb.Append(arr[i] + ", ");
                }
                sb.Append(arr[length - 1]);
            }
            sb.Append(']');
            return sb.ToString();
        }
    }
}
