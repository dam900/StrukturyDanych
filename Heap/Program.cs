using System;
using System.Diagnostics;

namespace Heap
{
    class Program
    {
        static void Main()
        {

            Random rnd = new Random();

            Heap minHeap = new Heap(1000000, (int a, int b) => a <= b);

            for (int i = 0; i < 1000000; i++){
                minHeap.Push(rnd.Next());
            }



            long t1 = TimeUtils.GetNanoseconds();
            minHeap.Pop();
            long t2 = TimeUtils.GetNanoseconds();
            long dt = t2 - t1;
            Console.WriteLine( "Runtime of Pop: " + dt + " ns");

            t1 = TimeUtils.GetNanoseconds();
            minHeap.Push(rnd.Next());
            t2 = TimeUtils.GetNanoseconds();
            dt = t2 - t1;
            Console.WriteLine("Runtime of Push: " + dt + " ns");

            t1 = TimeUtils.GetNanoseconds();
            minHeap.Contains(rnd.Next());
            t2 = TimeUtils.GetNanoseconds();
            dt = t2 - t1;
            Console.WriteLine("Runtime of Contains: " + dt + " ns");

        }

    }
}
