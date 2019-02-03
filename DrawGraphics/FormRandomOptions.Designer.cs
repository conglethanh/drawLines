namespace DrawGraphics
{
    partial class FormRandomOptions
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
            this.numericUpDown_numObject = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_RandomOptions_Shape = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_RandomOptions_Algorithm = new System.Windows.Forms.ListBox();
            this.btn_RandomOptions_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numObject)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_numObject
            // 
            this.numericUpDown_numObject.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_numObject.Location = new System.Drawing.Point(158, 168);
            this.numericUpDown_numObject.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_numObject.Name = "numericUpDown_numObject";
            this.numericUpDown_numObject.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_numObject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type:";
            // 
            // comboBox_RandomOptions_Shape
            // 
            this.comboBox_RandomOptions_Shape.FormattingEnabled = true;
            this.comboBox_RandomOptions_Shape.Location = new System.Drawing.Point(157, 36);
            this.comboBox_RandomOptions_Shape.Name = "comboBox_RandomOptions_Shape";
            this.comboBox_RandomOptions_Shape.Size = new System.Drawing.Size(121, 21);
            this.comboBox_RandomOptions_Shape.TabIndex = 2;
            this.comboBox_RandomOptions_Shape.SelectedIndexChanged += new System.EventHandler(this.comboBox_RandomOptions_Shape_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Algorithm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number object:";
            // 
            // listBox_RandomOptions_Algorithm
            // 
            this.listBox_RandomOptions_Algorithm.FormattingEnabled = true;
            this.listBox_RandomOptions_Algorithm.Location = new System.Drawing.Point(158, 77);
            this.listBox_RandomOptions_Algorithm.Name = "listBox_RandomOptions_Algorithm";
            this.listBox_RandomOptions_Algorithm.Size = new System.Drawing.Size(120, 69);
            this.listBox_RandomOptions_Algorithm.TabIndex = 6;
            this.listBox_RandomOptions_Algorithm.SelectedIndexChanged += new System.EventHandler(this.listBox_RandomOptions_Algorithm_SelectedIndexChanged);
            // 
            // btn_RandomOptions_OK
            // 
            this.btn_RandomOptions_OK.Location = new System.Drawing.Point(203, 212);
            this.btn_RandomOptions_OK.Name = "btn_RandomOptions_OK";
            this.btn_RandomOptions_OK.Size = new System.Drawing.Size(75, 46);
            this.btn_RandomOptions_OK.TabIndex = 7;
            this.btn_RandomOptions_OK.Text = "OK";
            this.btn_RandomOptions_OK.UseVisualStyleBackColor = true;
            this.btn_RandomOptions_OK.Click += new System.EventHandler(this.btn_RandomOptions_OK_Click);
            // 
            // FormRandomOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 293);
            this.Controls.Add(this.btn_RandomOptions_OK);
            this.Controls.Add(this.listBox_RandomOptions_Algorithm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_RandomOptions_Shape);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_numObject);
            this.Name = "FormRandomOptions";
            this.ShowInTaskbar = false;
            this.Text = "Random Options";
            this.Load += new System.EventHandler(this.FormRandomOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numObject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_numObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_RandomOptions_Shape;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_RandomOptions_Algorithm;
        private System.Windows.Forms.Button btn_RandomOptions_OK;
    }
}