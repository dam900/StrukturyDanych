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
        /// Position where the next element can be added
        /// </summary>
        protected int freePos = 1;

        public Heap(int size, Func<int, int, bool> relation) : base(size, relation)
        {
            base._array = new int[size + 1]; // +1 because the enumertion will be 2n and 2n+1
        }

        protected override void ShiftDown(int[] A, int pos)
        {
            if (Right(pos) > this._count || Left(pos) > this._count) return;
            int l = Left(pos);
            int r = Right(pos);
            if (base._relation(A[pos], A[l]) != true || base._relation(A[pos], A[r]) != true) {
                if (base._relation(A[l], A[r]))
                {
                    Swap(A, l, pos);
                    ShiftDown(A, l);
                }
                else {
                    Swap(A, r, pos);
                    ShiftDown(A, r);
                }
            }
        }

        protected override void ShiftUp(int[] A, int pos)
        { 
            int p = Parent(pos);
            if (p == 0) return;
            if (base._relation(A[p], A[pos]) != true) 
            {
                Swap(A, p, pos);
            }
            ShiftUp(A, p);
        }

        public override int Pop()
        {
            int root = base._array[1];
            base._array[1] = base._array[base._count];
            this.freePos--;
            base._count--;
            ShiftDown(base._array, 1);

            return root;
        }


        public override void Push(int val)
        {
            base._array[freePos] = val;
            ShiftUp(base._array, this.freePos);
            this.freePos++;
            base._count++;
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

        private static void Swap(int[] A, int p1, int p2)
        {
            int tmp = A[p1];
            A[p1] = A[p2];
            A[p2] = tmp;
        }

        public void PrintHeap() {
            for (int i = 1; i <= base._count; i++) {    
                Console.WriteLine(base._array[i]);
            }
        }

        public override bool Contains(int val)
        {
            return base._array.Contains(val);
        }

        public override int Peek()
        {
            return base._array[1];
        }
    }
}
