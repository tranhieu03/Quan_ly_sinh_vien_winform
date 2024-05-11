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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private string ctr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
        
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbUserName.Text) || string.IsNullOrEmpty(txbPassWord.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin",
                         "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(ctr))
                {
                    string sqlSelect = "Select * from username where sTenTK = '" + txbUserName.Text + "' and sMK = '" + txbPassWord.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(sqlSelect, cnn))
                    {
                        cnn.Open();
                        //cmd.CommandType = CommandType.Text;
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                Form1 f = new Form1();
                                f.TenTK = txbUserName.Text;
                                this.Hide();
                                f.ShowDialog();
                                this.Show();   
                            }
                            else
                            {
                                MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác !",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        cnn.Close();
                        txbUserName.Clear();
                        txbPassWord.Clear();
                    }
                }
            }
           
        }

        private void lbDangKi_Click(object sender, EventArgs e)
        {
            dangKi f = new dangKi();
            this.Hide();
            f.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
