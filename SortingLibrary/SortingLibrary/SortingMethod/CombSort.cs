using System;

namespace SortingLibrary
{
    public class CombSort : ISortingMethod
    {
        public ulong Sort<T>(T[] arrayForSort) where T : IComparable<T>
        {
            const double _factor = 1.247;
			int _step = arrayForSort.Length;
            bool _swap;
            T _temp;

            do
            {
                _swap = false;
                _step = _step > 1 ? (int)(_step / _factor) : _step;

                for (int i = 0; i + _step < arrayForSort.Length; i++)
                {
                    if (arrayForSort[i].CompareTo(arrayForSort[i + _step]) > 0)
                    {
                        _temp = arrayForSort[i];
                        arrayForSort[i] = arrayForSort[i + _step];
                        arrayForSort[i + _step] = _temp;
                        _swap = true;
                    }
                }
            } while (_step > 1 || _swap);

            return 0;
		}
    }
}
