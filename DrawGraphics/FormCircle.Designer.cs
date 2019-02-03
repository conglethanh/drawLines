namespace DrawGraphics
{
    partial class FormCircle
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
            this.btn_OK_FormCircle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_a = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_VertexY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_VertexX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Algorithm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VertexY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VertexX)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK_FormCircle
            // 
            this.btn_OK_FormCircle.Location = new System.Drawing.Point(261, 118);
            this.btn_OK_FormCircle.Name = "btn_OK_FormCircle";
            this.btn_OK_FormCircle.Size = new System.Drawing.Size(75, 45);
            this.btn_OK_FormCircle.TabIndex = 21;
            this.btn_OK_FormCircle.Text = "OK";
            this.btn_OK_FormCircle.UseVisualStyleBackColor = true;
            this.btn_OK_FormCircle.Click += new System.EventHandler(this.btn_OK_FormCircle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "R";
            // 
            // numericUpDown_a
            // 
            this.numericUpDown_a.Location = new System.Drawing.Point(137, 91);
            this.numericUpDown_a.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown_a.Name = "numericUpDown_a";
            this.numericUpDown_a.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown_a.TabIndex = 19;
            this.numericUpDown_a.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Radius:";
            // 
            // numericUpDown_VertexY
            // 
            this.numericUpDown_VertexY.Location = new System.Drawing.Point(255, 63);
            this.numericUpDown_VertexY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_VertexY.Name = "numericUpDown_VertexY";
            this.numericUpDown_VertexY.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown_VertexY.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Center:";
            // 
            // numericUpDown_VertexX
            // 
            this.numericUpDown_VertexX.Location = new System.Drawing.Point(137, 63);
            this.numericUpDown_VertexX.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numericUpDown_VertexX.Name = "numericUpDown_VertexX";
            this.numericUpDown_VertexX.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown_VertexX.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Algorithm:";
            // 
            // comboBox_Algorithm
            // 
            this.comboBox_Algorithm.FormattingEnabled = true;
            this.comboBox_Algorithm.Location = new System.Drawing.Point(119, 35);
            this.comboBox_Algorithm.Name = "comboBox_Algorithm";
            this.comboBox_Algorithm.Size = new System.Drawing.Size(217, 21);
            this.comboBox_Algorithm.TabIndex = 22;
            // 
            // FormCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 201);
            this.Controls.Add(this.comboBox_Algorithm);
            this.Controls.Add(this.btn_OK_FormCircle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_a);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_VertexY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_VertexX);
            this.Controls.Add(this.label1);
            this.Name = "FormCircle";
            this.Text = "Input Circle";
            this.Load += new System.EventHandler(this.FormCircle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VertexY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VertexX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK_FormCircle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_a;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_VertexY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_VertexX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Algorithm;
    }
}