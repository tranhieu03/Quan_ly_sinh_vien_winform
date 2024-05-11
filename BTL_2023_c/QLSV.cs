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
    public partial class QLSV : Form
    {

        public QLSV()
        {
            InitializeComponent();
        }
        private void QLSV_Load(object sender, EventArgs e)
        {
            laydataGrid();
            layLop();
            
            cbxXem.Items.Add("Hiện danh sách sinh viên theo môn học");
            cbxXem.Items.Add("Kết quả học tập");
        }


        public static void themSv(string masv, string hoten, string ngaysinh, string gt , string quequan , string malop)
        {
            string counter = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string sqlInsert = "INSERT INTO tblSinhVien (sMaSv , sTenSV, sGT , sQueQuan , dNgaysinh , sMalop) " +
                "VALUES( '" + masv + "' , N'" + hoten + "' , N'" + gt + "' , N'" + quequan + "' , '"+ ngaysinh +"','"+ malop +"')";
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

        public void laydataGrid()
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
                        dtGridSV.DataSource = tb;
                    }
                }
            }
        }

        

        public static bool suaSv(string masv, string hoten)
        {
            string ctr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string sqlInsert = "Update tblSinhVien SET sTenSV = N'" + hoten + "' WHERE sMaSV = '" + masv + "'  ";
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

        public static bool xoaaSv(String masv)
        {
            string ctr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string sqlInsert = "DELETE FROM tblSinhVien WHERE sMaSV = '" + masv + " '  ";
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(mask_maSV.Text))
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                themSv(Convert.ToString(mask_maSV.Text), Convert.ToString(mask_tenSv.Text), Convert.ToString(mask_ngaySinh.Text), Convert.ToString(mask_GT.Text), Convert.ToString(mask_queQuan.Text), Convert.ToString(combo_malop.Text));
                laydataGrid();
            }          
        }
        private void dtGridSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtGridSV.CurrentRow.Index;
            mask_maSV.Text = dtGridSV.Rows[i].Cells[0].Value.ToString();
            mask_tenSv.Text = dtGridSV.Rows[i].Cells[1].Value.ToString();
            mask_GT.Text = dtGridSV.Rows[i].Cells[2].Value.ToString();
            
            mask_ngaySinh.Text=dtGridSV.Rows[i].Cells[4].Value.ToString();
            mask_queQuan.Text= dtGridSV.Rows[i].Cells[3].Value.ToString();
            
            mask_maSV.Enabled = true;
        }

        private void layLop()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblLop", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("Lop");
                        ad.Fill(tb);
                        combo_malop.DataSource = tb;
                        combo_malop.DisplayMember = "sMaLop";
                        combo_malop.ValueMember = "sTenLop";
                    }
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mask_maSV.Text))
            {
                MessageBox.Show("Bạn cần nhập mã sinh viên cần xóa",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sinh viên này ??", "Thông báo ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    xoaaSv(Convert.ToString(mask_maSV.Text));
                    laydataGrid();
                }
                else
                    Close();
            }   
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
           
            
            if (string.IsNullOrEmpty(mask_maSV.Text))
            {
                MessageBox.Show("Bạn cần nhập mã sinh viên cần sửa",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                suaSv(Convert.ToString(mask_maSV.Text), Convert.ToString(mask_tenSv.Text));
                laydataGrid();
                mask_maSV.Enabled = true;
            }    
            
        }

        private void search_textbox(string x)
        {
            string sql = "SELECT * FROM tblSinhVien WHERE CONCAT(sTenSV,sGT  ) LIKE '%" + x + "%'";
            //string sql = "SELECT * FROM tblSinhVien WHERE CONCAT(sMaSV , sTenSV ) LIKE '%" + x + "%'";
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_SinhVien");
                        ad.Fill(tb);
                        dtGridSV.DataSource = tb;
                    }
                }
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            search_textbox(tb_Search.Text);
        }
        private void btnChon_Click_1(object sender, EventArgs e)
        {
            if (cbxXem.SelectedIndex == 0)
            {
                hienDSDiemTheoMon f = new hienDSDiemTheoMon();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if(cbxXem.SelectedIndex == 1)
            {
                if (!string.IsNullOrEmpty(mask_maSV.Text))
                {
                    ketQuaHocTap f = new ketQuaHocTap();
                    f.MaSV = mask_maSV.Text;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("Mã sinh viên để trống\n Không thể xem!!!", 
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //throw new Exception("Bạn lựa chọn chưa chính xác");
                MessageBox.Show("Lựa chọn chưa chính xác để xem", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mask_ngaySinh_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
