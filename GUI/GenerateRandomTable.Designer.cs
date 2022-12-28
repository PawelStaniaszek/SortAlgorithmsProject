namespace GUI
{
    partial class GenerateRandomTable
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
            this.nudLengthOfArray = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMinValue = new System.Windows.Forms.NumericUpDown();
            this.nudMaxValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLengthOfArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudLengthOfArray
            // 
            this.nudLengthOfArray.Location = new System.Drawing.Point(194, 55);
            this.nudLengthOfArray.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudLengthOfArray.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLengthOfArray.Name = "nudLengthOfArray";
            this.nudLengthOfArray.Size = new System.Drawing.Size(150, 27);
            this.nudLengthOfArray.TabIndex = 0;
            this.nudLengthOfArray.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liczba elementów:";
            // 
            // nudMinValue
            // 
            this.nudMinValue.Location = new System.Drawing.Point(194, 88);
            this.nudMinValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMinValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinValue.Name = "nudMinValue";
            this.nudMinValue.Size = new System.Drawing.Size(150, 27);
            this.nudMinValue.TabIndex = 2;
            this.nudMinValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMaxValue
            // 
            this.nudMaxValue.Location = new System.Drawing.Point(194, 121);
            this.nudMaxValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMaxValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxValue.Name = "nudMaxValue";
            this.nudMaxValue.Size = new System.Drawing.Size(150, 27);
            this.nudMaxValue.TabIndex = 3;
            this.nudMaxValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wartość minimalna:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wartość maksymalna:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.nudMinValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudLengthOfArray);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudMaxValue);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 228);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje generowania danych";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(299, 193);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 29);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 193);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GenerateRandomTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "GenerateRandomTable";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerateRandomTable_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudLengthOfArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown nudLengthOfArray;
        private Label label1;
        private NumericUpDown nudMinValue;
        private NumericUpDown nudMaxValue;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnConfirm;
        private Button btnBack;
    }
}