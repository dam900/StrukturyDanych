using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Heap : AbstractHeap
    {
        /// <summary>
        /// Position where the next elelemnt can be added
        /// </summary>
        protected int freePos = 1;

        public Heap(int size, Func<int, int, bool> relation) : base(size, relation)
        {
            base._array = new int[size + 1]; // +1 because the enumertion will be 2n and 2+1
        }

        protected override void HeapifyDown(int[] A, int pos)
        {
            throw new NotImplementedException();
        }

        protected override void HeapifyUp(int[] A, int pos)
        { 

            int p = Parent(pos);
            if (p == 0) return;
            if (base._relation(A[p], A[pos]) != true) 
            {
                int tmp = A[p];
                A[p] = A[pos];
                A[pos] = tmp;
            }
            HeapifyUp(A, p);
        }

        public override int Pop()
        {
            throw new NotImplementedException();
        }

        public override void Push(int val)
        {
            base._array[freePos] = val;
            HeapifyUp(base._array, this.freePos);
            this.freePos++;
        }

        private static int Parent(int i)
        {
            return i / 2;
        }

        private static int Left(int i)
        {
            return 2 * i;
        }
        private static int Right(int i)
        {
            return 2 * i + 1;
        }

        public void printHeap() {
            for (int i = 1; i <= base._array.Length - 1 ; i++) {
                Console.WriteLine(base._array[i]);
            }
        }
    }
}
