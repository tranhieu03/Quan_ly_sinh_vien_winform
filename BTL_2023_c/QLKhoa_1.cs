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
    public partial class QLKhoa : Form
    {
        public QLKhoa()
        {
            InitializeComponent();
        }

        public void laydataGridKhoa()
        {
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT sMaKhoa AS 'Mã khoa' , sTenKhoa AS 'Tên khoa' , sSDT AS 'Số điện thoại' , sDiaChiKhoa AS 'Địa chỉ khoa' FROM vw_dtgridKhoa", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_Khoa");
                        ad.Fill(tb);
                        dtGridKhoa.DataSource = tb;
                    }
                }
            }
        }

        public static void themKhoa(string makhoa, string tenkhoa, string sdt, string diaChi)
        {
            string counter = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string sqlInsert = "INSERT INTO tblKhoa  " +
                "VALUES( '" + makhoa + "' , N'" + tenkhoa + "' , '" + sdt + "' , N'" + diaChi + "' )";
            using (SqlConnection cnn = new SqlConnection(counter))
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, cnn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();

                    cnn.Close();

                }
            }
        }

        public static bool xoaaKhoa(string maKhoa)
        {
            string ctr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string sqlInsert = "DELETE FROM tblKhoa WHERE sMaKhoa = '" + maKhoa + " '  ";
            using (SqlConnection cnn = new SqlConnection(ctr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, cnn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        public static bool suaKhoa(string maKhoa, string tenKhoa)
        {
            string ctr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string sqlInsert = "Update tblKhoa SET sTenKhoa = N'" + tenKhoa + "' WHERE sMaKhoa = '" + maKhoa + "'  ";
            using (SqlConnection cnn = new SqlConnection(ctr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, cnn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }

        }

        private void QLKhoa_Load(object sender, EventArgs e)
        {
            laydataGridKhoa();

        }

        private void btn_xoaKhoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa khoa này ??", "Thông báo ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                xoaaKhoa(Convert.ToString(mask_maKhoa.Text));
                laydataGridKhoa();
            }
            else
                Close();
        }

        private void dtGridKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mask_maKhoa.Text = dtGridKhoa.CurrentRow.Cells["Mã khoa"].Value.ToString();
            mask_tenKhoa.Text = dtGridKhoa.CurrentRow.Cells["Tên khoa"].Value.ToString();
            mask_maKhoa.Enabled = false;
        }

        private void btn_suaKhoa_Click(object sender, EventArgs e)
        {
            suaKhoa(Convert.ToString(mask_maKhoa.Text), Convert.ToString(mask_tenKhoa.Text));
            laydataGridKhoa();
            mask_maKhoa.Enabled = true;
        }

        private void btn_themKhoa_Click(object sender, EventArgs e)
        {
            themKhoa(Convert.ToString(mask_maKhoa.Text), Convert.ToString(mask_tenKhoa.Text), Convert.ToString(mask_sdt.Text), Convert.ToString(mask_diaChi.Text));
            laydataGridKhoa();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
