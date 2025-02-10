using System;

namespace DataStructureNonLinear
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Tree t = new Tree();
            t.Insert(10);
            t.Insert(20);
            t.Insert(30);
            t.Insert(40);
            t.Insert(50);

            t.Pre_order(t.returnRoot());
            Console.WriteLine();
            t.In_order(t.returnRoot());
            Console.WriteLine();
            t.Post_order(t.returnRoot());


        }
    }
}
