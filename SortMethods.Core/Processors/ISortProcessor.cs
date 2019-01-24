using System;

namespace SortMethods.Core.Processors
{
    public interface ISortProcessor
    {
        TimeSpan Elapsed { get; }
        double ElapsedMiliseconds { get; }
        void Sort(int[] tableToSort);
    }
}
