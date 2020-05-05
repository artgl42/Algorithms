using System;

namespace SortingLibrary
{
    public class ShakerSort : ISortingMethod
    {
        public ulong Sort<T>(T[] arrayForSort) where T : IComparable<T>
        {
            T _temp;
            int _left = 0;
            int _right = arrayForSort.Length - 1;
            ulong _count = 0;

            while (_left < _right)
            {
                for (int i = _left; i < _right; i++)
                {
                    if (arrayForSort[i].CompareTo(arrayForSort[i + 1]) > 0)
                    {
                        _temp = arrayForSort[i];
                        arrayForSort[i] = arrayForSort[i + 1];
                        arrayForSort[i + 1] = _temp;
                        _count++;
                    }
                }
                _right--;

                for (int i = _right; i > _left; i--)
                {
                    if (arrayForSort[i - 1].CompareTo(arrayForSort[i]) > 0)
                    {
                        _temp = arrayForSort[i];
                        arrayForSort[i] = arrayForSort[i - 1];
                        arrayForSort[i - 1] = _temp;
                        _count++;
                    }
                }
                _left++;               
            }

            return _count;
        }
    }
}
