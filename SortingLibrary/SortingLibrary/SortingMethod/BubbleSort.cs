using System;

namespace SortingLibrary
{
    public class BubbleSort : ISortingMethod
    {
        public ulong Sort<T>(T[] arrayForSort) where T : IComparable<T>
        {
            T _temp;
            ulong _count = 0;
            bool _swap;

            for (int i = 0; i < arrayForSort.Length; i++)
            {
                _swap = false;
                for (int j = 0; j < arrayForSort.Length - i - 1; j++)
                {                    
                    if (arrayForSort[j].CompareTo(arrayForSort[j + 1]) > 0)
                    {
                        _temp = arrayForSort[j + 1];
                        arrayForSort[j + 1] = arrayForSort[j];
                        arrayForSort[j] = _temp;
                        _count++;
                        _swap = true;
                    }
                }

                if (!_swap) 
                    return _count;
            }
            return _count;
        }
    }
}
