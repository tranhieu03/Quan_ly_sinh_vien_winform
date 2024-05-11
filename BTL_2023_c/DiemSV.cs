using BTL_2023_c.BaoCao;
using CrystalDecisions.CrystalReports.Engine;
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
    public partial class DiemSV : Form
    {
        public DiemSV()
        {
            InitializeComponent();
            hienMaSV();
        }
       /*
        public void sx()
        {
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblCTDiem ORDER BY fDiemTK asc", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_sx");
                        ad.Fill(tb);
                        dataGridDiem.DataSource = tb;

                    }
                }
            }
        }
       */

        // '....'+formula(tonumber(......),0)+'.'
        void hienMaSV()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select *from tblSinhVien", cnn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            cbMasv.Items.Add(rd["sMaSV"].ToString());
                        }
                    }
                }
                cnn.Close();
            }

        }

        private void DiemSV_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("pcThongTinKQHT ", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaSV", cbMasv.Text);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        { 
                            txtHoTen.Text = rd["sTenSV"].ToString();
                            txtNgaySinh.Text = rd["dNgaySinh"].ToString();
                            txtGT.Text = rd["sGT"].ToString();
                            txtLop.Text = rd["sTenLop"].ToString();
                            txtKhoa.Text = rd["sTenKhoa"].ToString();

                        }
                        rd.Close();
                    }
                }
                cnn.Close();
            }

            hienKQHT();
        }
        private void hienKQHT()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_TenMonSoTinchi ", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sv", cbMasv.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        chiTietDiem rpt = new chiTietDiem();
                        rpt.SetDataSource(dt);
                        crtDiemSV.ReportSource = rpt;
                        crtDiemSV.Refresh();
                    }

                }
                cnn.Close();
            }
        }
        private void crtDiemSV_Load(object sender, EventArgs e)
        {
            ReportDocument cry = new ReportDocument();
            cry.Load(@"C:\Users\tranx\Downloads\BTL_HSK\BTL_2023_c\BTL_2023_c\BaoCao\baocaoKetQuaHocTap.rpt");
            crtDiemSV.ReportSource = cry;
            crtDiemSV.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_TenMonSoTinchi ", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sv", cbMasv.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        chiTietDiem rpt = new chiTietDiem();
                        rpt.SetDataSource(dt);
                        crtDiemSV.ReportSource = rpt;
                        crtDiemSV.Refresh();
                    }

                }
                cnn.Close();
            }
        }
    }
}
