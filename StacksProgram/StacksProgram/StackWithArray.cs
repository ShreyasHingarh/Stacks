using System;
using System.Collections.Generic;
using System.Text;

namespace StacksProgram
{
    class StackWithArray<T>
    {
        public int Count { get; private set; }
        private T[] data;

        public StackWithArray(int capacity = 10)
        {
            data = new T[capacity];
        }
        public void Push(T value)
        {
            if(Count == data.Length)
            {
                Resize(data.Length * 2);
            }
            data[Count] = value;
            Count++;
        }
       // add pop
        public T Pop()
        {
            if(Count == 0)
            {
                throw new Exception("NO ITEMS IN THE STACK!!!!!!!!!!!!!!!!!!!");
            }

            T temp = data[Count - 1];
            Count--;
            return temp;
        }
        public T Peek() 
        {
            if (Count == 0)
            {
                throw new Exception("NO ITEMS IN THE STACK!!!!!!!!!!!!!!!!!!!");   
            }
            return data[Count - 1];
        }
        private void Resize(int size) 
        {
            T[] temp = new T[size];
            for(int i = 0;i < data.Length;i++)
            {
                temp[i] = data[i];
            }
            data = temp;
        }
    }
}