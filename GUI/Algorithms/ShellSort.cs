namespace GUI.Algorithms
{
    public class ShellSort : BaseSortAlgorithm
    {
        public override int[] Sort(int[] data)
        {
            this.ReplaceCount = 0;
            this.IncrementationCount = 0;
            this.NestingCount = 0;
            SortShell(data);
            return data;
        }

        private int[] SortShell(int[] array)
        {
            bool replace;
            int h = array.Length / 2;
            do
            {
                NestingCount++;
                replace = false;
                for (int i = 0; i + h < array.Length; i++)
                {
                    if (array[i] > array[i + h])
                    {
                        var temp = array[i];
                        array[i] = array[i + h];
                        array[i + h] = temp;
                        replace = true;
                        ReplaceCount++;
                    }
                    IncrementationCount++;
                }
                if (!replace && h != 1)
                {
                    h /= 2;
                    replace = true;
                }
            } while (replace);
            return array;
        }
    }
}
