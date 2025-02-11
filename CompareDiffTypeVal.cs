using System;
using System.Collections.Generic;
using System.Text;
using Aardvark.Base;

namespace DataStructureNonLinear
{
    internal class CompareDiffTypeVal
    {
        public void CompareVal<T1,T2>(T1 val1,T2 val2) 
        {
            if (val1.Equals(val2))
            {
                Console.WriteLine("Both are equal");
            }
            else
            {
                Console.WriteLine("Both are not equal");
            }
        }
    }
}
