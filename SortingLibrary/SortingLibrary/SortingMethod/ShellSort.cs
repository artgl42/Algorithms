using System;

namespace SortingLibrary
{
    public class ShellSort : ISortingMethod
    {
        public ulong Sort<T>(T[] arrayForSort) where T : IComparable<T>
        {
            T _key;
            ulong _count = 0;
            int _indexBackValue, _indexFrontValue;
            int _delta = arrayForSort.Length >> 1;

            while (_delta > 0)
            {
                _indexFrontValue = _delta;
                while (_indexFrontValue < arrayForSort.Length)
                {
                    _key = arrayForSort[_indexFrontValue];
                    _indexBackValue = _indexFrontValue - _delta;
                    while (_indexBackValue >= 0 && arrayForSort[_indexBackValue].CompareTo(_key) > 0)
                    {
                        arrayForSort[_indexBackValue + _delta] = arrayForSort[_indexBackValue];
                        _indexBackValue -= _delta;
                        _count++;
                    }
                    arrayForSort[_indexBackValue + _delta] = _key;
                    _indexFrontValue++;
                }
                _delta >>= 1;
            }

            return _count;
        }
    }
}
