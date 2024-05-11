
namespace BTL_2023_c
{
    partial class QLLop
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
            this.mask_maLop = new System.Windows.Forms.MaskedTextBox();
            this.mask_tenLop = new System.Windows.Forms.MaskedTextBox();
            this.combo_maKhoa = new System.Windows.Forms.ComboBox();
            this.mask_soSV = new System.Windows.Forms.MaskedTextBox();
            this.dtGridLop = new System.Windows.Forms.DataGridView();
            this.btn_ThemLop = new System.Windows.Forms.Button();
            this.btn_suaLop = new System.Windows.Forms.Button();
            this.btn_xoaLop = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số SV";
            // 
            // mask_maLop
            // 
            this.mask_maLop.Location = new System.Drawing.Point(201, 44);
            this.mask_maLop.Name = "mask_maLop";
            this.mask_maLop.Size = new System.Drawing.Size(143, 22);
            this.mask_maLop.TabIndex = 4;
            // 
            // mask_tenLop
            // 
            this.mask_tenLop.Location = new System.Drawing.Point(201, 110);
            this.mask_tenLop.Name = "mask_tenLop";
            this.mask_tenLop.Size = new System.Drawing.Size(143, 22);
            this.mask_tenLop.TabIndex = 5;
            // 
            // combo_maKhoa
            // 
            this.combo_maKhoa.FormattingEnabled = true;
            this.combo_maKhoa.Location = new System.Drawing.Point(201, 166);
            this.combo_maKhoa.Name = "combo_maKhoa";
            this.combo_maKhoa.Size = new System.Drawing.Size(143, 24);
            this.combo_maKhoa.TabIndex = 6;
            // 
            // mask_soSV
            // 
            this.mask_soSV.Location = new System.Drawing.Point(201, 233);
            this.mask_soSV.Name = "mask_soSV";
            this.mask_soSV.Size = new System.Drawing.Size(143, 22);
            this.mask_soSV.TabIndex = 7;
            // 
            // dtGridLop
            // 
            this.dtGridLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridLop.Location = new System.Drawing.Point(487, 49);
            this.dtGridLop.Name = "dtGridLop";
            this.dtGridLop.RowHeadersWidth = 51;
            this.dtGridLop.RowTemplate.Height = 24;
            this.dtGridLop.Size = new System.Drawing.Size(692, 206);
            this.dtGridLop.TabIndex = 8;
            this.dtGridLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridLop_CellClick);
            // 
            // btn_ThemLop
            // 
            this.btn_ThemLop.Location = new System.Drawing.Point(245, 352);
            this.btn_ThemLop.Name = "btn_ThemLop";
            this.btn_ThemLop.Size = new System.Drawing.Size(79, 30);
            this.btn_ThemLop.TabIndex = 9;
            this.btn_ThemLop.Text = "Thêm";
            this.btn_ThemLop.UseVisualStyleBackColor = true;
            this.btn_ThemLop.Click += new System.EventHandler(this.btn_ThemLop_Click);
            // 
            // btn_suaLop
            // 
            this.btn_suaLop.Location = new System.Drawing.Point(569, 352);
            this.btn_suaLop.Name = "btn_suaLop";
            this.btn_suaLop.Size = new System.Drawing.Size(79, 30);
            this.btn_suaLop.TabIndex = 10;
            this.btn_suaLop.Text = "Sửa";
            this.btn_suaLop.UseVisualStyleBackColor = true;
            this.btn_suaLop.Click += new System.EventHandler(this.btn_suaLop_Click);
            // 
            // btn_xoaLop
            // 
            this.btn_xoaLop.Location = new System.Drawing.Point(894, 352);
            this.btn_xoaLop.Name = "btn_xoaLop";
            this.btn_xoaLop.Size = new System.Drawing.Size(79, 30);
            this.btn_xoaLop.TabIndex = 11;
            this.btn_xoaLop.Text = "Xóa";
            this.btn_xoaLop.UseVisualStyleBackColor = true;
            this.btn_xoaLop.Click += new System.EventHandler(this.btn_xoaLop_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(554, 287);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(625, 22);
            this.tb_Search.TabIndex = 12;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tìm kiếm";
            // 
            // QLLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.btn_xoaLop);
            this.Controls.Add(this.btn_suaLop);
            this.Controls.Add(this.btn_ThemLop);
            this.Controls.Add(this.dtGridLop);
            this.Controls.Add(this.mask_soSV);
            this.Controls.Add(this.combo_maKhoa);
            this.Controls.Add(this.mask_tenLop);
            this.Controls.Add(this.mask_maLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLLop";
            this.Text = "QLLop";
            this.Load += new System.EventHandler(this.QLLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mask_maLop;
        private System.Windows.Forms.MaskedTextBox mask_tenLop;
        private System.Windows.Forms.ComboBox combo_maKhoa;
        private System.Windows.Forms.MaskedTextBox mask_soSV;
        private System.Windows.Forms.DataGridView dtGridLop;
        private System.Windows.Forms.Button btn_ThemLop;
        private System.Windows.Forms.Button btn_suaLop;
        private System.Windows.Forms.Button btn_xoaLop;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label5;
    }
}