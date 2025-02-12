using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructureNonLinear
{
    internal class Sortedlist
    {
        public void SorList()
        {
            SortedList sl = new SortedList();
            sl.Add("1", "sai");
            sl.Add("2", 10);
            
            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }


            SortedList<string,string> s = new SortedList<string,string>();
            s.Add("1", "sai");
            s.Add("2", "np");
            s.Add("3", "kumar");
            s.Add("4", "sai");
            foreach(KeyValuePair<string,string> item in s)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}
