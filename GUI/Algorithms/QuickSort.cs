using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Algorithms
{
    public class QuickSort : BaseSortAlgorithm
    {
        public override int[] Sort(int[] data)
        {
            this.ReplaceCount = 0;
            this.IncrementationCount = 0;
            this.NestingCount = 0;
            SortQuick(data, 0, data.Length-1);
            return data;
        }

        private int[] SortQuick(int[] array, int leftIndex, int rightIndex)
        {
            this.NestingCount++;
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                    IncrementationCount++;
                }

                while (array[j] > pivot)
                {
                    j--;
                    IncrementationCount++;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                    ReplaceCount++;
                    IncrementationCount += 2;
                }
            }

            if (leftIndex < j)
                SortQuick(array, leftIndex, j);
            if (i < rightIndex)
                SortQuick(array, i, rightIndex);
            return array;
        }
    }
}
