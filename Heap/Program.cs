using System;

namespace Heap
{
    class Program
    {
        static void Main()
        {
            /*Heap maxHeap = new Heap(10, (int a, int b) => a >= b);
            maxHeap.Push(10);
            maxHeap.Push(8);
            maxHeap.Push(1);
            maxHeap.Push(13);
            maxHeap.Push(21);
            maxHeap.Push(15);
            maxHeap.Push(16);
            maxHeap.Push(5);
            maxHeap.Push(3);
            maxHeap.printHeap();*/
            Heap minHeap = new Heap(10, (int a, int b) => a <= b);
            minHeap.Push(10);
            minHeap.Push(8);
            minHeap.Push(1);
            minHeap.Push(13);
            minHeap.Push(21);
            minHeap.Push(15);
            minHeap.Push(16);
            minHeap.Push(5);
            minHeap.Push(3);
            minHeap.Pop();
            minHeap.Pop();
            minHeap.Pop();
            minHeap.Pop();
            minHeap.Push(1);
            minHeap.Push(13);
            minHeap.Push(21);
            minHeap.Push(15);

            minHeap.PrintHeap();

        }
    }
}
