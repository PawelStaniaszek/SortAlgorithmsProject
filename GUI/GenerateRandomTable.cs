using Array = SortAlgorithmsProject.Array;

namespace GUI
{
    public partial class GenerateRandomTable : Form
    {
        private readonly MainWindow _mainWindow;

        public GenerateRandomTable(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Array array = new Array();
            array.GenerateRandomArray((int)nudLengthOfArray.Value, (int)nudMinValue.Value, (int)nudMaxValue.Value);
            new ResultForm(array.array, _mainWindow).Show();
            this.Hide();
        }

        private void GenerateRandomTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainWindow.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainWindow.Show();
            this.Hide();
        }
    }
}
