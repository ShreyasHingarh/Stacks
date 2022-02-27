using System;

namespace StacksProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            for(int i = 0;i < 31; i++)
            {
                stack.Push(i);
                
            }
            ;

        }
    }
}
