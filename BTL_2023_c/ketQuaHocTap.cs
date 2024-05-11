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
    public partial class ketQuaHocTap : Form
    {
        private string maSV;
        public ketQuaHocTap()
        {
            InitializeComponent();
        }

        public string MaSV { get => maSV; set => maSV = value; }

        private string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
        private void ketQuaHocTap_Load(object sender, EventArgs e)
        {
            txbMaSV.Text = maSV.ToString();
          using(SqlConnection cnn =  new SqlConnection(constr))
            {
                cnn.Open();
                using(SqlCommand cmd = new SqlCommand("pcThongTinKQHT " , cnn))
                {       
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaSV", txbMaSV.Text);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            txbHoTen.Text = rd["sTenSV"].ToString();
                            txbNgaySinh.Text = rd["dNgaySinh"].ToString();
                            txbGioiTinh.Text = rd["sGT"].ToString();
                            txbLop.Text = rd["sTenLop"].ToString();
                            txbKhoa.Text = rd["sTenKhoa"].ToString();
          
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
            using(SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using(SqlCommand cmd = new SqlCommand("pcKetQuaHocTap ", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaSV", txbMaSV.Text);
                    using(SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        baocaoKetQuaHocTap rpt = new baocaoKetQuaHocTap();
                        rpt.SetDataSource(dt);
                        crtKQHT.ReportSource = rpt;
                        crtKQHT.Refresh();
                    }

                }
                cnn.Close();
            }
        }

        private void crtKQHT_Load(object sender, EventArgs e)
        {
            ReportDocument cry = new ReportDocument();
            cry.Load(@"C:\Users\tranx\Downloads\BTL_HSK\BTL_2023_c\BTL_2023_c\BaoCao\baocaoKetQuaHocTap.rpt");
            crtKQHT.ReportSource = cry;
            crtKQHT.Refresh();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
