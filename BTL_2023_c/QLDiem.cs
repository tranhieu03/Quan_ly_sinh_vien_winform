﻿using System;
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
                using (SqlCommand cmd = new SqlCommand("SELECT sMaSV AS N'Mã sinh viên' , sMaMH AS N'Mã môn học',dNgayHoc AS N'Ngày Học' , fDiemCC AS N'Điểm chuyên cần' " +
                    ", fDiemBK AS N'Điểm giữa kì' , fDiemHK AS N'Điểm cuối kì' , fDiemTK AS N'Điểm tổng kết' FROM vw_dtGridCTDiem", cnn))
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

        public static void themDiem(string maSV, string maMH,string ngayhoc, float diemCC, float diemGK , float diemHK )
        {
            string counter = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string sqlInsert = "INSERT INTO tblCTDiem (sMaSV , sMaMH ,dNgayHoc, fDiemCC , fDiemBK , fDiemHK) " + 
                "VALUES( '" + maSV + "' , '" + maMH + "' , '" + ngayhoc + "' , '" + diemCC + "' , '" + diemGK + "' , '"+ diemHK +"')";
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
     
            if(Convert.ToDouble(mask_diemCC.Text) > 10 || Convert.ToDouble(mask_diemGK.Text) > 10|| Convert.ToDouble(mask_diemCK.Text) > 10 
                 || Convert.ToDouble(mask_diemCC.Text)  < 0 || Convert.ToDouble(mask_diemGK.Text) < 0 || Convert.ToDouble(mask_diemCK.Text) < 0)
            {
                MessageBox.Show("Điểm không hợp lệ!\nVui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                themDiem(Convert.ToString(cb_maSv.Text), Convert.ToString(cb_maMh.Text),
                    Convert.ToString(maskNgayhoc.Text), float.Parse(mask_diemCC.Text),
                    float.Parse(mask_diemGK.Text), float.Parse(mask_diemCK.Text));

                laydataGridDiem();
            }    
           
        }
        private void btn_suaDiem_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(mask_diemCC.Text) > 10 || Convert.ToDouble(mask_diemGK.Text) > 10 || Convert.ToDouble(mask_diemCK.Text) > 10
                 || Convert.ToDouble(mask_diemCC.Text) < 0 || Convert.ToDouble(mask_diemGK.Text) < 0 || Convert.ToDouble(mask_diemCK.Text) < 0)
            {
                MessageBox.Show("Điểm không hợp lệ!\nVui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                suaDiem(Convert.ToString(cb_maSv.Text),Convert.ToString(cb_maMh.Text), float.Parse(mask_diemCC.Text),
                    float.Parse(mask_diemGK.Text),float.Parse(mask_diemCK.Text));
                cb_maSv.Enabled = false;
                cb_maMh.Enabled = false;
                laydataGridDiem();
            }
               
        }
        public static bool suaDiem(string maSV,string maMH, float diemCC,float diemGK,float diemCk)
        {
            
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_suaDiem ", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@masv", maSV);
                    cmd.Parameters.AddWithValue("@mamh", maMH);
                    cmd.Parameters.AddWithValue("@diemcc", diemCC);
                    cmd.Parameters.AddWithValue("@diemgk", diemGK);
                    cmd.Parameters.AddWithValue("@diemhk", diemCk);
                    
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
                
            }

        }

        private void dataGridDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridDiem.CurrentRow.Index;
            cb_maSv.Text = dataGridDiem.Rows[i].Cells[0].Value.ToString();
            cb_maMh.Text= dataGridDiem.Rows[i].Cells[1].Value.ToString();
            maskNgayhoc.Text= dataGridDiem.Rows[i].Cells[2].Value.ToString();
            mask_diemCC.Text = dataGridDiem.Rows[i].Cells[3].Value.ToString();
            mask_diemGK.Text = dataGridDiem.Rows[i].Cells[4].Value.ToString();
            mask_diemCK.Text= dataGridDiem.Rows[i].Cells[5].Value.ToString();
            cb_maSv.Enabled = false;
            cb_maMh.Enabled = true;
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
            string sql = "SELECT * FROM tblCTDiem WHERE CONCAT(sMaSV , sMaMH ) LIKE '%" + x + "%' ";
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
