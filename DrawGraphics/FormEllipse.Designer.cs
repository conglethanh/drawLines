namespace DrawGraphics
{
    partial class FormEllipse
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
            this.btn_OK_FormEllipse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_a = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_VertexY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_VertexX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_b = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_Algorithm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VertexY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VertexX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK_FormEllipse
            // 
            this.btn_OK_FormEllipse.Location = new System.Drawing.Point(242, 108);
            this.btn_OK_FormEllipse.Name = "btn_OK_FormEllipse";
            this.btn_OK_FormEllipse.Size = new System.Drawing.Size(75, 45);
            this.btn_OK_FormEllipse.TabIndex = 32;
            this.btn_OK_FormEllipse.Text = "OK";
            this.btn_OK_FormEllipse.UseVisualStyleBackColor = true;
            this.btn_OK_FormEllipse.Click += new System.EventHandler(this.btn_OK_FormEllipse_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "a";
            // 
            // numericUpDown_a
            // 
            this.numericUpDown_a.Location = new System.Drawing.Point(118, 81);
            this.numericUpDown_a.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_a.Name = "numericUpDown_a";
            this.numericUpDown_a.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown_a.TabIndex = 30;
            this.numericUpDown_a.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Half big axis:";
            // 
            // numericUpDown_VertexY
            // 
            this.numericUpDown_VertexY.Location = new System.Drawing.Point(236, 53);
            this.numericUpDown_VertexY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_VertexY.Name = "numericUpDown_VertexY";
            this.numericUpDown_VertexY.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown_VertexY.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Center:";
            // 
            // numericUpDown_VertexX
            // 
            this.numericUpDown_VertexX.Location = new System.Drawing.Point(118, 53);
            this.numericUpDown_VertexX.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numericUpDown_VertexX.Name = "numericUpDown_VertexX";
            this.numericUpDown_VertexX.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown_VertexX.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Algorithm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "b";
            // 
            // numericUpDown_b
            // 
            this.numericUpDown_b.Location = new System.Drawing.Point(118, 109);
            this.numericUpDown_b.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_b.Name = "numericUpDown_b";
            this.numericUpDown_b.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown_b.TabIndex = 34;
            this.numericUpDown_b.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Half small axis:";
            // 
            // comboBox_Algorithm
            // 
            this.comboBox_Algorithm.FormattingEnabled = true;
            this.comboBox_Algorithm.Location = new System.Drawing.Point(100, 26);
            this.comboBox_Algorithm.Name = "comboBox_Algorithm";
            this.comboBox_Algorithm.Size = new System.Drawing.Size(217, 21);
            this.comboBox_Algorithm.TabIndex = 36;
            // 
            // FormEllipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 203);
            this.Controls.Add(this.comboBox_Algorithm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_b);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_OK_FormEllipse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_a);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_VertexY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_VertexX);
            this.Controls.Add(this.label1);
            this.Name = "FormEllipse";
            this.Text = "Input Ellipse";
            this.Load += new System.EventHandler(this.FormEllipse_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VertexY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VertexX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK_FormEllipse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_a;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_VertexY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_VertexX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_b;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_Algorithm;
    }
}