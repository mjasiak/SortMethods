using System;

namespace SortMethods.Core.Strategies
{
    public class SedgewickSortStrategy : ISortStrategy
    {
        public void Sort(int[] tab)
        {
            int power = 8;
            int space = GetSpace(power);
            while (space >= 1 && power >= 0)
            {
                for (int i = space; i < tab.Length; i += 1)
                {
                    int temp = tab[i];
                    int j;
                    for (j = i; j >= space && tab[j - space] > temp; j -= space)
                    {
                        tab[j] = tab[j - space];
                    }
                    tab[j] = temp;
                }
                power -= 1;
                space = power != 0 ? GetSpace(power) : 1;
            }
        }

        private int GetSpace(int power)
        {
            return (int)Math.Pow(4, power) + 3 * (int)Math.Pow(2, power - 1) + 1;
        }
    }
}