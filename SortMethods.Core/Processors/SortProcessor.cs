using SortMethods.Core.Strategies;
using System;
using System.Diagnostics;

namespace SortMethods.Core.Processors
{
    public class SortProcessor : ISortProcessor
    {
        private readonly ISortStrategy _strategy;
        private readonly Stopwatch _timer;

        public SortProcessor(ISortStrategy strategy)
        {
            _strategy = strategy;
            _timer = new Stopwatch();
        }

        public TimeSpan Elapsed => _timer.Elapsed;

        public double ElapsedMiliseconds => _timer.ElapsedMilliseconds;

        public void Sort(int[] tableToSort)
        {
            _timer.Start();
            _strategy.Sort(tableToSort);
            _timer.Stop();
        }
    }
}
