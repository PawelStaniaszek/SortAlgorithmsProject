using SortAlgorithmsProject;
using System.Text;

namespace GUI
{
    public partial class ResultForm : Form
    {
        private readonly MainWindow _mainWindow;
        public int[] data { get; set; }
        private bool _isCancel = false;
        public ResultForm(int[] data, MainWindow mainWindow)
        {
            InitializeComponent();
            this.data = data;
            lbInputData.DataSource = data;
            QuickSort.ChangeName();
            BubbleSort.ChangeName();
            ShellSort.ChangeName();
            _mainWindow = mainWindow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxQuickSort.Checked)
            {
                var result = this.QuickSort.Sort(data, new QuickSort());
                lbOutputData.DataSource = result;
            }
            if (cbxBubbleSort.Checked)
            {
                var result = this.BubbleSort.Sort(data, new BubbleSort());
                lbOutputData.DataSource = result;
            }
            if (cbxShell.Checked)
            {
                var result = this.ShellSort.Sort(data, new ShellSort());
                lbOutputData.DataSource = result;
            }
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.ShowDialog();
            if(this.saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
          (System.IO.FileStream)saveFileDialog1.OpenFile();

                byte[] info = new UTF8Encoding(true).GetBytes(QuickSort.GetResult());
                fs.Write(info, 0, info.Length);

                info = new UTF8Encoding(true).GetBytes(BubbleSort.GetResult());
                fs.Write(info, 0, info.Length);

                info = new UTF8Encoding(true).GetBytes(ShellSort.GetResult());
                fs.Write(info, 0, info.Length);

                fs.Close();
            }
        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isCancel)
            {
                return;
            } 
                _mainWindow.Exit(); 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _isCancel = true;
            _mainWindow.Show();
            this.Close();
        }
    }
}
