using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DataStructureNonLinear
{
    internal class SetGenerics
    {
        public void Sets()
        {
            HashSet<int> set = new HashSet<int>();

            set.Add(10);
            set.Add(20);
            set.Add(30);
            set.Add(40);
            set.Add(50);
            set.Add(10);
            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
            set.Remove(30);
            Console.WriteLine("After Remove : ");
            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
            
            bool present=set.Contains(40);
            Console.WriteLine("Contains 40 : " + present);

        }
    }
}
