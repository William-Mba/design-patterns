using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy;

interface ISortStrategy
{
    List<int> Sort(List<int> dataset);
}

class BubbleSortStrategy : ISortStrategy
{
    public List<int> Sort(List<int> dataset)
    {
        Console.WriteLine("Sorting using Bubble Sort!");
        return dataset;
    }
}

class QuickSortStrategy : ISortStrategy
{
    public List<int> Sort(List<int> dataset)
    {
        Console.WriteLine("Sorting using Quick Sort!");
        return dataset;
    }
}

class Sorter
{
    private readonly ISortStrategy _sorter;

    public Sorter(ISortStrategy sorter)
    {
        _sorter = sorter;
    }

    public List<int> Sort(List<int> unSortedList)
    {
        return _sorter.Sort(unSortedList);
    }
}