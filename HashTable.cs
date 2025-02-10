using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructureNonLinear
{
    internal class HashTable
    {
        public void Hash()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add(3, "three");
            ht.Add(4, "four");
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }
            foreach(Object i in ht.Keys)
            {
                Console.WriteLine(i);
            }
            foreach (Object i in ht.Values)
            {
                Console.WriteLine(i);
            }
        }
    }
}
