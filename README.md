# Algorithms

**[Sorting algorithms:](https://en.wikipedia.org/wiki/Sorting_algorithm)**

1. [BubbleSort](https://github.com/artgl42/Algorithms/blob/master/SortingLibrary/SortingLibrary/SortingMethod/BubbleSort.cs)
2. [ShakerSort](https://github.com/artgl42/Algorithms/blob/master/SortingLibrary/SortingLibrary/SortingMethod/ShakerSort.cs)
3. [SelectionSort](https://github.com/artgl42/Algorithms/blob/master/SortingLibrary/SortingLibrary/SortingMethod/SelectionSort.cs)
4. [GnomeSort](https://github.com/artgl42/Algorithms/blob/master/SortingLibrary/SortingLibrary/SortingMethod/GnomeSort.cs)
5. [OddEvenSort](https://github.com/artgl42/Algorithms/blob/master/SortingLibrary/SortingLibrary/SortingMethod/OddEvenSort.cs)
6. [InsertionSort](https://github.com/artgl42/Algorithms/blob/master/SortingLibrary/SortingLibrary/SortingMethod/InsertionSort.cs)
7. [QuickSort](https://github.com/artgl42/Algorithms/blob/master/SortingLibrary/SortingLibrary/SortingMethod/QuickSort.cs)
8. [MergeSort](https://github.com/artgl42/Algorithms/blob/master/SortingLibrary/SortingLibrary/SortingMethod/MergeSort.cs)
9. [CombSort](https://github.com/artgl42/Algorithms/blob/master/SortingLibrary/SortingLibrary/SortingMethod/CombSort.cs)
10. [HeapSort](https://github.com/artgl42/Algorithms/blob/master/SortingLibrary/SortingLibrary/SortingMethod/HeapSort.cs)
11. [ShellSort](https://github.com/artgl42/Algorithms/blob/master/SortingLibrary/SortingLibrary/SortingMethod/ShellSort.cs)

## How To Use

### **Step 1**

1. Add this library to any of your projects, using the **Solution Explorer -> Add -> Existing Project** by right-clicking on the **Solution Explorer**.

or

1. Build this library, using the **Solution Explorer -> Build Solution** by right-clicking on the **Solution Explorer**.

2. Copy the created **SortingLibrary.dll** file to the folder of your project, where the executable file (.exe) is located.

3. Add reference to **SortingLibrary.dll** file, using the **Reference -> Add Reference** by right-clicking on the **Reference** in **Solution Explorer**.

### **Step 2**

Use methods of the `Sorting` Class (the [facade pattern](https://en.wikipedia.org/wiki/Facade_pattern)):

Available methods | Parameters                                         | Description
:---------------- | :------------------------------------------------: | :--------------------------------
`Sort`            | `T[]` arrayForSort, `ISortingMethod` sortingMethod | Sorting an array using the selected method where `T:IComparable`
`GetRandomArray`  | `uint` length, `int` minValue, `int` maxValue      | Create and get an array
`GetErrorIndex`   | `T[]` arrayForCheck                                | Check the array and get the index of the wrong element where `T:IComparable`

Get the sorting time using the `Time` property of the `Sorting` Class.

## Simple example

```C#
var arrayForSort = Sorting.GetRandomArray<int>(100, 0, 100);
Sorting.Sort(arrayForSort, new BubbleSort(());
errorIndex = Sorting.GetErrorIndex(arrayForSort);
var usedTime = Sorting.Time;
```

## Licence

[MIT License](https://github.com/artgl42/Algorithms/blob/master/LICENSE) Copyright (c) 2020 Artem Glushkov
