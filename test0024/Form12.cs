using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace test0024
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            showCountry();
            showYear();
            showOrder();
        }

        public void showCountry()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sqlDetails = String.Format("Select Distinct Shipcountry From Orders Order By ShipCountry ASC");

            SqlDataAdapter da = new SqlDataAdapter(sqlDetails, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboCountry.DataSource = dt;
            cboCountry.DisplayMember = "Shipcountry";
            cboCountry.ValueMember = "shipcountry";

            conn.Close();
        }

        public void showYear()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sqlDetails = String.Format("Select Distinct YEAR(OrderDate) As YearOrder From Orders Order By YEAR(OrderDate) ASC");

            SqlDataAdapter da = new SqlDataAdapter(sqlDetails, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboyear.DataSource = dt;
            cboyear.DisplayMember = "YearOrder";
            cboyear.ValueMember = "YearOrder";

            conn.Close();
        }

        public void showOrder()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sqlDetails = String.Format("Select * From Temp_order_view");

            SqlDataAdapter da = new SqlDataAdapter(sqlDetails, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvOrder.DataSource = dt;
            conn.Close();
        }

        public void showOrder(string country, int year)
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sqlDetails = String.Format("Select * From Temp_order_view Where Shipcountry = '{0}' AND YEAR(OrderDate) = '{1}' ", country, year);

            SqlDataAdapter da = new SqlDataAdapter(sqlDetails, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvOrder.DataSource = dt;
            conn.Close();
        }

        public void show_OD(int OrderID)
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sqlDetails = String.Format("Select * From Ordes_view1 Where orderID = '{0}'", OrderID);

            SqlDataAdapter da = new SqlDataAdapter(sqlDetails, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvOrderDetail.DataSource = dt;
            conn.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //string country = cboCountry.Text;
            string country = cboCountry.SelectedValue.ToString();
            int year = Convert.ToInt32(cboyear.SelectedValue);

            showOrder(country, year);
        }

        private void dgvOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int r = e.RowIndex;
            int OrderID = Convert.ToInt32(dgvOrder.Rows[r].Cells[0].Value);
            show_OD(OrderID);
        }
    }
}
