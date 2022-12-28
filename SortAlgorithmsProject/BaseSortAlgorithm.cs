using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithmsProject
{
    public abstract class BaseSortAlgorithm
    {
        public int ReplaceCount { get; set; }
        public int NestingCount { get; set; }
        public int IncrementationCount { get; set; }
        public abstract int[] Sort(int[] data);
    }
}
