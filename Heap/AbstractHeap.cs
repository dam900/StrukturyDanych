using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    abstract class AbstractHeap
    {
        /// <summary>
        /// Actual number of elements in a heap 
        /// </summary>
        protected int _count = 0;

        /// <summary>
        /// Maximum number of elements that the heap can contain
        /// </summary>
        protected int _size;
            
        /// <summary>
        /// Array where all elements are stored
        /// </summary>
        protected int[] _array;

        /// <summary>
        /// Relation that is kept in a heap
        /// for integers either Max or Min
        /// </summary>
        protected Func<int, int, bool> _relation;

        protected AbstractHeap(int size, Func<int, int, bool> relation)
        {
            _size = size;
            _relation = relation;
        }

        /// <summary>
        /// Get the value of a root
        /// and remove it
        /// </summary>
        /// <returns>value of a root</returns>
        public abstract int Pop();

        /// <summary>
        /// Adds element to the heap
        /// </summary>
        public abstract void Push(int val);

        /// <summary>
        /// Fixes heap relation from the bottom to the root
        /// </summary>
        protected abstract void ShiftUp(int[] A, int pos);


        /// <summary>
        /// Fixes heap relation from the root to the bottom 
        /// </summary>
        protected abstract void ShiftDown(int[] A, int pos);

        /// <summary>
        /// Find out if value is present in the heap
        /// </summary>
        /// <param name="val"></param>
        /// <returns>true if value is present, false otherwise </returns>
        public abstract bool Contains(int val);
    }
}
