namespace SortAlgorithmsProject
{
    public class Array
    {
        public int[] array { get; set; }

        public void GenerateRandomArray(int length, int min, int max)
        {
            Random random = new Random();
            array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(min,max);
            }
        }
    }
}
