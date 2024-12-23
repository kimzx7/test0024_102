using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0024
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnect.connectNorthwind();

            string startPrice = txtStart.Text;
            string endPrice = txtEnd.Text;

            string qyery = string.Format("Select * From Products Where UnitPrice Between {0} And {1}", startPrice,endPrice);

            SqlDataAdapter da = new SqlDataAdapter(qyery,conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;

            conn.Close();
        }
    }
}
