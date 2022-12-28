namespace GUI
{
    partial class ResultForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxShell = new System.Windows.Forms.CheckBox();
            this.cbxBubbleSort = new System.Windows.Forms.CheckBox();
            this.cbxQuickSort = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.ShellSort = new GUI.SortResult();
            this.BubbleSort = new GUI.SortResult();
            this.QuickSort = new GUI.SortResult();
            this.lbInputData = new System.Windows.Forms.ListBox();
            this.lbOutputData = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbxShell);
            this.groupBox1.Controls.Add(this.cbxBubbleSort);
            this.groupBox1.Controls.Add(this.cbxQuickSort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz algorytmy sortujące";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxShell
            // 
            this.cbxShell.AutoSize = true;
            this.cbxShell.Location = new System.Drawing.Point(28, 105);
            this.cbxShell.Name = "cbxShell";
            this.cbxShell.Size = new System.Drawing.Size(90, 24);
            this.cbxShell.TabIndex = 3;
            this.cbxShell.Text = "ShellSort";
            this.cbxShell.UseVisualStyleBackColor = true;
            // 
            // cbxBubbleSort
            // 
            this.cbxBubbleSort.AutoSize = true;
            this.cbxBubbleSort.Location = new System.Drawing.Point(28, 75);
            this.cbxBubbleSort.Name = "cbxBubbleSort";
            this.cbxBubbleSort.Size = new System.Drawing.Size(105, 24);
            this.cbxBubbleSort.TabIndex = 2;
            this.cbxBubbleSort.Text = "BubbleSort";
            this.cbxBubbleSort.UseVisualStyleBackColor = true;
            // 
            // cbxQuickSort
            // 
            this.cbxQuickSort.AutoSize = true;
            this.cbxQuickSort.Location = new System.Drawing.Point(28, 45);
            this.cbxQuickSort.Name = "cbxQuickSort";
            this.cbxQuickSort.Size = new System.Drawing.Size(95, 24);
            this.cbxQuickSort.TabIndex = 1;
            this.cbxQuickSort.Text = "QuickSort";
            this.cbxQuickSort.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnSaveResult);
            this.groupBox2.Controls.Add(this.ShellSort);
            this.groupBox2.Controls.Add(this.BubbleSort);
            this.groupBox2.Controls.Add(this.QuickSort);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(927, 263);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wyniki:";
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Location = new System.Drawing.Point(776, 216);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(123, 29);
            this.btnSaveResult.TabIndex = 8;
            this.btnSaveResult.Text = "Zapisz wyniki";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // ShellSort
            // 
            this.ShellSort.Location = new System.Drawing.Point(609, 26);
            this.ShellSort.Name = "ShellSort";
            this.ShellSort.Size = new System.Drawing.Size(290, 184);
            this.ShellSort.TabIndex = 7;
            // 
            // BubbleSort
            // 
            this.BubbleSort.Location = new System.Drawing.Point(313, 26);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(290, 184);
            this.BubbleSort.TabIndex = 7;
            // 
            // QuickSort
            // 
            this.QuickSort.Location = new System.Drawing.Point(12, 26);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(290, 184);
            this.QuickSort.TabIndex = 0;
            // 
            // lbInputData
            // 
            this.lbInputData.FormattingEnabled = true;
            this.lbInputData.ItemHeight = 20;
            this.lbInputData.Location = new System.Drawing.Point(325, 42);
            this.lbInputData.Name = "lbInputData";
            this.lbInputData.Size = new System.Drawing.Size(170, 184);
            this.lbInputData.TabIndex = 3;
            // 
            // lbOutputData
            // 
            this.lbOutputData.FormattingEnabled = true;
            this.lbOutputData.ItemHeight = 20;
            this.lbOutputData.Location = new System.Drawing.Point(501, 42);
            this.lbOutputData.Name = "lbOutputData";
            this.lbOutputData.Size = new System.Drawing.Size(170, 184);
            this.lbOutputData.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Dane Wejściowe:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Dane Wyjściowe:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 216);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 507);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbOutputData);
            this.Controls.Add(this.lbInputData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ResultForm";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private CheckBox cbxShell;
        private CheckBox cbxBubbleSort;
        private CheckBox cbxQuickSort;
        private GroupBox groupBox2;
        private ListBox lbInputData;
        private ListBox lbOutputData;
        private Label label10;
        private Label label11;
        private SortResult ShellSort;
        private SortResult BubbleSort;
        private SortResult QuickSort;
        private Button btnSaveResult;
        private SaveFileDialog saveFileDialog1;
        private Button btnBack;
    }
}