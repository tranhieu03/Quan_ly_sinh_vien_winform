
namespace BTL_2023_c
{
    partial class QLDiem
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
            this.mask_diemCC = new System.Windows.Forms.MaskedTextBox();
            this.mask_diemGK = new System.Windows.Forms.MaskedTextBox();
            this.mask_diemCK = new System.Windows.Forms.MaskedTextBox();
            this.dataGridDiem = new System.Windows.Forms.DataGridView();
            this.btn_themDiem = new System.Windows.Forms.Button();
            this.btn_suaDiem = new System.Windows.Forms.Button();
            this.btn_xoaDiem = new System.Windows.Forms.Button();
            this.cb_maSv = new System.Windows.Forms.ComboBox();
            this.cb_maMh = new System.Windows.Forms.ComboBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm chuyên cần";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm giữa kì";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm cuối kì";
            // 
            // mask_diemCC
            // 
            this.mask_diemCC.Location = new System.Drawing.Point(212, 179);
            this.mask_diemCC.Name = "mask_diemCC";
            this.mask_diemCC.Size = new System.Drawing.Size(185, 22);
            this.mask_diemCC.TabIndex = 8;
            // 
            // mask_diemGK
            // 
            this.mask_diemGK.Location = new System.Drawing.Point(212, 237);
            this.mask_diemGK.Name = "mask_diemGK";
            this.mask_diemGK.Size = new System.Drawing.Size(185, 22);
            this.mask_diemGK.TabIndex = 9;
            // 
            // mask_diemCK
            // 
            this.mask_diemCK.Location = new System.Drawing.Point(212, 300);
            this.mask_diemCK.Name = "mask_diemCK";
            this.mask_diemCK.Size = new System.Drawing.Size(185, 22);
            this.mask_diemCK.TabIndex = 10;
            // 
            // dataGridDiem
            // 
            this.dataGridDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDiem.Location = new System.Drawing.Point(486, 48);
            this.dataGridDiem.Name = "dataGridDiem";
            this.dataGridDiem.RowHeadersWidth = 51;
            this.dataGridDiem.RowTemplate.Height = 24;
            this.dataGridDiem.Size = new System.Drawing.Size(810, 274);
            this.dataGridDiem.TabIndex = 12;
            this.dataGridDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDiem_CellClick);
            // 
            // btn_themDiem
            // 
            this.btn_themDiem.Location = new System.Drawing.Point(269, 399);
            this.btn_themDiem.Name = "btn_themDiem";
            this.btn_themDiem.Size = new System.Drawing.Size(79, 30);
            this.btn_themDiem.TabIndex = 13;
            this.btn_themDiem.Text = "Thêm";
            this.btn_themDiem.UseVisualStyleBackColor = true;
            this.btn_themDiem.Click += new System.EventHandler(this.btn_themDiem_Click);
            // 
            // btn_suaDiem
            // 
            this.btn_suaDiem.Location = new System.Drawing.Point(602, 399);
            this.btn_suaDiem.Name = "btn_suaDiem";
            this.btn_suaDiem.Size = new System.Drawing.Size(79, 30);
            this.btn_suaDiem.TabIndex = 14;
            this.btn_suaDiem.Text = "Sửa";
            this.btn_suaDiem.UseVisualStyleBackColor = true;
            this.btn_suaDiem.Click += new System.EventHandler(this.btn_suaDiem_Click);
            // 
            // btn_xoaDiem
            // 
            this.btn_xoaDiem.Location = new System.Drawing.Point(934, 399);
            this.btn_xoaDiem.Name = "btn_xoaDiem";
            this.btn_xoaDiem.Size = new System.Drawing.Size(79, 30);
            this.btn_xoaDiem.TabIndex = 15;
            this.btn_xoaDiem.Text = "Xóa";
            this.btn_xoaDiem.UseVisualStyleBackColor = true;
            this.btn_xoaDiem.Click += new System.EventHandler(this.btn_xoaDiem_Click);
            // 
            // cb_maSv
            // 
            this.cb_maSv.FormattingEnabled = true;
            this.cb_maSv.Location = new System.Drawing.Point(212, 48);
            this.cb_maSv.Name = "cb_maSv";
            this.cb_maSv.Size = new System.Drawing.Size(185, 24);
            this.cb_maSv.TabIndex = 16;
            // 
            // cb_maMh
            // 
            this.cb_maMh.FormattingEnabled = true;
            this.cb_maMh.Location = new System.Drawing.Point(212, 116);
            this.cb_maMh.Name = "cb_maMh";
            this.cb_maMh.Size = new System.Drawing.Size(185, 24);
            this.cb_maMh.TabIndex = 17;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(574, 344);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(722, 22);
            this.tb_search.TabIndex = 18;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tìm kiếm";
            // 
            // QLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.cb_maMh);
            this.Controls.Add(this.cb_maSv);
            this.Controls.Add(this.btn_xoaDiem);
            this.Controls.Add(this.btn_suaDiem);
            this.Controls.Add(this.btn_themDiem);
            this.Controls.Add(this.dataGridDiem);
            this.Controls.Add(this.mask_diemCK);
            this.Controls.Add(this.mask_diemGK);
            this.Controls.Add(this.mask_diemCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "QLDiem";
            this.Load += new System.EventHandler(this.QLDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mask_diemCC;
        private System.Windows.Forms.MaskedTextBox mask_diemGK;
        private System.Windows.Forms.MaskedTextBox mask_diemCK;
        private System.Windows.Forms.DataGridView dataGridDiem;
        private System.Windows.Forms.Button btn_themDiem;
        private System.Windows.Forms.Button btn_suaDiem;
        private System.Windows.Forms.Button btn_xoaDiem;
        private System.Windows.Forms.ComboBox cb_maSv;
        private System.Windows.Forms.ComboBox cb_maMh;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label6;
    }
}