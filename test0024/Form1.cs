using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace test0024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnect.connectNorthwind();
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("เชื่อมต่อฐานข้อมูลได้");

            }
            conn.Close();
        }

    }

    internal class DBConnect
    {
        public static SqlConnection connectNorthwind()
        {
            string server = "LAPTOP-H29QM8LM\\SQLEXPRESS";//server ของตัวเอง
            string db = "Northwind";

            string strCon = string.Format(@"Data source={0}; Initial Catalog={1}; Integrated Security=True; Encrypt= False;", server, db);

            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();

            return conn;
        }
    }
}
