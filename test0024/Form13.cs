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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        //public void insertNewProduct()
        //{
        //    SqlConnection conn = DBConnect.connectNorthwind();
        //    SqlCommand cmd = new SqlCommand("inserNewProduct" , conn);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@pnaem",txtPname.Text);
        //    cmd.Parameters.Add("@price", sqlDbType.Monet).Value = txtPname.Text;

        //    cmd.ExecuteNonQuery();
        //}
        //public void showProduct() 
        //{
        //    SqlConnection conn = DBConnect.connectNorthwind();

        //    string sql = string.Format("select * from temp_Product");

        //    SqlDataAdapter da = new SqlDataAdapter(sqlDetails, conn);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);



        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
