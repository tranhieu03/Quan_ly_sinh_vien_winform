using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_2023_c.daLop
{
    class DaLop
    {
       public string counter = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
        public SqlConnection cnn= new SqlConnection();

        public bool ketnoi()
        {
            try
            {
                if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
                cnn.ConnectionString = counter;
                cnn.Open();
            }
            catch
            {
                MessageBox.Show("lỗi kết nối", "thông báo");
                return false;
            }
            return true;
        }
        public DataTable getTable(string tenbang)
        {
            string sql = "Select * from " + tenbang;
            SqlDataAdapter ad = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public DataTable getData(SqlCommand cmd)
        {
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            return tbl;
        }

        public void loadComBoBox(SqlCommand cmd, ComboBox cbb)
        {
            DataTable tbl = getData(cmd);
            cbb.DataSource = tbl;
            cbb.ValueMember = tbl.Columns[0].ColumnName;
            cbb.DisplayMember = tbl.Columns[1].ColumnName;
        }

    }
}
