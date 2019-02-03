namespace DrawGraphics
{
    partial class FormParabol
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
            this.numericUpDown_VertexX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_VertexY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_a = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_OK_FormParabol = new System.Windows.Forms.Button();
            this.comboBox_Algorithm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VertexX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VertexY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algorithm:";
            // 
            // numericUpDown_VertexX
            // 
            this.numericUpDown_VertexX.Location = new System.Drawing.Point(122, 55);
            this.numericUpDown_VertexX.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numericUpDown_VertexX.Name = "numericUpDown_VertexX";
            this.numericUpDown_VertexX.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown_VertexX.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vertex:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Y";
            // 
            // numericUpDown_VertexY
            // 
            this.numericUpDown_VertexY.Location = new System.Drawing.Point(240, 55);
            this.numericUpDown_VertexY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_VertexY.Name = "numericUpDown_VertexY";
            this.numericUpDown_VertexY.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown_VertexY.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Coefficient:";
            // 
            // numericUpDown_a
            // 
            this.numericUpDown_a.DecimalPlaces = 2;
            this.numericUpDown_a.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_a.Location = new System.Drawing.Point(122, 83);
            this.numericUpDown_a.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_a.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numericUpDown_a.Name = "numericUpDown_a";
            this.numericUpDown_a.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown_a.TabIndex = 8;
            this.numericUpDown_a.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_a.ValueChanged += new System.EventHandler(this.numericUpDown_a_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "a";
            // 
            // btn_OK_FormParabol
            // 
            this.btn_OK_FormParabol.Location = new System.Drawing.Point(246, 110);
            this.btn_OK_FormParabol.Name = "btn_OK_FormParabol";
            this.btn_OK_FormParabol.Size = new System.Drawing.Size(75, 45);
            this.btn_OK_FormParabol.TabIndex = 10;
            this.btn_OK_FormParabol.Text = "OK";
            this.btn_OK_FormParabol.UseVisualStyleBackColor = true;
            this.btn_OK_FormParabol.Click += new System.EventHandler(this.btn_OK_FormParabol_Click);
            // 
            // comboBox_Algorithm
            // 
            this.comboBox_Algorithm.FormattingEnabled = true;
            this.comboBox_Algorithm.Location = new System.Drawing.Point(105, 27);
            this.comboBox_Algorithm.Name = "comboBox_Algorithm";
            this.comboBox_Algorithm.Size = new System.Drawing.Size(217, 21);
            this.comboBox_Algorithm.TabIndex = 37;
            // 
            // FormParabol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 203);
            this.Controls.Add(this.comboBox_Algorithm);
            this.Controls.Add(this.btn_OK_FormParabol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_a);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_VertexY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_VertexX);
            this.Controls.Add(this.label1);
            this.Name = "FormParabol";
            this.Text = "Input Parabol";
            this.Load += new System.EventHandler(this.FormParabol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VertexX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VertexY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_VertexX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_VertexY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_a;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_OK_FormParabol;
        private System.Windows.Forms.ComboBox comboBox_Algorithm;
    }
}