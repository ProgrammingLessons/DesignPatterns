using System;

namespace StrategyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // list is defined
            SortedList studentRecords = new SortedList();
            // Items are added to the list
            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            // Sorting algorithm is determined
            studentRecords.SetSortStrategy(new QuickSort());
            // Sorting is done
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

        }
    }
}
