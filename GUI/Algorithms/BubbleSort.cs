using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Algorithms
{
    public class BubbleSort : BaseSortAlgorithm
    {
        public override int[] Sort(int[] data)
        {
            this.ReplaceCount = 0;
            this.IncrementationCount = 0;
            this.NestingCount = 0;
            SortBubble(data);
            return data;
        }

        private int[] SortBubble(int[] array)
        {
            bool replace;
            do
            {
                replace = false;
                NestingCount++;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        replace = true;
                        ReplaceCount++;
                    }
                    IncrementationCount++;
                }

            } while (replace);
            return array;
        }
    }
}
