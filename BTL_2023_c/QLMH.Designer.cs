﻿
namespace BTL_2023_c
{
    partial class QLMH
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
            this.mask_maMH = new System.Windows.Forms.MaskedTextBox();
            this.mask_tenMH = new System.Windows.Forms.MaskedTextBox();
            this.mask_soTC = new System.Windows.Forms.MaskedTextBox();
            this.dtgridMH = new System.Windows.Forms.DataGridView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridMH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tín chỉ";
            // 
            // mask_maMH
            // 
            this.mask_maMH.Location = new System.Drawing.Point(119, 13);
            this.mask_maMH.Name = "mask_maMH";
            this.mask_maMH.Size = new System.Drawing.Size(236, 22);
            this.mask_maMH.TabIndex = 3;
            // 
            // mask_tenMH
            // 
            this.mask_tenMH.Location = new System.Drawing.Point(119, 62);
            this.mask_tenMH.Name = "mask_tenMH";
            this.mask_tenMH.Size = new System.Drawing.Size(236, 22);
            this.mask_tenMH.TabIndex = 4;
            // 
            // mask_soTC
            // 
            this.mask_soTC.Location = new System.Drawing.Point(119, 119);
            this.mask_soTC.Name = "mask_soTC";
            this.mask_soTC.Size = new System.Drawing.Size(236, 22);
            this.mask_soTC.TabIndex = 5;
            // 
            // dtgridMH
            // 
            this.dtgridMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridMH.Location = new System.Drawing.Point(384, 12);
            this.dtgridMH.Name = "dtgridMH";
            this.dtgridMH.RowHeadersWidth = 51;
            this.dtgridMH.RowTemplate.Height = 24;
            this.dtgridMH.Size = new System.Drawing.Size(503, 261);
            this.dtgridMH.TabIndex = 6;
            this.dtgridMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridMH_CellClick);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(89, 9);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(266, 22);
            this.tb_search.TabIndex = 7;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tìm kiếm";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(20, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(81, 48);
            this.btn_Them.TabIndex = 9;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(149, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(81, 48);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(274, 0);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(81, 51);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mask_maMH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mask_tenMH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mask_soTC);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 162);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Them);
            this.panel2.Controls.Add(this.btn_Sua);
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Location = new System.Drawing.Point(12, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 54);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tb_search);
            this.panel3.Location = new System.Drawing.Point(12, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 41);
            this.panel3.TabIndex = 14;
            // 
            // QLMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 301);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgridMH);
            this.Name = "QLMH";
            this.Text = "QLMH";
            this.Load += new System.EventHandler(this.QLMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridMH)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox mask_maMH;
        private System.Windows.Forms.MaskedTextBox mask_tenMH;
        private System.Windows.Forms.MaskedTextBox mask_soTC;
        private System.Windows.Forms.DataGridView dtgridMH;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}