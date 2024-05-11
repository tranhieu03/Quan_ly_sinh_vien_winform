
namespace BTL_2023_c
{
    partial class QLSV
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mask_maSV = new System.Windows.Forms.MaskedTextBox();
            this.mask_tenSv = new System.Windows.Forms.MaskedTextBox();
            this.mask_ngaySinh = new System.Windows.Forms.MaskedTextBox();
            this.mask_queQuan = new System.Windows.Forms.MaskedTextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.combo_malop = new System.Windows.Forms.ComboBox();
            this.dtGridSV = new System.Windows.Forms.DataGridView();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxXem = new System.Windows.Forms.ComboBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mask_GT = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quê quán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã lớp";
            // 
            // mask_maSV
            // 
            this.mask_maSV.Location = new System.Drawing.Point(119, 11);
            this.mask_maSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mask_maSV.Name = "mask_maSV";
            this.mask_maSV.Size = new System.Drawing.Size(221, 26);
            this.mask_maSV.TabIndex = 6;
            // 
            // mask_tenSv
            // 
            this.mask_tenSv.Location = new System.Drawing.Point(119, 66);
            this.mask_tenSv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mask_tenSv.Name = "mask_tenSv";
            this.mask_tenSv.Size = new System.Drawing.Size(221, 26);
            this.mask_tenSv.TabIndex = 7;
            // 
            // mask_ngaySinh
            // 
            this.mask_ngaySinh.Location = new System.Drawing.Point(119, 192);
            this.mask_ngaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mask_ngaySinh.Mask = "00/00/0000";
            this.mask_ngaySinh.Name = "mask_ngaySinh";
            this.mask_ngaySinh.Size = new System.Drawing.Size(221, 26);
            this.mask_ngaySinh.TabIndex = 9;
            this.mask_ngaySinh.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mask_ngaySinh_MaskInputRejected);
            // 
            // mask_queQuan
            // 
            this.mask_queQuan.Location = new System.Drawing.Point(119, 252);
            this.mask_queQuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mask_queQuan.Name = "mask_queQuan";
            this.mask_queQuan.Size = new System.Drawing.Size(221, 26);
            this.mask_queQuan.TabIndex = 10;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_them.Location = new System.Drawing.Point(4, 8);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(90, 65);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_sua.Location = new System.Drawing.Point(142, 8);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(90, 65);
            this.btn_sua.TabIndex = 13;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_xoa.Location = new System.Drawing.Point(277, 8);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(90, 65);
            this.btn_xoa.TabIndex = 14;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // combo_malop
            // 
            this.combo_malop.FormattingEnabled = true;
            this.combo_malop.Location = new System.Drawing.Point(119, 318);
            this.combo_malop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_malop.Name = "combo_malop";
            this.combo_malop.Size = new System.Drawing.Size(221, 28);
            this.combo_malop.TabIndex = 15;
            // 
            // dtGridSV
            // 
            this.dtGridSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSV.Location = new System.Drawing.Point(397, 16);
            this.dtGridSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtGridSV.Name = "dtGridSV";
            this.dtGridSV.RowHeadersWidth = 51;
            this.dtGridSV.RowTemplate.Height = 24;
            this.dtGridSV.Size = new System.Drawing.Size(1127, 441);
            this.dtGridSV.TabIndex = 16;
            this.dtGridSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridSV_CellClick);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(82, 14);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(386, 26);
            this.tb_Search.TabIndex = 17;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tìm kiếm";
            // 
            // cbxXem
            // 
            this.cbxXem.FormattingEnabled = true;
            this.cbxXem.Location = new System.Drawing.Point(18, 11);
            this.cbxXem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxXem.Name = "cbxXem";
            this.cbxXem.Size = new System.Drawing.Size(257, 28);
            this.cbxXem.TabIndex = 19;
            this.cbxXem.Text = "Xem";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(282, 4);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(84, 49);
            this.btnChon.TabIndex = 20;
            this.btnChon.Text = "Chọn ";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mask_maSV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mask_tenSv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mask_GT);
            this.panel1.Controls.Add(this.combo_malop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mask_ngaySinh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.mask_queQuan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 360);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // mask_GT
            // 
            this.mask_GT.Location = new System.Drawing.Point(119, 129);
            this.mask_GT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mask_GT.Name = "mask_GT";
            this.mask_GT.Size = new System.Drawing.Size(221, 26);
            this.mask_GT.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Location = new System.Drawing.Point(14, 385);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 72);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tb_Search);
            this.panel3.Location = new System.Drawing.Point(390, 466);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 56);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbxXem);
            this.panel4.Controls.Add(this.btnChon);
            this.panel4.Location = new System.Drawing.Point(14, 466);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(370, 56);
            this.panel4.TabIndex = 24;
            // 
            // QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 544);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtGridSV);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QLSV";
            this.Text = "QLSV";
            this.Load += new System.EventHandler(this.QLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mask_maSV;
        private System.Windows.Forms.MaskedTextBox mask_tenSv;
        private System.Windows.Forms.MaskedTextBox mask_ngaySinh;
        private System.Windows.Forms.MaskedTextBox mask_queQuan;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.ComboBox combo_malop;
        private System.Windows.Forms.DataGridView dtGridSV;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxXem;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox mask_GT;
    }
}