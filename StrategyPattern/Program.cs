using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Kero");
            studentRecords.Add("Shehata");
            studentRecords.Add("Ahmed");
            studentRecords.Add("Ali");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            Console.ReadKey();
        }
    }
}
