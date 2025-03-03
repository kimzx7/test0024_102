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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        // ฟังก์ชันในการโหลดประเทศทั้งหมดจากฐานข้อมูล
        private void LoadCountries()
        {
            // เชื่อมต่อกับฐานข้อมูล
            SqlConnection conn = DBConnect.connectNorthwind();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT Country FROM Customers", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // เติมข้อมูลใน ComboBox ชื่อ show_Country
            show_Country.DisplayMember = "Country";
            show_Country.ValueMember = "Country";
            show_Country.DataSource = dt;

            // ปิดการเชื่อมต่อ
            conn.Close();
        }

        // ฟังก์ชันในการโหลดเมืองที่เกี่ยวข้องกับประเทศที่เลือก
        private void LoadCities(string country)
        {
            // เชื่อมต่อกับฐานข้อมูล
            SqlConnection conn = DBConnect.connectNorthwind();
            SqlCommand cmd = new SqlCommand("Ps_show_City", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Country_ps", country);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // เติมข้อมูลใน ComboBox ชื่อ show_City
            show_City.DisplayMember = "City";
            show_City.ValueMember = "City";
            show_City.DataSource = dt;

            // ปิดการเชื่อมต่อ
            conn.Close();
        }

        // ฟังก์ชันนี้ไม่ได้ใช้งาน
        public void show_City2()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            SqlCommand cmd = new SqlCommand("Ps_show_City", conn);
            cmd.CommandType = CommandType.StoredProcedure;
        }

        // เมื่อมีการเลือกประเทศจาก ComboBox show_Country
        private void show_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีการเลือกประเทศที่ถูกต้องหรือไม่
            if (show_Country.SelectedValue != null)
            {
                string selectedCountry = show_Country.SelectedValue.ToString();
                LoadCities(selectedCountry); // โหลดเมืองที่เกี่ยวข้องกับประเทศที่เลือก
            }
        }

        // เมื่อฟอร์มถูกโหลดให้เรียกฟังก์ชัน LoadCountries เพื่อโหลดประเทศ
        private void Form15_Load(object sender, EventArgs e)
        {
            LoadCountries(); // โหลดข้อมูลประเทศเมื่อฟอร์มโหลด
        }

        // เมื่อคลิกที่ปุ่ม btn_show ให้แสดงข้อมูลใน DataGridView dgv_Category
        private void btn_show_Click(object sender, EventArgs e)
        {
            // ดึงข้อมูลประเทศและเมืองที่ผู้ใช้เลือก
            string selectedCountry = show_Country.SelectedValue.ToString();
            string selectedCity = show_City.SelectedValue.ToString();

            // เชื่อมต่อกับฐานข้อมูลและเรียกใช้ Stored Procedure Ps_show_Data_Customers
            SqlConnection conn = DBConnect.connectNorthwind();
            SqlCommand cmd = new SqlCommand("Ps_show_Data_Customers", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Country_ps", selectedCountry);
            cmd.Parameters.AddWithValue("@City_ps", selectedCity);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // แสดงข้อมูลใน DataGridView ชื่อ dgv_Category
            dgv_Category.DataSource = dt;

            // ปิดการเชื่อมต่อ
            conn.Close();
        }

        // เมื่อคลิกที่แถวใน dgv_Category ให้แสดงข้อมูลสินค้าใน dgv_Product
        private void dgv_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // ตรวจสอบว่าเป็นการคลิกที่แถวที่ถูกต้อง
            if (e.RowIndex >= 0)
            {
                // ดึงค่า CategoryID จากแถวที่เลือก
                int selectedCategoryID = Convert.ToInt32(dgv_Category.Rows[e.RowIndex].Cells["CategoryID"].Value);

                // ดึงข้อมูลประเทศและเมืองที่ผู้ใช้เลือกจาก ComboBox
                string selectedCountry = show_Country.SelectedValue.ToString();
                string selectedCity = show_City.SelectedValue.ToString();

                // เรียกใช้ Stored Procedure Ps_show_Data_Products เพื่อดึงข้อมูลสินค้า
                SqlConnection conn = DBConnect.connectNorthwind();
                SqlCommand cmd = new SqlCommand("Ps_show_Data_Products", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_ID", selectedCategoryID);
                cmd.Parameters.AddWithValue("@Country_ps", selectedCountry);
                cmd.Parameters.AddWithValue("@City_ps", selectedCity);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // แสดงข้อมูลที่ได้จาก Stored Procedure ใน DataGridView dgv_Product
                dgv_Product.DataSource = dt;

                // ปิดการเชื่อมต่อ
                conn.Close();
            }
        }
    }
}
