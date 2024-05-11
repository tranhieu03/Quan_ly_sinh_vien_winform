
namespace BTL_2023_c
{
    partial class QLKhoa
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
            this.mask_maKhoa = new System.Windows.Forms.MaskedTextBox();
            this.mask_tenKhoa = new System.Windows.Forms.MaskedTextBox();
            this.mask_sdt = new System.Windows.Forms.MaskedTextBox();
            this.mask_diaChi = new System.Windows.Forms.MaskedTextBox();
            this.dtGridKhoa = new System.Windows.Forms.DataGridView();
            this.btn_themKhoa = new System.Windows.Forms.Button();
            this.btn_suaKhoa = new System.Windows.Forms.Button();
            this.btn_xoaKhoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridKhoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // mask_maKhoa
            // 
            this.mask_maKhoa.Location = new System.Drawing.Point(122, 15);
            this.mask_maKhoa.Name = "mask_maKhoa";
            this.mask_maKhoa.Size = new System.Drawing.Size(230, 22);
            this.mask_maKhoa.TabIndex = 4;
            // 
            // mask_tenKhoa
            // 
            this.mask_tenKhoa.Location = new System.Drawing.Point(122, 69);
            this.mask_tenKhoa.Name = "mask_tenKhoa";
            this.mask_tenKhoa.Size = new System.Drawing.Size(230, 22);
            this.mask_tenKhoa.TabIndex = 5;
            // 
            // mask_sdt
            // 
            this.mask_sdt.Location = new System.Drawing.Point(122, 123);
            this.mask_sdt.Name = "mask_sdt";
            this.mask_sdt.Size = new System.Drawing.Size(230, 22);
            this.mask_sdt.TabIndex = 6;
            // 
            // mask_diaChi
            // 
            this.mask_diaChi.Location = new System.Drawing.Point(122, 179);
            this.mask_diaChi.Name = "mask_diaChi";
            this.mask_diaChi.Size = new System.Drawing.Size(233, 22);
            this.mask_diaChi.TabIndex = 7;
            // 
            // dtGridKhoa
            // 
            this.dtGridKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridKhoa.Location = new System.Drawing.Point(383, 12);
            this.dtGridKhoa.Name = "dtGridKhoa";
            this.dtGridKhoa.RowHeadersWidth = 51;
            this.dtGridKhoa.RowTemplate.Height = 24;
            this.dtGridKhoa.Size = new System.Drawing.Size(619, 330);
            this.dtGridKhoa.TabIndex = 8;
            this.dtGridKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridKhoa_CellClick);
            // 
            // btn_themKhoa
            // 
            this.btn_themKhoa.Location = new System.Drawing.Point(23, 3);
            this.btn_themKhoa.Name = "btn_themKhoa";
            this.btn_themKhoa.Size = new System.Drawing.Size(79, 51);
            this.btn_themKhoa.TabIndex = 10;
            this.btn_themKhoa.Text = "Thêm";
            this.btn_themKhoa.UseVisualStyleBackColor = true;
            this.btn_themKhoa.Click += new System.EventHandler(this.btn_themKhoa_Click);
            // 
            // btn_suaKhoa
            // 
            this.btn_suaKhoa.Location = new System.Drawing.Point(152, 3);
            this.btn_suaKhoa.Name = "btn_suaKhoa";
            this.btn_suaKhoa.Size = new System.Drawing.Size(79, 51);
            this.btn_suaKhoa.TabIndex = 11;
            this.btn_suaKhoa.Text = "Sửa";
            this.btn_suaKhoa.UseVisualStyleBackColor = true;
            this.btn_suaKhoa.Click += new System.EventHandler(this.btn_suaKhoa_Click);
            // 
            // btn_xoaKhoa
            // 
            this.btn_xoaKhoa.Location = new System.Drawing.Point(273, 3);
            this.btn_xoaKhoa.Name = "btn_xoaKhoa";
            this.btn_xoaKhoa.Size = new System.Drawing.Size(79, 51);
            this.btn_xoaKhoa.TabIndex = 12;
            this.btn_xoaKhoa.Text = "Xóa";
            this.btn_xoaKhoa.UseVisualStyleBackColor = true;
            this.btn_xoaKhoa.Click += new System.EventHandler(this.btn_xoaKhoa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tìm kiếm";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(93, 19);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(258, 22);
            this.tb_Search.TabIndex = 18;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mask_maKhoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mask_tenKhoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mask_sdt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mask_diaChi);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 219);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_themKhoa);
            this.panel2.Controls.Add(this.btn_suaKhoa);
            this.panel2.Controls.Add(this.btn_xoaKhoa);
            this.panel2.Location = new System.Drawing.Point(12, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 57);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tb_Search);
            this.panel3.Location = new System.Drawing.Point(13, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 58);
            this.panel3.TabIndex = 21;
            // 
            // QLKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 384);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtGridKhoa);
            this.Name = "QLKhoa";
            this.Text = "QLKhoa";
            this.Load += new System.EventHandler(this.QLKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridKhoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mask_maKhoa;
        private System.Windows.Forms.MaskedTextBox mask_tenKhoa;
        private System.Windows.Forms.MaskedTextBox mask_sdt;
        private System.Windows.Forms.MaskedTextBox mask_diaChi;
        private System.Windows.Forms.DataGridView dtGridKhoa;
        private System.Windows.Forms.Button btn_themKhoa;
        private System.Windows.Forms.Button btn_suaKhoa;
        private System.Windows.Forms.Button btn_xoaKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}