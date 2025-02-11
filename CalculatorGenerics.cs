using System;
using System.Collections.Generic;

using System.Text;

namespace DataStructureNonLinear
{
    internal class CalculatorGenerics 
    {
        public T Add<T>(T n1, T n2) 
        {
            dynamic a = n1;
            dynamic b = n2;
            var result = a + b;
            return result;
        }
        public T Sub<T>(T n1, T n2)
        {
            dynamic a = n1;
            dynamic b = n2;
            var result = a - b;
            return Math.Abs(result);
        }
        public T Mul<T>(T n1, T n2)
        {
            dynamic a = n1;
            dynamic b = n2;
            var result = a * b;
            return result;
        }
        public T Divide<T>(T n1, T n2)
        {
            dynamic a = n1;
            dynamic b = n2;
            var result = a / b;
            return result;
        }
    }
}
