using System;

namespace StacksProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            StackWithLinkedList<int> stack = new StackWithLinkedList<int>();
            for(int i = 0;i < 31;i++)
            {
                stack.Push(i);
                Console.WriteLine(stack.Peek());
            }
            Console.WriteLine();
            for(int i = 0;i < 15;i++)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine();
            Console.WriteLine(stack.Peek());
        }
    }
}
