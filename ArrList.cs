using System;
using System.Collections;
using System.Text;

namespace DataStructureNonLinear
{
    internal class ArrList
    {
        public void ArrL()
        {
            ArrayList arr = new ArrayList();
            arr.Add(10);
            arr.Add(20);
            arr.Add(30);
            arr.Add(40);
            arr.Add(50);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            arr.Remove(10);
            arr.RemoveAt(1);
            arr.RemoveRange(0, 2);
            arr.Insert(0, 100);
            ArrayList arr1 = new ArrayList(arr);
            arr1.Add(200);
            arr1.Sort();
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }



        }
    }
}
