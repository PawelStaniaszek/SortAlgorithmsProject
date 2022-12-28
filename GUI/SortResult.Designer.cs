namespace GUI
{
    partial class SortResult
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxSort = new System.Windows.Forms.GroupBox();
            this.tbxTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxIncrementationCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxReplaceCount = new System.Windows.Forms.TextBox();
            this.tbxNestingCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSort
            // 
            this.gbxSort.Controls.Add(this.tbxTime);
            this.gbxSort.Controls.Add(this.label12);
            this.gbxSort.Controls.Add(this.tbxIncrementationCount);
            this.gbxSort.Controls.Add(this.label5);
            this.gbxSort.Controls.Add(this.tbxReplaceCount);
            this.gbxSort.Controls.Add(this.tbxNestingCount);
            this.gbxSort.Controls.Add(this.label1);
            this.gbxSort.Controls.Add(this.label2);
            this.gbxSort.Location = new System.Drawing.Point(0, 0);
            this.gbxSort.Name = "gbxSort";
            this.gbxSort.Size = new System.Drawing.Size(284, 174);
            this.gbxSort.TabIndex = 5;
            this.gbxSort.TabStop = false;
            // 
            // tbxTime
            // 
            this.tbxTime.Enabled = false;
            this.tbxTime.Location = new System.Drawing.Point(147, 125);
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.Size = new System.Drawing.Size(125, 27);
            this.tbxTime.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Czas wykonania:";
            // 
            // tbxIncrementationCount
            // 
            this.tbxIncrementationCount.Enabled = false;
            this.tbxIncrementationCount.Location = new System.Drawing.Point(147, 92);
            this.tbxIncrementationCount.Name = "tbxIncrementationCount";
            this.tbxIncrementationCount.Size = new System.Drawing.Size(125, 27);
            this.tbxIncrementationCount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ilość inkrementacji:";
            // 
            // tbxReplaceCount
            // 
            this.tbxReplaceCount.Enabled = false;
            this.tbxReplaceCount.Location = new System.Drawing.Point(147, 26);
            this.tbxReplaceCount.Name = "tbxReplaceCount";
            this.tbxReplaceCount.Size = new System.Drawing.Size(125, 27);
            this.tbxReplaceCount.TabIndex = 1;
            // 
            // tbxNestingCount
            // 
            this.tbxNestingCount.Enabled = false;
            this.tbxNestingCount.Location = new System.Drawing.Point(147, 59);
            this.tbxNestingCount.Name = "tbxNestingCount";
            this.tbxNestingCount.Size = new System.Drawing.Size(125, 27);
            this.tbxNestingCount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ilość zamian:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ilość zagnieżdżeń:";
            // 
            // SortResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxSort);
            this.Name = "SortResult";
            this.Size = new System.Drawing.Size(287, 177);
            this.gbxSort.ResumeLayout(false);
            this.gbxSort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbxSort;
        private TextBox tbxTime;
        private Label label12;
        private TextBox tbxIncrementationCount;
        private Label label5;
        private TextBox tbxReplaceCount;
        private TextBox tbxNestingCount;
        private Label label1;
        private Label label2;
    }
}
