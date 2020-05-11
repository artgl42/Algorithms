using System;

namespace SortingLibrary
{
    public class QuickSort : ISortingMethod
    {
        public ulong Sort<T>(T[] arrayForSort) where T : IComparable<T>
        {
            if (arrayForSort.Length > 1)
            {
                int _left = 0;
                int _right = arrayForSort.Length - 1;
                return Sort(arrayForSort, _left, _right);
            }

            return 0;
        }
        private ulong Sort<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            ulong _count = 0;

            do
            {
                var _leftIndex = left;
                var _rightIndex = right;
                var _pivotIndex = _leftIndex + (_rightIndex - _leftIndex >> 1);
                var _pivot = array[_pivotIndex];
                T _temp;

                do
                {
                    while (array[_leftIndex].CompareTo(_pivot) < 0) _leftIndex++;
                    while (array[_rightIndex].CompareTo(_pivot) > 0) _rightIndex--;
                    if (_leftIndex > _rightIndex) break;
                    if (_leftIndex < _rightIndex)
                    {
                        _temp = array[_leftIndex];
                        array[_leftIndex] = array[_rightIndex];
                        array[_rightIndex] = _temp;
                        _count++;
                    }
                    _leftIndex++;
                    _rightIndex--;
                } while (_leftIndex <= _rightIndex);
                if (_rightIndex - left <= right - _leftIndex)
                {
                    if (left < _rightIndex) Sort(array, left, _rightIndex);
                    left = _leftIndex;
                } else
                {
                    if (_leftIndex < right) Sort(array, _leftIndex, right);
                    right = _rightIndex;
                }
            } while (left < right);

            return _count;
        }
    }
}
