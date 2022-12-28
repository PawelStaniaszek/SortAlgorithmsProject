namespace GUI
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.rbInsertData = new System.Windows.Forms.RadioButton();
            this.rbRandomData = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFileData = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Zatwierdź";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rbInsertData
            // 
            this.rbInsertData.AutoSize = true;
            this.rbInsertData.Location = new System.Drawing.Point(6, 34);
            this.rbInsertData.Name = "rbInsertData";
            this.rbInsertData.Size = new System.Drawing.Size(139, 24);
            this.rbInsertData.TabIndex = 3;
            this.rbInsertData.TabStop = true;
            this.rbInsertData.Text = "Wprowadź dane";
            this.rbInsertData.UseVisualStyleBackColor = true;
            // 
            // rbRandomData
            // 
            this.rbRandomData.AutoSize = true;
            this.rbRandomData.Location = new System.Drawing.Point(6, 64);
            this.rbRandomData.Name = "rbRandomData";
            this.rbRandomData.Size = new System.Drawing.Size(190, 24);
            this.rbRandomData.TabIndex = 4;
            this.rbRandomData.TabStop = true;
            this.rbRandomData.Text = "Wygeneruj dane losowo";
            this.rbRandomData.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFileData);
            this.groupBox1.Controls.Add(this.rbRandomData);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.rbInsertData);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 235);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz akcje";
            // 
            // rbFileData
            // 
            this.rbFileData.AutoSize = true;
            this.rbFileData.Location = new System.Drawing.Point(6, 94);
            this.rbFileData.Name = "rbFileData";
            this.rbFileData.Size = new System.Drawing.Size(174, 24);
            this.rbFileData.TabIndex = 5;
            this.rbFileData.TabStop = true;
            this.rbFileData.Text = "Odczyt danych z pliku";
            this.rbFileData.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button3;
        private RadioButton rbInsertData;
        private RadioButton rbRandomData;
        private GroupBox groupBox1;
        private RadioButton rbFileData;
    }
}