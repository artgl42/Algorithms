using System;
using System.Collections;
using System.Diagnostics;

namespace SortingLibrary
{
    public static class Sorting
    {
        public static string Time { get; set; }
        public static ulong Count { get; set; }

        public static T[] GetRandomArray<T>(uint length, int minValue, int maxValue) where T : struct
        {
            Random random = new Random(DateTime.Now.Millisecond);
            T[] randomArray = new T[length];

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = (T)Convert.ChangeType(random.Next(minValue, maxValue), typeof(T));
            }

            return randomArray;
        }

        public static IEnumerable GetErrorIndex<T>(T[] arrayForCheck) where T : IComparable<T>
        {
            for (int errorIndex = 0; errorIndex < arrayForCheck.Length - 1; errorIndex++)
            {
                if (arrayForCheck[errorIndex].CompareTo(arrayForCheck[errorIndex + 1]) > 0)
                {
                    yield return errorIndex;
                }
            }
        }

        public static void Sort<T>(T[] arrayForSort, ISortingMethod sortingMethod) where T : IComparable<T>
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Count = sortingMethod.Sort(arrayForSort);
            stopWatch.Stop();
            TimeSpan timeSpan = stopWatch.Elapsed;
            Time = string.Format("{0}:{1}:{2}:{3}", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds, timeSpan.Ticks);
        }
    }
}
