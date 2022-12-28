using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ReadFile : Form
    {
        private readonly MainWindow _mainWindow;
        private int[] data;
        public ReadFile(MainWindow mainWindow)
        {
            InitializeComponent();
            data = Array.Empty<int>();
            _mainWindow = mainWindow;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (!tbxChar.Text.Equals(""))
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        lblFile.Text = openFileDialog1.FileName;
                        lblFile.Visible = true;
                        var sr = new StreamReader(openFileDialog1.FileName);
                        var table = sr.ReadToEnd();
                        var strings = table.Split(tbxChar.Text);
                        lbxTable.DataSource = strings;
                        data = new int[strings.Length];
                        for (int i = 0; i < strings.Length; i++)
                        {
                            data[i] = int.Parse(strings[i]);
                        }
                        lbxTable.DataSource = data;

                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                        $"Details:\n\n{ex.StackTrace}");
                    }
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(data.Length != 0)
            {
                new ResultForm(data, _mainWindow).Show();
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _mainWindow.Show();
            this.Hide();
        }

        private void ReadFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainWindow.Exit();
        }
    }
}
