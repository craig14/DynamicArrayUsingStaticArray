using DynamicArrayUsingStaticArray.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayUsingStaticArray.Interfaces
{
    public interface ISingleLinkedList<T>
    {
        public void AddNodeToHead(T data);
        public void AddNodeToTail(T data);
        public T RemoveNodeFromHead();
        public T RemoveNodeFromTail();
        public T GetHeadData();
        public int Size();
        public bool IsEmpty();
    }
}
