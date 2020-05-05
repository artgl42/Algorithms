using System;

namespace SortingLibrary
{
    public interface ISortingMethod
    {
        ulong Sort<T>(T[] arrayForSort) where T : IComparable<T>;
    }
}
