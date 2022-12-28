namespace GUI
{
    partial class ReadFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxChar = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxTable = new System.Windows.Forms.ListBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj znak oddzielający zmienne:";
            // 
            // tbxChar
            // 
            this.tbxChar.Location = new System.Drawing.Point(260, 42);
            this.tbxChar.Name = "tbxChar";
            this.tbxChar.Size = new System.Drawing.Size(125, 27);
            this.tbxChar.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(260, 85);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(125, 29);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Wybierz plik";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbxTable);
            this.groupBox1.Controls.Add(this.lblFile);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAccept);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.tbxChar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wczytaj z pliku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Odczytana tablica:";
            // 
            // lbxTable
            // 
            this.lbxTable.FormattingEnabled = true;
            this.lbxTable.ItemHeight = 20;
            this.lbxTable.Location = new System.Drawing.Point(391, 42);
            this.lbxTable.Name = "lbxTable";
            this.lbxTable.Size = new System.Drawing.Size(150, 104);
            this.lbxTable.TabIndex = 6;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(23, 126);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(50, 20);
            this.lblFile.TabIndex = 5;
            this.lblFile.Text = "label2";
            this.lblFile.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Powrót";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(327, 177);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(94, 29);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Zatwierdź";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // ReadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 245);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReadFile";
            this.Text = "ReadFile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReadFile_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Label label1;
        private TextBox tbxChar;
        private Button btnOpenFile;
        private GroupBox groupBox1;
        private Label lblFile;
        private Button btnCancel;
        private Button btnAccept;
        private Label label2;
        private ListBox lbxTable;
    }
}