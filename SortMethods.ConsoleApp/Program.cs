using System;
using SortMethods.Core.Providers;
using SortMethods.Core.Processors;
using SortMethods.Core.Strategies;

namespace SortMethods.ConsoleApp
{
    class Program
    {
        static ITableProvider _tableCreator;
        const int _numberOfElemenets = 100000;
        static Program()
        {
            _tableCreator = new TableProvider();
        }
        static void Main(string[] args)
        {
            int[] tableToSort = _tableCreator.Create(_numberOfElemenets);

            ISortProcessor sortProcessor;
            sortProcessor = new SortProcessor(new ShellSortStrategy());
            sortProcessor.Sort(tableToSort);
            Console.WriteLine($"ShellSortStrategy took: {sortProcessor.ElapsedMiliseconds} ms.");

            tableToSort = _tableCreator.Create(_numberOfElemenets);
            sortProcessor = new SortProcessor(new PapiernowSortStrategy());
            sortProcessor.Sort(tableToSort);
            Console.WriteLine($"PapiernowSortStrategy took: {sortProcessor.ElapsedMiliseconds} ms.");

            tableToSort = _tableCreator.Create(_numberOfElemenets);
            sortProcessor = new SortProcessor(new SedgewickSortStrategy());
            sortProcessor.Sort(tableToSort);
            Console.WriteLine($"SedgewickSortStrategy took: {sortProcessor.ElapsedMiliseconds} ms.");

            Console.WriteLine("Hello World!");
        }
    }
}
