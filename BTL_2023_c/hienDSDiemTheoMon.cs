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
    public partial class hienDSDiemTheoMon : Form
    {
        public hienDSDiemTheoMon()
        {
            InitializeComponent();
            hienTenMonHoc();
        }

        void hienTenMonHoc()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select *from tblMonHoc", cnn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            cbxMonHoc.Items.Add(rd["sTenMH"].ToString());
                        }
                    }
                }
                cnn.Close();
            }    

        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using(SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("pcBangDiemTheoMon ", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fDiemA", txbDiemA.Text);
                    cmd.Parameters.AddWithValue("@fDiemB", txbDiemB.Text);
                    cmd.Parameters.AddWithValue("@sMonHoc", cbxMonHoc.Text);
                    using(SqlDataAdapter ad= new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable data = new DataTable();
                        ad.Fill(data);
                        bangDiemTheoMon rpt = new bangDiemTheoMon();
                        rpt.SetDataSource(data);
                        crtHienDSDiemTheoMon.ReportSource = rpt;
                        crtHienDSDiemTheoMon.Refresh();
                    }
                }
            }
        }

        private void crtHienDSDiemTheoMon_Load(object sender, EventArgs e)
        {
            ReportDocument cry = new ReportDocument();
            cry.Load(@"C:\Users\tranx\Downloads\BTL_HSK\BTL_2023_c\BTL_2023_c\BaoCao\bangDiemTheoMon.rpt");
            crtHienDSDiemTheoMon.ReportSource = cry;
            crtHienDSDiemTheoMon.Refresh();
        }

        private void hienDSDiemTheoMon_Load(object sender, EventArgs e)
        {

        }
    }
}
