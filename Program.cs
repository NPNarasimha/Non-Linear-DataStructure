using System;

namespace DataStructureNonLinear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        Tree tree = new Tree();
                        tree.Insert(50);
                        tree.Insert(30);
                        tree.Insert(70);
                        tree.Insert(20);
                        tree.Insert(40);
                        tree.Insert(60);
                        tree.Insert(80);

                        Console.WriteLine("Pre-order Traversal:");
                        tree.PreOrder(tree.ReturnRoot());
                        Console.WriteLine();

                        Console.WriteLine("In-order Traversal:");
                        tree.InOrder(tree.ReturnRoot());
                        Console.WriteLine();

                        Console.WriteLine("Post-order Traversal:");
                        tree.PostOrder(tree.ReturnRoot());
                        Console.WriteLine();

                        */

            /*Dictionaries d = new Dictionaries();
            d.Dictionay();
            */

            /*HashTable h = new HashTable();
          h.Hash();
            */

            /*   SwapToNumGenerics swap = new SwapToNumGenerics();
               int a = 10;
               int b = 20;
               //storing the generic values 
              Console.WriteLine( (a,b) =swap.Swap(ref a,ref b));
            */
            /*  
              CompareDiffTypeVal compare = new CompareDiffTypeVal();
              compare.CompareVal("sai",10);
              */
            /*  FindMinMax find = new FindMinMax();
              find.FindVal("hi", "hi", "k");
            */

            /*  CalculatorGenerics calc = new CalculatorGenerics();
              Console.WriteLine(calc.Add<int>(1, 4));
              Console.WriteLine(calc.Add<double>(4.0, 2.2));
              Console.WriteLine(calc.Add<string>("sai", "kumar"));
              Console.WriteLine(calc.Sub<int>(10, 20));
              Console.WriteLine(calc.Sub<double>(10.0, 20.0));
              Console.WriteLine(calc.Mul<int>(10, 20));
              Console.WriteLine(calc.Mul<double>(10.0, 20.0));
              Console.WriteLine(calc.Divide<int>(10, 20));
              Console.WriteLine(calc.Divide<double>(10.0, 20.0));
            */

            /*  ArrayListGenerics arr = new ArrayListGenerics();
              arr.ArrList();
            */
            /* SetGenerics set = new SetGenerics();
             set.Sets();
         */

            /*StackGenerics stack = new StackGenerics();
            stack.Stacks();
*/
            QueueGenerics queue = new QueueGenerics();
            queue.Queues();
        }
    }

   
}
