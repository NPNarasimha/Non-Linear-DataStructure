using System;
using System.Collections.Generic;
using System.Text;


namespace DataStructureNonLinear
{
    internal class Dictionaries
    {

        public void Dictionay()
        {
            Dictionary<string, Int32> dict = new Dictionary<string, Int32>();

            dict.Add("one", 1);
            dict.Add("two", 2);
            dict.Add("three", 3);
            dict.Add("four", 4);
            dict.Add("five", 5);
            
            dict.Remove("three");

            if (dict.ContainsKey("two"))
            {
                Console.WriteLine("Key found");
            }
            else
            {
                Console.WriteLine("Key not found");

            }
            if (dict.ContainsValue(2))
            {
                Console.WriteLine("Value found");
            }
            else
            {
                Console.WriteLine("Value not found");
            }

            dict["one"] = 10;
            foreach (KeyValuePair<string, Int32> word in dict)
            {
                Console.WriteLine( word.Key+" "+ word.Value);
            }
        }

    }
}
