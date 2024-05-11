
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
            this.mask_GT = new System.Windows.Forms.MaskedTextBox();
            this.mask_ngaySinh = new System.Windows.Forms.MaskedTextBox();
            this.mask_queQuan = new System.Windows.Forms.MaskedTextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.combo_malop = new System.Windows.Forms.ComboBox();
            this.dtGridSV = new System.Windows.Forms.DataGridView();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quê quán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã lớp";
            // 
            // mask_maSV
            // 
            this.mask_maSV.Location = new System.Drawing.Point(289, 62);
            this.mask_maSV.Name = "mask_maSV";
            this.mask_maSV.Size = new System.Drawing.Size(153, 22);
            this.mask_maSV.TabIndex = 6;
            // 
            // mask_tenSv
            // 
            this.mask_tenSv.Location = new System.Drawing.Point(289, 111);
            this.mask_tenSv.Name = "mask_tenSv";
            this.mask_tenSv.Size = new System.Drawing.Size(153, 22);
            this.mask_tenSv.TabIndex = 7;
            // 
            // mask_GT
            // 
            this.mask_GT.Location = new System.Drawing.Point(289, 165);
            this.mask_GT.Name = "mask_GT";
            this.mask_GT.Size = new System.Drawing.Size(153, 22);
            this.mask_GT.TabIndex = 8;
            // 
            // mask_ngaySinh
            // 
            this.mask_ngaySinh.Location = new System.Drawing.Point(289, 224);
            this.mask_ngaySinh.Mask = "00/00/0000";
            this.mask_ngaySinh.Name = "mask_ngaySinh";
            this.mask_ngaySinh.Size = new System.Drawing.Size(153, 22);
            this.mask_ngaySinh.TabIndex = 9;
            // 
            // mask_queQuan
            // 
            this.mask_queQuan.Location = new System.Drawing.Point(289, 290);
            this.mask_queQuan.Name = "mask_queQuan";
            this.mask_queQuan.Size = new System.Drawing.Size(153, 22);
            this.mask_queQuan.TabIndex = 10;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_them.Location = new System.Drawing.Point(317, 453);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(80, 28);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_sua.Location = new System.Drawing.Point(598, 453);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(80, 28);
            this.btn_sua.TabIndex = 13;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_xoa.Location = new System.Drawing.Point(925, 453);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(80, 28);
            this.btn_xoa.TabIndex = 14;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // combo_malop
            // 
            this.combo_malop.FormattingEnabled = true;
            this.combo_malop.Location = new System.Drawing.Point(289, 352);
            this.combo_malop.Name = "combo_malop";
            this.combo_malop.Size = new System.Drawing.Size(153, 24);
            this.combo_malop.TabIndex = 15;
            // 
            // dtGridSV
            // 
            this.dtGridSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSV.Location = new System.Drawing.Point(586, 62);
            this.dtGridSV.Name = "dtGridSV";
            this.dtGridSV.RowHeadersWidth = 51;
            this.dtGridSV.RowTemplate.Height = 24;
            this.dtGridSV.Size = new System.Drawing.Size(682, 278);
            this.dtGridSV.TabIndex = 16;
            this.dtGridSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridSV_CellClick);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(653, 359);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(615, 22);
            this.tb_Search.TabIndex = 17;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tìm kiếm";
            // 
            // QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 547);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.dtGridSV);
            this.Controls.Add(this.combo_malop);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.mask_queQuan);
            this.Controls.Add(this.mask_ngaySinh);
            this.Controls.Add(this.mask_GT);
            this.Controls.Add(this.mask_tenSv);
            this.Controls.Add(this.mask_maSV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLSV";
            this.Text = "QLSV";
            this.Load += new System.EventHandler(this.QLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MaskedTextBox mask_GT;
        private System.Windows.Forms.MaskedTextBox mask_ngaySinh;
        private System.Windows.Forms.MaskedTextBox mask_queQuan;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.ComboBox combo_malop;
        private System.Windows.Forms.DataGridView dtGridSV;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label7;
    }
}