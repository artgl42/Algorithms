using System;

namespace SortingLibrary
{
    public class OddEvenSort : ISortingMethod
    {
        public ulong Sort<T>(T[] arrayForSort) where T : IComparable<T>
        {
            T _temp;
            var _swap = true;

            while (_swap)
            {
                _swap = false;
                for (int i = 0; i < arrayForSort.Length - 1; i += 2)
                {
                    if (arrayForSort[i].CompareTo(arrayForSort[i + 1]) > 0)
                        Swap(i, i + 1);
                }
                for (int i = 1; i < arrayForSort.Length - 1; i += 2)
                {
                    if (arrayForSort[i].CompareTo(arrayForSort[i + 1]) > 0)
                        Swap(i, i + 1);
                }
            }

            return 0;

            void Swap(int i, int j)
            {
                _temp = arrayForSort[i];
                arrayForSort[i] = arrayForSort[j];
                arrayForSort[j] = _temp;
                _swap = true;
            }
        }
    }
}
