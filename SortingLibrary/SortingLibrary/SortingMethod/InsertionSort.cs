using System;

namespace SortingLibrary
{
    public class InsertionSort : ISortingMethod
    {
        public ulong Sort<T>(T[] arrayForSort) where T : IComparable<T>
        {
            T _key;
            int _prev;
            ulong _count = 0;

            for (int _next = 1; _next < arrayForSort.Length; _next++)
            {
                _key = arrayForSort[_next];
                _prev = _next - 1;
                while (_prev >= 0 && arrayForSort[_prev].CompareTo(_key) > 0)
                {
                    arrayForSort[_prev + 1] = arrayForSort[_prev];
                    _prev--;
                    _count++;
                }
                arrayForSort[_prev + 1] = _key;
            }

            return _count;
        }
    }
}
