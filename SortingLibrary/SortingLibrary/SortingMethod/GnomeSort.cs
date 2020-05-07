using System;

namespace SortingLibrary
{
    public class GnomeSort : ISortingMethod
    {
        public ulong Sort<T>(T[] arrayForSort) where T : IComparable<T>
        {
            int i = 1;
            int j = 2;
            T _temp;
            ulong _count = 0;

            while (i < arrayForSort.Length)
            {
                if (i == 0 || arrayForSort[i - 1].CompareTo(arrayForSort[i]) <= 0)
                {
                    i = j++;
                    _count++;
                }
                else
                {
                    _temp = arrayForSort[i - 1];
                    arrayForSort[i - 1] = arrayForSort[i];
                    arrayForSort[i] = _temp;
                    i--;
                    if (i == 0) i = j++;
                    _count++;
                }
            }

            return _count;
        }
    }
}
