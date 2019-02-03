namespace DrawGraphics
{
    partial class FormMain
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
            this.picBox_main = new System.Windows.Forms.PictureBox();
            this.btn_inputLine = new System.Windows.Forms.Button();
            this.btn_draw = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_statistics = new System.Windows.Forms.Button();
            this.btn_randomOptions = new System.Windows.Forms.Button();
            this.btn_inputParabol = new System.Windows.Forms.Button();
            this.btn_inputEllipse = new System.Windows.Forms.Button();
            this.btn_inputCircle = new System.Windows.Forms.Button();
            this.btn_intputHyperbol = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonHDSD = new System.Windows.Forms.Button();
            this.numObj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_main
            // 
            this.picBox_main.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picBox_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_main.Location = new System.Drawing.Point(10, 10);
            this.picBox_main.Name = "picBox_main";
            this.picBox_main.Size = new System.Drawing.Size(700, 500);
            this.picBox_main.TabIndex = 0;
            this.picBox_main.TabStop = false;
            this.picBox_main.Click += new System.EventHandler(this.picBox_main_Click);
            // 
            // btn_inputLine
            // 
            this.btn_inputLine.Location = new System.Drawing.Point(734, 11);
            this.btn_inputLine.Name = "btn_inputLine";
            this.btn_inputLine.Size = new System.Drawing.Size(97, 23);
            this.btn_inputLine.TabIndex = 1;
            this.btn_inputLine.TabStop = false;
            this.btn_inputLine.Text = "Input Line";
            this.btn_inputLine.UseVisualStyleBackColor = true;
            this.btn_inputLine.Click += new System.EventHandler(this.btn_inputLine_Click);
            // 
            // btn_draw
            // 
            this.btn_draw.Location = new System.Drawing.Point(734, 244);
            this.btn_draw.Name = "btn_draw";
            this.btn_draw.Size = new System.Drawing.Size(97, 33);
            this.btn_draw.TabIndex = 2;
            this.btn_draw.TabStop = false;
            this.btn_draw.Text = "Draw";
            this.btn_draw.UseVisualStyleBackColor = true;
            this.btn_draw.Click += new System.EventHandler(this.btn_draw_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(734, 283);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(97, 32);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.TabStop = false;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_statistics
            // 
            this.btn_statistics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_statistics.Location = new System.Drawing.Point(734, 400);
            this.btn_statistics.Name = "btn_statistics";
            this.btn_statistics.Size = new System.Drawing.Size(97, 50);
            this.btn_statistics.TabIndex = 4;
            this.btn_statistics.TabStop = false;
            this.btn_statistics.Text = "Statistics";
            this.btn_statistics.UseVisualStyleBackColor = true;
            this.btn_statistics.Click += new System.EventHandler(this.btn_statistics_Click);
            // 
            // btn_randomOptions
            // 
            this.btn_randomOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_randomOptions.Location = new System.Drawing.Point(734, 344);
            this.btn_randomOptions.Name = "btn_randomOptions";
            this.btn_randomOptions.Size = new System.Drawing.Size(97, 50);
            this.btn_randomOptions.TabIndex = 5;
            this.btn_randomOptions.TabStop = false;
            this.btn_randomOptions.Text = "Random Options";
            this.btn_randomOptions.UseVisualStyleBackColor = true;
            this.btn_randomOptions.Click += new System.EventHandler(this.btn_randomOptions_Click);
            // 
            // btn_inputParabol
            // 
            this.btn_inputParabol.Location = new System.Drawing.Point(734, 98);
            this.btn_inputParabol.Name = "btn_inputParabol";
            this.btn_inputParabol.Size = new System.Drawing.Size(97, 23);
            this.btn_inputParabol.TabIndex = 6;
            this.btn_inputParabol.TabStop = false;
            this.btn_inputParabol.Text = "Input Parabol";
            this.btn_inputParabol.UseVisualStyleBackColor = true;
            this.btn_inputParabol.Click += new System.EventHandler(this.btn_inputParabol_Click);
            // 
            // btn_inputEllipse
            // 
            this.btn_inputEllipse.Location = new System.Drawing.Point(734, 69);
            this.btn_inputEllipse.Name = "btn_inputEllipse";
            this.btn_inputEllipse.Size = new System.Drawing.Size(97, 23);
            this.btn_inputEllipse.TabIndex = 7;
            this.btn_inputEllipse.TabStop = false;
            this.btn_inputEllipse.Text = "Input Ellipse";
            this.btn_inputEllipse.UseVisualStyleBackColor = true;
            this.btn_inputEllipse.Click += new System.EventHandler(this.btn_inputEllipse_Click);
            // 
            // btn_inputCircle
            // 
            this.btn_inputCircle.Location = new System.Drawing.Point(734, 40);
            this.btn_inputCircle.Name = "btn_inputCircle";
            this.btn_inputCircle.Size = new System.Drawing.Size(97, 23);
            this.btn_inputCircle.TabIndex = 8;
            this.btn_inputCircle.TabStop = false;
            this.btn_inputCircle.Text = "Input Circle";
            this.btn_inputCircle.UseVisualStyleBackColor = true;
            this.btn_inputCircle.Click += new System.EventHandler(this.btn_inputCircle_Click);
            // 
            // btn_intputHyperbol
            // 
            this.btn_intputHyperbol.Location = new System.Drawing.Point(734, 127);
            this.btn_intputHyperbol.Name = "btn_intputHyperbol";
            this.btn_intputHyperbol.Size = new System.Drawing.Size(97, 23);
            this.btn_intputHyperbol.TabIndex = 9;
            this.btn_intputHyperbol.TabStop = false;
            this.btn_intputHyperbol.Text = "Input Hyperbol";
            this.btn_intputHyperbol.UseVisualStyleBackColor = true;
            this.btn_intputHyperbol.Click += new System.EventHandler(this.btn_intputHyperbol_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(734, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(97, 82);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonHDSD
            // 
            this.buttonHDSD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHDSD.Location = new System.Drawing.Point(727, 472);
            this.buttonHDSD.Name = "buttonHDSD";
            this.buttonHDSD.Size = new System.Drawing.Size(115, 38);
            this.buttonHDSD.TabIndex = 12;
            this.buttonHDSD.TabStop = false;
            this.buttonHDSD.Text = "Hướng dẫn sử dụng";
            this.buttonHDSD.UseVisualStyleBackColor = true;
            this.buttonHDSD.Click += new System.EventHandler(this.buttonHDSD_Click);
            // 
            // numObj
            // 
            this.numObj.AutoSize = true;
            this.numObj.Location = new System.Drawing.Point(18, 18);
            this.numObj.Name = "numObj";
            this.numObj.Size = new System.Drawing.Size(0, 13);
            this.numObj.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 522);
            this.Controls.Add(this.numObj);
            this.Controls.Add(this.buttonHDSD);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_intputHyperbol);
            this.Controls.Add(this.btn_inputCircle);
            this.Controls.Add(this.btn_inputEllipse);
            this.Controls.Add(this.btn_inputParabol);
            this.Controls.Add(this.btn_randomOptions);
            this.Controls.Add(this.btn_statistics);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_draw);
            this.Controls.Add(this.btn_inputLine);
            this.Controls.Add(this.picBox_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "LAB01 LineAlgorithm by 1612842 Lê Thành Công";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_main;
        private System.Windows.Forms.Button btn_inputLine;
        private System.Windows.Forms.Button btn_draw;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_statistics;
        private System.Windows.Forms.Button btn_randomOptions;
        private System.Windows.Forms.Button btn_inputParabol;
        private System.Windows.Forms.Button btn_inputEllipse;
        private System.Windows.Forms.Button btn_inputCircle;
        private System.Windows.Forms.Button btn_intputHyperbol;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonHDSD;
        private System.Windows.Forms.Label numObj;
    }
}

