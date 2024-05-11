
namespace BTL_2023_c
{
    partial class DiemSV
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
            this.crtDiemSV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMasv = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crtDiemSV
            // 
            this.crtDiemSV.ActiveViewIndex = -1;
            this.crtDiemSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtDiemSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtDiemSV.Location = new System.Drawing.Point(1, 175);
            this.crtDiemSV.Name = "crtDiemSV";
            this.crtDiemSV.Size = new System.Drawing.Size(1281, 509);
            this.crtDiemSV.TabIndex = 0;
            this.crtDiemSV.Load += new System.EventHandler(this.crtDiemSV_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sinh Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khoa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giới Tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lớp:";
            // 
            // cbMasv
            // 
            this.cbMasv.FormattingEnabled = true;
            this.cbMasv.Location = new System.Drawing.Point(160, 11);
            this.cbMasv.Name = "cbMasv";
            this.cbMasv.Size = new System.Drawing.Size(191, 28);
            this.cbMasv.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(160, 58);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(191, 26);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(160, 107);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(191, 26);
            this.txtKhoa.TabIndex = 9;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(589, 13);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(175, 26);
            this.txtNgaySinh.TabIndex = 10;
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(589, 59);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(175, 26);
            this.txtGT.TabIndex = 11;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(589, 101);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(175, 26);
            this.txtLop.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "IN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.cbMasv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crtDiemSV);
            this.Name = "DiemSV";
            this.Text = "DiemSV";
            this.Load += new System.EventHandler(this.DiemSV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtDiemSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMasv;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Button button1;
    }
}