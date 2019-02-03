namespace DrawGraphics
{
    partial class FormLine
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Xstart = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK_Line = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_Xend = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Ystart = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_Yend = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Algorithm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Xstart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Xend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ystart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Yend)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algorithm:";
            // 
            // numericUpDown_Xstart
            // 
            this.numericUpDown_Xstart.Location = new System.Drawing.Point(129, 62);
            this.numericUpDown_Xstart.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numericUpDown_Xstart.Name = "numericUpDown_Xstart";
            this.numericUpDown_Xstart.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_Xstart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Point start:";
            // 
            // btnOK_Line
            // 
            this.btnOK_Line.Location = new System.Drawing.Point(322, 62);
            this.btnOK_Line.Name = "btnOK_Line";
            this.btnOK_Line.Size = new System.Drawing.Size(75, 50);
            this.btnOK_Line.TabIndex = 0;
            this.btnOK_Line.Text = "OK";
            this.btnOK_Line.UseVisualStyleBackColor = true;
            this.btnOK_Line.Click += new System.EventHandler(this.btn_OK_Line_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Point end:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "X";
            // 
            // numericUpDown_Xend
            // 
            this.numericUpDown_Xend.Location = new System.Drawing.Point(129, 92);
            this.numericUpDown_Xend.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numericUpDown_Xend.Name = "numericUpDown_Xend";
            this.numericUpDown_Xend.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_Xend.TabIndex = 7;
            this.numericUpDown_Xend.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // numericUpDown_Ystart
            // 
            this.numericUpDown_Ystart.Location = new System.Drawing.Point(232, 62);
            this.numericUpDown_Ystart.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_Ystart.Name = "numericUpDown_Ystart";
            this.numericUpDown_Ystart.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_Ystart.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Y";
            // 
            // numericUpDown_Yend
            // 
            this.numericUpDown_Yend.Location = new System.Drawing.Point(232, 92);
            this.numericUpDown_Yend.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_Yend.Name = "numericUpDown_Yend";
            this.numericUpDown_Yend.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_Yend.TabIndex = 10;
            this.numericUpDown_Yend.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Y";
            // 
            // comboBox_Algorithm
            // 
            this.comboBox_Algorithm.FormattingEnabled = true;
            this.comboBox_Algorithm.Location = new System.Drawing.Point(112, 32);
            this.comboBox_Algorithm.Name = "comboBox_Algorithm";
            this.comboBox_Algorithm.Size = new System.Drawing.Size(173, 21);
            this.comboBox_Algorithm.TabIndex = 12;
            this.comboBox_Algorithm.SelectedIndexChanged += new System.EventHandler(this.comboBox_Algorithm_SelectedIndexChanged);
            // 
            // FormLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 160);
            this.Controls.Add(this.comboBox_Algorithm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_Yend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_Ystart);
            this.Controls.Add(this.numericUpDown_Xend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOK_Line);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_Xstart);
            this.Controls.Add(this.label1);
            this.Name = "FormLine";
            this.ShowInTaskbar = false;
            this.Text = "Input Line";
            this.Load += new System.EventHandler(this.FormLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Xstart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Xend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ystart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Yend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Xstart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK_Line;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_Xend;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ystart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_Yend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Algorithm;
    }
}