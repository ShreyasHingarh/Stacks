using System;
using System.Collections.Generic;
using System.Text;

namespace StacksProgram
{
    class StackWithLinkedList<T>
    {
        public LinkedList<T> linkedList = new LinkedList<T>();
        public T Pop()
        {
            T value = linkedList.Last.Value;
            linkedList.RemoveLast();
            return value;
        }
        public void Push(T value)
        {
            linkedList.AddLast(value);
        }
        public T Peek()
        {
            return linkedList.Last.Value;
        }
            
           
    }
}
