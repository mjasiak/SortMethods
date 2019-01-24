namespace SortMethods.Core.Strategies
{
    public class ShellSortStrategy : ISortStrategy
    {
        public void Sort(int[] tab)
        {
            int space = tab.Length / 2;
            while (space >= 1)
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
                space /= 2;
            }
        }
    }
}
