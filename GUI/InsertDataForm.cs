using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class InsertDataForm : Form
    {
        private readonly MainWindow _mainWindow;

        public List<int> data { get; set; }

        public InsertDataForm(MainWindow mainWindow)
        {
            InitializeComponent();
            data = new List<int>();
            lbData.DataSource = data;
            _mainWindow = mainWindow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.Add((int)nudInsertSingleNumber.Value);
            lbData.DataSource = null;
            lbData.DataSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] correctData = new int[data.Count()];
            int i = 0;
            foreach(int value in data)
            {
                correctData[i] = value;
                i++;
            }
            new ResultForm(correctData, _mainWindow).Show();
            this.Hide();
        }

        private void InsertDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainWindow.Exit();
        }
    }
}
