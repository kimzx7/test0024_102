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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        public void ShowProducts()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            String sql = "Select * From Products";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvResult.DataSource = dt;
            //dgvResult.Columns[2].Visible = false;
            dgvResult.Columns[4].Visible = false;
        }

        private void ClearForm()
        {
            txtPid.Clear();
            txtPname.Clear();
            txtDes.Clear();
            txtPrice.Clear();
            cboCid.SelectedIndex = 0;
        }

        private void ShowCategory()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            String sql = "Select categoryID , categoryName From Categories";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboCid.DataSource = dt;
            cboCid.ValueMember = "CategoryID";
            cboCid.DisplayMember = "CategoryName";
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            ShowProducts();
            ShowCategory();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0) return;

            txtPid.Text = dgvResult.Rows[row].Cells[0].Value.ToString();
            txtPname.Text = dgvResult.Rows[row].Cells[1].Value.ToString();
            txtDes.Text = dgvResult.Rows[row].Cells[2].Value.ToString();
            txtPrice.Text = dgvResult.Rows[row].Cells[3].Value.ToString();

            // กำหนดค่าให้ cboCid.SelectedValue ตาม CategoryID
            if (dgvResult.Rows[row].Cells[4].Value != DBNull.Value)
            {
                cboCid.SelectedValue = dgvResult.Rows[row].Cells[4].Value;
            }
        }
        public void InsertProduct()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sql = "INSERT INTO Products (ProductName, detail, unitprice, categoryID) " + "VALUES (@p_name, @p_des, @p_price, @c_id)";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@p_name", txtPname.Text);
            com.Parameters.AddWithValue("@p_des", txtDes.Text);
            com.Parameters.Add("@p_price", SqlDbType.Money).Value = txtPrice.Text;
            com.Parameters.Add("@c_id", SqlDbType.Int).Value = cboCid.SelectedValue;
            com.ExecuteNonQuery();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            InsertProduct();
            ShowProducts();
            ClearForm();
        }

        private void UpdateProduct(int p_id)
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            String sql = "Update Products Set ProductName = @p_name, detail = @p_des, unitprice = @p_price, categoryID = @c_id Where ProductID = @p_id";
            SqlCommand com = new SqlCommand(sql, conn);
            decimal unitPrice = decimal.Parse(txtPrice.Text);
            int categoryId = Convert.ToInt32(cboCid.SelectedValue);

            com.Parameters.AddWithValue("@p_name", txtPname.Text);
            com.Parameters.AddWithValue("@p_des", txtDes.Text);
            com.Parameters.Add("@p_price", SqlDbType.Money).Value = unitPrice;
            com.Parameters.Add("@c_id", SqlDbType.Int).Value = categoryId;
            com.Parameters.Add("@p_id", SqlDbType.Int).Value = p_id;

            com.ExecuteNonQuery();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPid.Text.Equals(""))
            {
                return;
            }
            int p_id = Convert.ToInt32(txtPid.Text);
            UpdateProduct(p_id);
            ShowProducts();
            ClearForm();
        }
        private void DeleteProduct(int p_id)
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            String sql = "Delete From Products Where ProductID = @p_id";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@p_id", p_id);
            com.ExecuteNonQuery();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtPid.Text.Equals(""))
            {
                return;
            }
            if (MessageBox.Show("คุณแน่ใจต้องการลบสินค้านี้ใช่หรือไม่", "ยืนยันการทำงาน", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            int p_id = Convert.ToInt32(txtPid.Text);
            DeleteProduct(p_id);
            ShowProducts();
            ClearForm();
        }

        private void cboCid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
