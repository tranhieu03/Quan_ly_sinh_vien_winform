
namespace BTL_2023_c
{
    partial class Form2
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
            this.crptHienMonHoc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxMonHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crptHienMonHoc
            // 
            this.crptHienMonHoc.ActiveViewIndex = -1;
            this.crptHienMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptHienMonHoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptHienMonHoc.Location = new System.Drawing.Point(1, 106);
            this.crptHienMonHoc.Name = "crptHienMonHoc";
            this.crptHienMonHoc.Size = new System.Drawing.Size(841, 231);
            this.crptHienMonHoc.TabIndex = 1;
            this.crptHienMonHoc.Load += new System.EventHandler(this.crptHienMonHoc_Load);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "in";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.FormattingEnabled = true;
            this.cbxMonHoc.Location = new System.Drawing.Point(208, 21);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Size = new System.Drawing.Size(121, 28);
            this.cbxMonHoc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Môn học";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(843, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxMonHoc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.crptHienMonHoc);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptBaoCaoMonHoc;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptHienMonHoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbxMonHoc;
        private System.Windows.Forms.Label label1;
    }
}