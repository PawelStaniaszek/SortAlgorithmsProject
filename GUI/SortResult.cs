using SortAlgorithmsProject;
using System.Diagnostics;

namespace GUI
{
    public partial class SortResult : UserControl
    {
        private readonly Stopwatch stopwatch = new();
        public SortResult()
        {
            InitializeComponent();
        }
        public void ChangeName()
        {
            this.gbxSort.Text = this.Name;
        }
        public int[] Sort(int[] data, BaseSortAlgorithm sort)
        {
            var cloneData = new int[data.Length];
            for (int i = 0; i < cloneData.Length; i++)
            {
                cloneData[i] = data[i];
            }
            stopwatch.Start();
            sort.Sort(cloneData);
            stopwatch.Stop();

            tbxReplaceCount.Text = sort.ReplaceCount.ToString();
            tbxIncrementationCount.Text = sort.IncrementationCount.ToString();
            tbxNestingCount.Text = sort.NestingCount.ToString();

            TimeSpan tspan = stopwatch.Elapsed;
            string elapsedTime = String.Format(" {0:00}:{1:00}:{2:00}.{3:00} ",
            tspan.Hours, tspan.Minutes, tspan.Seconds, tspan.Milliseconds / 10);

            tbxTime.Text = elapsedTime;

            return cloneData;
        }
        public string GetResult()
        {
            var s = "Algorytm " + this.Name +" Czas wykonania: "+ tbxTime.Text+ " Ilosc zamian: " + tbxReplaceCount.Text + " Ilosc inkrementacji: " + tbxIncrementationCount.Text + " Ilosc powtorzen: " + tbxNestingCount.Text +" \n";
            return s;
        }
    }
}
