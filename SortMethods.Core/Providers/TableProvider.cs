using System;

namespace SortMethods.Core.Providers
{
    public class TableProvider : ITableProvider
    {
        public int[] Create(int tableLength)
        {
            var tableToSort = new int[tableLength];
            var random = new Random();
            for (int i = 0; i < tableToSort.Length; i++)
            {
                tableToSort[i] = random.Next();
            }
            return tableToSort;
        }
    }
}