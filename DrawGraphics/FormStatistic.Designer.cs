namespace DrawGraphics
{
    partial class FormStatistic
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
            this.label_time_dda = new System.Windows.Forms.Label();
            this.label_time_midpoint = new System.Windows.Forms.Label();
            this.label_time_bresenham = new System.Windows.Forms.Label();
            this.label_time_xiaolin = new System.Windows.Forms.Label();
            this.btn_OK_formStat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comparision time";
            // 
            // label_time_dda
            // 
            this.label_time_dda.AutoSize = true;
            this.label_time_dda.Location = new System.Drawing.Point(94, 53);
            this.label_time_dda.Name = "label_time_dda";
            this.label_time_dda.Size = new System.Drawing.Size(32, 13);
            this.label_time_dda.TabIndex = 1;
            this.label_time_dda.Text = "--(ms)";
            // 
            // label_time_midpoint
            // 
            this.label_time_midpoint.AutoSize = true;
            this.label_time_midpoint.Location = new System.Drawing.Point(94, 104);
            this.label_time_midpoint.Name = "label_time_midpoint";
            this.label_time_midpoint.Size = new System.Drawing.Size(32, 13);
            this.label_time_midpoint.TabIndex = 2;
            this.label_time_midpoint.Text = "--(ms)";
            this.label_time_midpoint.Click += new System.EventHandler(this.label_time_midpoint_Click);
            // 
            // label_time_bresenham
            // 
            this.label_time_bresenham.AutoSize = true;
            this.label_time_bresenham.Location = new System.Drawing.Point(94, 78);
            this.label_time_bresenham.Name = "label_time_bresenham";
            this.label_time_bresenham.Size = new System.Drawing.Size(32, 13);
            this.label_time_bresenham.TabIndex = 3;
            this.label_time_bresenham.Text = "--(ms)";
            // 
            // label_time_xiaolin
            // 
            this.label_time_xiaolin.AutoSize = true;
            this.label_time_xiaolin.Location = new System.Drawing.Point(94, 131);
            this.label_time_xiaolin.Name = "label_time_xiaolin";
            this.label_time_xiaolin.Size = new System.Drawing.Size(32, 13);
            this.label_time_xiaolin.TabIndex = 4;
            this.label_time_xiaolin.Text = "--(ms)";
            // 
            // btn_OK_formStat
            // 
            this.btn_OK_formStat.Location = new System.Drawing.Point(105, 167);
            this.btn_OK_formStat.Name = "btn_OK_formStat";
            this.btn_OK_formStat.Size = new System.Drawing.Size(75, 36);
            this.btn_OK_formStat.TabIndex = 5;
            this.btn_OK_formStat.Text = "OK";
            this.btn_OK_formStat.UseVisualStyleBackColor = true;
            this.btn_OK_formStat.Click += new System.EventHandler(this.btn_OK_formStat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DDA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bresenham:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mid point:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Xiaolin Wu:";
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 222);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_OK_formStat);
            this.Controls.Add(this.label_time_xiaolin);
            this.Controls.Add(this.label_time_bresenham);
            this.Controls.Add(this.label_time_midpoint);
            this.Controls.Add(this.label_time_dda);
            this.Controls.Add(this.label1);
            this.Name = "FormStatistic";
            this.ShowInTaskbar = false;
            this.Text = "Form Statistic";
            this.Load += new System.EventHandler(this.FormStatistic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_time_dda;
        private System.Windows.Forms.Label label_time_midpoint;
        private System.Windows.Forms.Label label_time_bresenham;
        private System.Windows.Forms.Label label_time_xiaolin;
        private System.Windows.Forms.Button btn_OK_formStat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}