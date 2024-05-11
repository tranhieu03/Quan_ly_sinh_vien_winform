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
    public partial class QLDiem : Form
    {
        public QLDiem()
        {
            InitializeComponent();
        }

        private void QLDiem_Load(object sender, EventArgs e)
        {
            laydataGridDiem();
            layMonHoc();
            laySinhVien();

        }


        public void laydataGridDiem()
        {
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT sMaSV AS N'Mã sinh viên' , sMaMH AS N'Mã môn học' , fDiemCC AS N'Điểm chuyên cần' " +
                    ", fDiemBK AS N'Điểm giữa kì' , fDiemHK AS N'Điểm cuối kì' , sTrangThai AS N'Trạng Thái' , fDiemTK AS N'Điểm tổng kết' FROM vw_dtgridDiem", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_Diem");
                        ad.Fill(tb);
                        dataGridDiem.DataSource = tb;
                    }
                }
            }
        }

        public static void themDiem(string maSV, string maMH, float diemCC, float diemGK , float diemHK )
        {
            string counter = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string sqlInsert = "INSERT INTO tblDiem (sMaSV , sMaMH , fDiemCC , fDiemBK , fDiemHK) " +
                "VALUES( '" + maSV + "' , '" + maMH + "' , " + diemCC + " , " + diemGK + " , "+ diemHK +")";
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

        private void btn_themDiem_Click(object sender, EventArgs e)
        {
            themDiem(Convert.ToString(cb_maSv.Text), Convert.ToString(cb_maMh.Text), float.Parse(mask_diemCC.Text), float.Parse(mask_diemGK.Text), float.Parse(mask_diemCK.Text));
            laydataGridDiem();
        }

        private void btn_suaDiem_Click(object sender, EventArgs e)
        {
            suaDiem(Convert.ToString(cb_maSv.Text), float.Parse(mask_diemCC.Text));
            cb_maSv.Enabled = true;
            cb_maMh.Enabled = true;
        }


        public static bool suaDiem(string maSV, float diemCC)
        {
            string ctr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string sqlInsert = "Update tblDiem SET fDiemCC = " + diemCC + "WHERE sMaSV = '" + maSV + "'  ";
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

        private void dataGridDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_maSv.Text = dataGridDiem.CurrentRow.Cells["Mã sinh Viên"].Value.ToString();
            mask_diemCC.Text = dataGridDiem.CurrentRow.Cells["Điểm chuyên cần"].Value.ToString();
            cb_maMh.Text = dataGridDiem.CurrentRow.Cells["Mã môn học"].Value.ToString();
            cb_maSv.Enabled = false;
            cb_maMh.Enabled = false;
        }



        private void laySinhVien()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblSinhVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SinhVien");
                        ad.Fill(tb);
                        cb_maSv.DataSource = tb;
                        cb_maSv.DisplayMember = "sMaSV";
                        cb_maSv.ValueMember = "sTenSV";
                    }
                }
            }
        }

        public static bool xoaaDiem(string maSV , string maMH , float fDiemCC)
        {
            string ctr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string sqlInsert = "DELETE FROM tblDiem WHERE sMaSV = '" + maSV + "' AND sMaMH = '" + maMH + "' AND fDiemCC = " + fDiemCC;
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

        private void layMonHoc()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblMonHoc", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("MonHoc");
                        ad.Fill(tb);
                        cb_maMh.DataSource = tb;
                        cb_maMh.DisplayMember = "sMaMH";
                        cb_maMh.ValueMember = "sTenMH";
                    }
                }
            }
        }

        private void btn_xoaDiem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa điểm này ??", "Thông báo ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                xoaaDiem(Convert.ToString(cb_maSv.Text) , Convert.ToString(cb_maMh.Text) , float.Parse(mask_diemCC.Text));
                laydataGridDiem();
            }
            else
                Close();
        }

        

        

        public static bool spThem(string counter, int maSv, string hoTen, string ngaySinh, string gt)
        {
            using (SqlConnection cnn = new SqlConnection(counter))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "pr_themSua";
                    cmd.Parameters.AddWithValue("@maSv", maSv);
                    cmd.Parameters.AddWithValue("@hoTen", hoTen);
                    cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@gioiTinh", gt);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;

                }
            }

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            search_textbox(tb_search.Text);
        }

        private void search_textbox(string x)
        {
            string sql = "SELECT * FROM tblDiem WHERE CONCAT(sMaSV , sMaMH ) LIKE '%" + x + "%' OR sTrangThai LIKE '%" + x + "%'";
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_Diem");
                        ad.Fill(tb);
                        dataGridDiem.DataSource = tb;
                    }
                }
            }
        }
    }
}
