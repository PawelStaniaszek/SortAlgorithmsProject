namespace GUI
{
    partial class InsertDataForm
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
            this.lbData = new System.Windows.Forms.ListBox();
            this.nudInsertSingleNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudInsertSingleNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.ItemHeight = 20;
            this.lbData.Location = new System.Drawing.Point(15, 79);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(283, 184);
            this.lbData.TabIndex = 1;
            // 
            // nudInsertSingleNumber
            // 
            this.nudInsertSingleNumber.Location = new System.Drawing.Point(148, 11);
            this.nudInsertSingleNumber.Name = "nudInsertSingleNumber";
            this.nudInsertSingleNumber.Size = new System.Drawing.Size(150, 27);
            this.nudInsertSingleNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wprowadź liczbę:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Zakończ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InsertDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudInsertSingleNumber);
            this.Controls.Add(this.lbData);
            this.Name = "InsertDataForm";
            this.Text = "InsertDataForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InsertDataForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudInsertSingleNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbData;
        private NumericUpDown nudInsertSingleNumber;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}