using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using System.Configuration;
using BTL_2023_c.dataset;
using BTL_2023_c.BaoCao;

namespace BTL_2023_c
{
    public partial class Form2 : Form
    {
        public Form2()
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

        private void crptHienMonHoc_Load(object sender, EventArgs e)
        {
            /*
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "select * from tblMonHoc";
                SqlDataAdapter da = new SqlDataAdapter(sql,constr);
                DataSet1 da1 = new DataSet1();
                DataTable dt = new DataTable();
                da.Fill(da1,"MonHoc");
                monHoc crt = new monHoc();
                crt.SetDataSource(da1.Tables[1]);
                crptHienMonHoc.ReportSource = crt;
                crptHienMonHoc.Refresh();
            }
            */
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "select * from tblMonHoc where sSoTC = 3";
                SqlDataAdapter da = new SqlDataAdapter(sql, constr);
                DataSet1 da1 = new DataSet1();
                DataTable dt = new DataTable();
                da.Fill(da1, "MonHoc");
                monHoc crt = new monHoc();
                crt.SetDataSource(da1.Tables[1]);
                crptHienMonHoc.ReportSource = crt;
                crptHienMonHoc.Refresh();
            }
            */
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("pcBangDiemTheoMon2 ", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMonHoc", cbxMonHoc.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable data = new DataTable();
                        ad.Fill(data);
                        bangDiemTheoMon rpt = new bangDiemTheoMon();
                        rpt.SetDataSource(data);
                        crptHienMonHoc.ReportSource = rpt;
                        crptHienMonHoc.Refresh();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

