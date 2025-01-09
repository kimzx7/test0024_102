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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        public void showO()
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            string sqlDetails = "Select * From Orders";

            SqlDataAdapter da = new SqlDataAdapter(sqlDetails, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            DgvOrder.DataSource = dt;
            conn.Close();
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

        private void DgvOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int r = e.RowIndex;
            int OrderID = Convert.ToInt32(DgvOrder.Rows[r].Cells[0].Value);
            showOD(OrderID);
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            showO();
        }
    }
}
