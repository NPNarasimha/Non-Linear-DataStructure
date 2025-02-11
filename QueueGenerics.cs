using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureNonLinear
{
    internal class QueueGenerics
    {
        public void Queues() { 
        Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("Size of the queue : "+queue.Count);
            Console.WriteLine("Dequeue : " + queue.Dequeue());
            Console.WriteLine("After Dequeue : ");
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("Peek : " + queue.Peek());
            Console.WriteLine(
                "After Peek : ");
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }

        }
    }
}
