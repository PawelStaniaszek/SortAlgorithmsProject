namespace GUI
{
    public partial class MainWindow : Form
    {
        private readonly InsertDataForm _form;
        private readonly GenerateRandomTable _generateRandomTable;
        private readonly ReadFile _readFile;
        public MainWindow()
        {
            InitializeComponent();
            _form = new(this);
            _generateRandomTable = new GenerateRandomTable(this);
            _readFile = new ReadFile(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rbInsertData.Checked)
            {
                _form.Show();
                this.Hide();

            }else if (rbRandomData.Checked)
            {
                _generateRandomTable.Show();
                this.Hide();

            }else if (rbFileData.Checked)
            {
                _readFile.Show();
                this.Hide();

            }else
            {
                this.Exit();
            } 
        }
        public void Exit()
        {
            this.Close();
        } 
    }
}