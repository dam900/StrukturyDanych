using System;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap maxHeap = new Heap(10, (int a, int b) => a >= b);
        /*    maxHeap.Push(10);
            maxHeap.Push(8);
            maxHeap.Push(1);
            maxHeap.Push(13);
            maxHeap.Push(21);
            maxHeap.Push(15);
            maxHeap.Push(16);
            maxHeap.Push(5);
            maxHeap.Push(3);
            maxHeap.printHeap();*/
        }
    }
}
