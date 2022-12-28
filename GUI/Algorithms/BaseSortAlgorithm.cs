namespace SortAlgorithmsProject
{
    public abstract class BaseSortAlgorithm
    {
        public long ReplaceCount { get; set; }
        public long NestingCount { get; set; }
        public long IncrementationCount { get; set; }
        public abstract int[] Sort(int[] data);
    }
}
