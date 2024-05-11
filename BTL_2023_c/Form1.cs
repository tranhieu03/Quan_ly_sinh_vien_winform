using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_2023_c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public static string tenTK;
        public static string loaiTK;
       /* public void laydataGrid()
        {
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT sMaSV 'Mã sinh viên' ,sTenSV 'Tên sinh viên' , sGT 'Giới tính' , sQueQuan 'Quê quán' ," +
                    "dNgaySinh AS 'Ngày sinh' , sMaLop AS 'Mã lớp'   FROM vw_dtgridSV", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_SV");
                        ad.Fill(tb);
                        dataGridView1.DataSource = tb;
                    }
                }
            }

        }*/
        public string TenTK { get => tenTK; set => tenTK = value; }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình ??", "Thông báo ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLSV qlsv = new QLSV();
            qlsv.MdiParent = this;
            qlsv.Show();
           
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLLop qll = new QLLop();
            qll.MdiParent = this;
            qll.Show();
       
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKhoa qlk = new QLKhoa();
            qlk.MdiParent = this;
            qlk.Show();
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLDiem qld = new QLDiem();
            qld.MdiParent = this;
            qld.Show();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLMH qlmh = new QLMH();
            qlmh.MdiParent = this;
            qlmh.Show();
        }

        private void đăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangKi f = new dangKi();
            f.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoiMK f = new fDoiMK();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
            if (tenTK.Equals("dv"))
            {
                quảnLýKhoaToolStripMenuItem.Visible = true;
            }
            else
            {
                quảnLýKhoaToolStripMenuItem.Visible = false;
            }
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
