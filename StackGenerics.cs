using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureNonLinear
{
    internal class StackGenerics
    {
        public void Stacks()
        {   /*
             * Stack<int> stack = new Stack<int>(){
             * 10,20,30,40,40};
             */
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            stack.Push(60);
            stack.Push(70);
            stack.Push(80);
            stack.Push(90);
            stack.Push(100);
            
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Size of the Stack : " + stack.Count);
            Console.WriteLine("Peek : " + stack.Peek());
            Console.WriteLine("Pop : " + stack.Pop());
            Console.WriteLine("After Pop : ");
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
        }
    }
}
