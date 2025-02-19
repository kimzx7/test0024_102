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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            showEmployee();
            showShipCountry();
            showOrders();
        }

        public void showEmployee()
        {
            SqlConnection conn = DBConnect.connectNorthwind();

            string sqlEmp = "select EmployeeID, (TitleOfCourtesy+FirstName+SPACE(2)+LastName) AS EmployeeName from Employees";

            SqlDataAdapter da = new SqlDataAdapter(sqlEmp, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboEmployee.DataSource = dt;
            cboEmployee.ValueMember = "EmployeeID";
            cboEmployee.DisplayMember = "EmployeeName";

            conn.Close();
        }
        public void showShipCountry()
        {
            SqlConnection conn = DBConnect.connectNorthwind();

            string sqlEmp = "SELECT ShipCountry FROM Orders GROUP BY ShipCountry ORDER BY ShipCountry ASC;";

            SqlDataAdapter da = new SqlDataAdapter(sqlEmp, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboCountry.DataSource = dt;
            cboCountry.ValueMember = "ShipCountry";
            cboCountry.DisplayMember = "ShipCountry";

            conn.Close();
        }
        public void showOrders(int EmployeeID, string country)
        {
            SqlConnection conn = DBConnect.connectNorthwind();

            string sqlOrder = string.Format("Select * From Orders Where EmployeeID = {0} AND ShipCountry = '{1}'", EmployeeID, country);

            SqlDataAdapter da = new SqlDataAdapter(sqlOrder, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvOrder.DataSource = dt;
            conn.Close();
        }
        public void showOrders()
        {
            SqlConnection conn = DBConnect.connectNorthwind();

            string sqlOrder = string.Format("Select * From Orders");

            SqlDataAdapter da = new SqlDataAdapter(sqlOrder, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvOrder.DataSource = dt;
            conn.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt32(cboEmployee.SelectedValue);
            string country = cboCountry.SelectedValue.ToString();

            showOrders(employeeID, country);
        }

        public void showOD(int OrderID)
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sqlDetails = String.Format("Select * From Ordes_view1 where OrderID = {0}", OrderID);

            SqlDataAdapter da = new SqlDataAdapter(sqlDetails, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvDetail.DataSource = dt;
            conn.Close();
        }

        private void dgvOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int r = e.RowIndex;
            int OrderID = Convert.ToInt32(dgvOrder.Rows[r].Cells[0].Value);
            showOD(OrderID);
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
