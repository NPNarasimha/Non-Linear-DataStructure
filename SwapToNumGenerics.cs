using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureNonLinear
{
    internal class SwapToNumGenerics
    {
        public (T,T) Swap<T>(ref T num1,ref T num2)
        {
            T temp= num1;
            num1 =num2;
            num2 =temp;
            return (num1, num2);

        }
    }
}
