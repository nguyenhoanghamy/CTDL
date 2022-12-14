namespace DoAnCTDL
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btTinhDuongDi = new System.Windows.Forms.Button();
            this.cbbDiemCuoi = new System.Windows.Forms.ComboBox();
            this.cbbDiemDau = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BackgroundImage = global::DoAnCTDL.Properties.Resources.z3936326828085_d548fa0acbd8b8ab9ec9418edbf2f2a4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(479, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 675);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtbLog);
            this.groupBox3.Location = new System.Drawing.Point(7, 454);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(461, 169);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(9, 29);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(414, 113);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btTinhDuongDi);
            this.groupBox2.Controls.Add(this.cbbDiemCuoi);
            this.groupBox2.Controls.Add(this.cbbDiemDau);
            this.groupBox2.Location = new System.Drawing.Point(7, 65);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(465, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính Đường Đi";
            // 
            // btTinhDuongDi
            // 
            this.btTinhDuongDi.Location = new System.Drawing.Point(336, 36);
            this.btTinhDuongDi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTinhDuongDi.Name = "btTinhDuongDi";
            this.btTinhDuongDi.Size = new System.Drawing.Size(90, 41);
            this.btTinhDuongDi.TabIndex = 12;
            this.btTinhDuongDi.Text = "Result";
            this.btTinhDuongDi.UseVisualStyleBackColor = true;
            this.btTinhDuongDi.Click += new System.EventHandler(this.btTinhDuongDi_Click);
            // 
            // cbbDiemCuoi
            // 
            this.cbbDiemCuoi.FormattingEnabled = true;
            this.cbbDiemCuoi.Location = new System.Drawing.Point(173, 42);
            this.cbbDiemCuoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbDiemCuoi.Name = "cbbDiemCuoi";
            this.cbbDiemCuoi.Size = new System.Drawing.Size(129, 28);
            this.cbbDiemCuoi.TabIndex = 6;
            // 
            // cbbDiemDau
            // 
            this.cbbDiemDau.FormattingEnabled = true;
            this.cbbDiemDau.Location = new System.Drawing.Point(22, 42);
            this.cbbDiemDau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbDiemDau.Name = "cbbDiemDau";
            this.cbbDiemDau.Size = new System.Drawing.Size(129, 28);
            this.cbbDiemDau.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 702);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btTinhDuongDi;
        private System.Windows.Forms.ComboBox cbbDiemCuoi;
        private System.Windows.Forms.ComboBox cbbDiemDau;
    }
}

