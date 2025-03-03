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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        private void LoadComboBoxes()
        {
            // Load Category Names into cmb1
            string queryCategories = "SELECT CategoryName FROM Categories";
            using (SqlConnection conn = DBConnect.connectNorthwind())
            {
                SqlCommand cmd = new SqlCommand(queryCategories, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmb1.Items.Add(reader["CategoryName"].ToString());
                }
            }

            // Load Years (1996, 1997, 1998) into cmb2
            cmb2.Items.Add("1996");
            cmb2.Items.Add("1997");
            cmb2.Items.Add("1998");
        }

        private void LoadSalesData()
        {
            string categoryName = cmb1.SelectedItem.ToString();
            int orderYear = int.Parse(cmb2.SelectedItem.ToString());

            // Call Stored Procedure to fetch data
            using (SqlConnection conn = DBConnect.connectNorthwind())
            {
                SqlCommand cmd = new SqlCommand("GetEmployeeSalesByCategoryAndYear", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parameters for Stored Procedure
                cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                cmd.Parameters.AddWithValue("@OrderYear", orderYear);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                // Bind data to DataGridView
                dgv1.DataSource = dt;
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (cmb1.SelectedItem != null && cmb2.SelectedItem != null)
            {
                LoadSalesData();
            }
            else
            {
                MessageBox.Show("Please select both Category and Year.");
            }
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            //LoadSalesData();
            LoadComboBoxes();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ตรวจสอบว่าไม่ใช่ header
            {
                // ดึงข้อมูล EmployeeID จากแถวที่คลิก
                int employeeID = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["EmployeeID"].Value);

                // ดึงข้อมูล CategoryName และ OrderYear จาก ComboBox
                string categoryName = cmb1.SelectedItem.ToString();
                int orderYear = int.Parse(cmb2.SelectedItem.ToString());

                // เรียกใช้ฟังก์ชันเพื่อดึงข้อมูลจาก stored procedure
                LoadProductSalesData(employeeID, categoryName, orderYear);
            }
        }

        private void LoadProductSalesData(int employeeID, string categoryName, int orderYear)
        {
            // ใช้ stored procedure เพื่อนำข้อมูลสินค้าและยอดขาย
            using (SqlConnection conn = DBConnect.connectNorthwind())
            {
                SqlCommand cmd = new SqlCommand("GetEmployeeProductSales", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // เพิ่มพารามิเตอร์
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                cmd.Parameters.AddWithValue("@OrderYear", orderYear);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                // แสดงข้อมูลใน dgv2
                dgv2.DataSource = dt;
            }
        }
    }
}
