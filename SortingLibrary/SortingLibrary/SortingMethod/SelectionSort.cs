using System;

namespace SortingLibrary
{
    public class SelectionSort : ISortingMethod
    {
        public ulong Sort<T>(T[] arrayForSort) where T : IComparable<T>
        {
            T _temp;
            int _indexMinValue;
            ulong _count = 0;

            for (int i = 0; i < arrayForSort.Length - 1; i++)
            {
                _indexMinValue = i;
                for (int j = i + 1; j < arrayForSort.Length; j++)
                {
                    if (arrayForSort[_indexMinValue].CompareTo(arrayForSort[j]) > 0)
                    {
                        _indexMinValue = j;
                        _count++;
                    }
                }
                _temp = arrayForSort[i];
                arrayForSort[i] = arrayForSort[_indexMinValue];
                arrayForSort[_indexMinValue] = _temp;
            }

            return _count;
        }
    }
}
