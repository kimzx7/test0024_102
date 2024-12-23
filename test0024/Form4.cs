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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void showCountry()
        {
            SqlConnection conn = DBConnect.connectNorthwind();

            string query = "Select CategoryID, CategoryName From Categories Order By CategoryName ASC";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "------ แสดงทั้งหมด ------";
            dt.Rows.InsertAt(row, 0);

            cboCountry.DataSource = dt;
            cboCountry.ValueMember = "CategoryID";
            cboCountry.DisplayMember = "CategoryName";

            conn.Close();
        }
        public void showProducts(int cid)
        {
            SqlConnection conn = DBConnect.connectNorthwind();

            //string country = cboCountry.SelectedValue.ToString();

            string query = string.Format("Select * From Products Where CategoryID = '{0}'", cid);

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;
            conn.Close();
        }

        public void showProducts()
        {
            SqlConnection conn = DBConnect.connectNorthwind();


            string query = string.Format("Select * From Products");

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;
            conn.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            showCountry();
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCountry.SelectedIndex == 0)
            {
                showProducts();
            }
            else
            {
                int cid = cboCountry.SelectedIndex;
                showProducts(cid);
            }
        }
    }
}
