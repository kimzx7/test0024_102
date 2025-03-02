using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0024
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        public void insertNewProduct()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            SqlCommand cmd = new SqlCommand("insertNewProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pname", txtPname.Text);
            cmd.Parameters.Add("@price", SqlDbType.Money).Value = txtPrice.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void showProduct()
        {
            SqlConnection conn = DBConnect.connectNorthwind();

            string sql = String.Format("Select * From Temp_Product");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProduct.DataSource = dt;
            conn.Close();
            formatdgv();



        }

        public void clearForm()
        {
            txtPname.Clear();
            txtPrice.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            insertNewProduct();
            showProduct();
            clearForm();
            formatdgv();
        }

        public void formatdgv()
        {
            dgvProduct.Columns[2].DefaultCellStyle.Format = "#,##0.00";
            dgvProduct.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvProduct.Columns[0].HeaderText = "รหัสสินค้า";
            dgvProduct.Columns[1].HeaderText = "ชื่อสินค้า";
            dgvProduct.Columns[2].HeaderText = "ราคาต่อหน่วย";
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            showProduct();
            formatdgv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}



