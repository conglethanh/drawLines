namespace DrawGraphics
{
    partial class FormAccuracy
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_OK_formStat = new System.Windows.Forms.Button();
            this.label_var_xiaolin = new System.Windows.Forms.Label();
            this.label_var_bresenham = new System.Windows.Forms.Label();
            this.label_var_midpoint = new System.Windows.Forms.Label();
            this.label_var_dda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Xiaolin Wu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mid point:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bresenham:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "DDA:";
            // 
            // btn_OK_formStat
            // 
            this.btn_OK_formStat.Location = new System.Drawing.Point(109, 183);
            this.btn_OK_formStat.Name = "btn_OK_formStat";
            this.btn_OK_formStat.Size = new System.Drawing.Size(75, 36);
            this.btn_OK_formStat.TabIndex = 15;
            this.btn_OK_formStat.Text = "OK";
            this.btn_OK_formStat.UseVisualStyleBackColor = true;
            this.btn_OK_formStat.Click += new System.EventHandler(this.btn_OK_formStat_Click_1);
            // 
            // label_var_xiaolin
            // 
            this.label_var_xiaolin.AutoSize = true;
            this.label_var_xiaolin.Location = new System.Drawing.Point(98, 147);
            this.label_var_xiaolin.Name = "label_var_xiaolin";
            this.label_var_xiaolin.Size = new System.Drawing.Size(13, 13);
            this.label_var_xiaolin.TabIndex = 14;
            this.label_var_xiaolin.Text = "--";
            // 
            // label_var_bresenham
            // 
            this.label_var_bresenham.AutoSize = true;
            this.label_var_bresenham.Location = new System.Drawing.Point(98, 94);
            this.label_var_bresenham.Name = "label_var_bresenham";
            this.label_var_bresenham.Size = new System.Drawing.Size(13, 13);
            this.label_var_bresenham.TabIndex = 13;
            this.label_var_bresenham.Text = "--";
            // 
            // label_var_midpoint
            // 
            this.label_var_midpoint.AutoSize = true;
            this.label_var_midpoint.Location = new System.Drawing.Point(98, 120);
            this.label_var_midpoint.Name = "label_var_midpoint";
            this.label_var_midpoint.Size = new System.Drawing.Size(13, 13);
            this.label_var_midpoint.TabIndex = 12;
            this.label_var_midpoint.Text = "--";
            // 
            // label_var_dda
            // 
            this.label_var_dda.AutoSize = true;
            this.label_var_dda.Location = new System.Drawing.Point(98, 69);
            this.label_var_dda.Name = "label_var_dda";
            this.label_var_dda.Size = new System.Drawing.Size(13, 13);
            this.label_var_dda.TabIndex = 11;
            this.label_var_dda.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Comparision Accuracy with Var (Small is better)";
            // 
            // FormAccuracy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_OK_formStat);
            this.Controls.Add(this.label_var_xiaolin);
            this.Controls.Add(this.label_var_bresenham);
            this.Controls.Add(this.label_var_midpoint);
            this.Controls.Add(this.label_var_dda);
            this.Controls.Add(this.label1);
            this.Name = "FormAccuracy";
            this.Text = "Form Accuracy";
            this.Load += new System.EventHandler(this.FormAccuracy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OK_formStat;
        private System.Windows.Forms.Label label_var_xiaolin;
        private System.Windows.Forms.Label label_var_bresenham;
        private System.Windows.Forms.Label label_var_midpoint;
        private System.Windows.Forms.Label label_var_dda;
        private System.Windows.Forms.Label label1;
    }
}