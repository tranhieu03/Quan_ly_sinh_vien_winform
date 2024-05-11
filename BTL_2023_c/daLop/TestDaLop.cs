using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_2023_c.daLop
{
    public partial class TestDaLop : Form
    {
        public TestDaLop()
        {
            InitializeComponent();
        }
        private void TestDaLop_Load(object sender, EventArgs e)
        {
            DaLop D = new DaLop();
            D.ketnoi();
            DataTable bangSV = D.getTable("tblSinhVien");

            
            dataGridView1.DataSource = bangSV;
            comboBox1.DataSource = bangSV;
            comboBox1.DisplayMember = bangSV.Columns[1].ColumnName;
            comboBox1.ValueMember = bangSV.Columns[0].ColumnName;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
