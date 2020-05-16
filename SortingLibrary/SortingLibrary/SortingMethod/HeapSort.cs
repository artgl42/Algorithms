using System;

namespace SortingLibrary
{
    public class HeapSort : ISortingMethod
    {
        public ulong Sort<T>(T[] arrayForSort) where T : IComparable<T>
        {
            var _heapSize = arrayForSort.Length;

            for (int root = _heapSize / 2 - 1; root >= 0; root--)
                Heapify(arrayForSort, _heapSize, root);

            for (int root = _heapSize - 1; root >= 0; root--)
            {
                T _temp = arrayForSort[0];
                arrayForSort[0] = arrayForSort[root];
                arrayForSort[root] = _temp;

                Heapify(arrayForSort, root, 0);
            }

            return 0;
        }

        private void Heapify<T>(T[] array, int heapSize, int root) where T : IComparable<T>
        {
            var _leftLeaf = 2 * root + 1;
            var _rightLeaf = 2 * root + 2;
            var _rootNew = root;

            if (_leftLeaf < heapSize && array[_leftLeaf].CompareTo(array[_rootNew]) > 0)
                _rootNew = _leftLeaf;

            if (_rightLeaf < heapSize && array[_rightLeaf].CompareTo(array[_rootNew]) > 0)
                _rootNew = _rightLeaf;

            if (_rootNew != root)
            {
                T _temp = array[root];
                array[root] = array[_rootNew];
                array[_rootNew] = _temp;

                Heapify(array, heapSize, _rootNew);
            }
        }
    }
}
