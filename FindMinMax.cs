using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureNonLinear
{
    internal class FindMinMax
    {
        public void FindVal<T1, T2, T3>(T1 val1, T2 val2, T3 val3)
        {
            if (val1.Equals(val2) && val2.Equals(val3))
            {
                Console.WriteLine("All are equal");
            }
            else if (val1.Equals(val2) && val1.Equals(val3))
            {
                Console.WriteLine("All are equal");
            }
            else if (val1.Equals(val2) && !val1.Equals(val3))
            {
                Console.WriteLine("val1 and val2 are equal");
            }
            else if (val1.Equals(val3) && !val1.Equals(val2))
            {
                Console.WriteLine("val1 and val3 are equal");
            }
            else if (val2.Equals(val3) && !val1.Equals(val2))
            {
                Console.WriteLine("val2 and val3 are equal");
            }
            else
            {
                Console.WriteLine("All are different");
            }
        }
    }
}
