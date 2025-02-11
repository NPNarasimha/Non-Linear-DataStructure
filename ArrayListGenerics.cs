using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Aardvark.Base;

namespace DataStructureNonLinear
{
    internal class ArrayListGenerics
    {
        public void ArrList()
        {
            List<int> list = new List<int>();
                /*
                List<int> list1 = new List<int>(){
                10,20,30,40,50,60};
                */
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(40);
            list.Add(50);
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
            list.Remove(30);
             list.RemoveRange(3,1);
            Console.WriteLine("After Remove : ");
           
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            list.Insert(2, 35);
            
            Console.WriteLine("After Inserting");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            list[1] = 50;
            Console.WriteLine("After seting the value");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("Size of the List : "+list.Count);
            list.Sort();
            Console.WriteLine("After Sorting : ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            List <int> list2 = new List<int>();
            list2.Add(60);
            list2.AddRange(list);
            Console.WriteLine("List 2 Print");
            foreach (var item in list2)
            {
                Console.Write(item + " ");
            }
            list2.Clear();
            Console.WriteLine("After Clearing the List 2");
            list2.Add(20);
            foreach (var item in list2)
            {
                Console.Write(item + " ");
            }

        }
    }
}
