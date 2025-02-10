using System;

namespace DataStructureNonLinear
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
        


        /*Dictionaries d = new Dictionaries();
        d.Dictionay();
        */
        /*  HashTable h = new HashTable();
          h.Hash();
        */
    }
    }
}
