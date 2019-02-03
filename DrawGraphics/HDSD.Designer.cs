namespace DrawGraphics
{
    partial class HDSD
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
            this.lb_HDSD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_HDSD
            // 
            this.lb_HDSD.AutoSize = true;
            this.lb_HDSD.Location = new System.Drawing.Point(5, 34);
            this.lb_HDSD.Name = "lb_HDSD";
            this.lb_HDSD.Size = new System.Drawing.Size(35, 13);
            this.lb_HDSD.TabIndex = 0;
            this.lb_HDSD.Text = "label1";
            this.lb_HDSD.Click += new System.EventHandler(this.lb_HDSD_Click);
            // 
            // HDSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 348);
            this.Controls.Add(this.lb_HDSD);
            this.Name = "HDSD";
            this.Text = "Hướng dẫn sử dụng";
            this.Load += new System.EventHandler(this.HDSD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_HDSD;
    }
}