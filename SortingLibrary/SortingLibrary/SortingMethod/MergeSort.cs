using System;
using System.Linq;

namespace SortingLibrary
{
    public class MergeSort : ISortingMethod
    {
        public ulong Sort<T>(T[] arrayForSort) where T : IComparable<T>
        {
            MergeSorting(arrayForSort).CopyTo(arrayForSort, 0);
            return 0;
        }

        private T[] MergeSorting<T>(T[] arrayForSort) where T : IComparable<T>
        {
            if (arrayForSort.Length == 1) return arrayForSort;
            var _middle = arrayForSort.Length >> 1;
            var _leftArray = MergeSorting(arrayForSort.Take(_middle).ToArray());
            var _rightArray = MergeSorting(arrayForSort.Skip(_middle).ToArray());

            return Merge(_leftArray, _rightArray);
        }

        private T[] Merge<T>(T[] leftArray, T[] rightArray) where T : IComparable<T>
        {
            var _indexLeftArray = 0;
            var _indexRightArray = 0;
            T[] _mergedArray = new T[leftArray.Length + rightArray.Length];

            for (int i = 0; i < _mergedArray.Length; i++)
            {
                if (_indexLeftArray < leftArray.Length && _indexRightArray < rightArray.Length)
                {
                    _mergedArray[i] = leftArray[_indexLeftArray].CompareTo(rightArray[_indexRightArray]) > 0 ? rightArray[_indexRightArray++] : leftArray[_indexLeftArray++];
                }
                else
                {
                    _mergedArray[i] = _indexRightArray < rightArray.Length ? rightArray[_indexRightArray++] : leftArray[_indexLeftArray++];
                }
            }

            return _mergedArray;
        }
    }
}
