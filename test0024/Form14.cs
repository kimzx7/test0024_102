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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test0024
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        public void clearFrom()//ฟังก์ชันเคลียร์ข้อมูล
        {
            txtEmail.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            cboPosition.Text = "กรุณาเลือกตำแหน่ง";
            txtPassword.Clear();
            txtCfPassword.Clear();
            lbEmailErr.Text = "*";
            lbPwdErr.Text = "*";
            lbCfPwdErr.Text = "*";
        }

        public void setcbo()//ฟังก์ชันsetข้อมูลในcomboBox
        {
            cboPosition.Items.Add("Software Engineer");
            cboPosition.Items.Add("Data Scientist");
            cboPosition.Items.Add("Cybersecurity Analyst");
            cboPosition.Items.Add("Cloud Engineer");
            cboPosition.Items.Add("AI/ML Engineer");
            cboPosition.Items.Add("DevOps Engineer ");
            cboPosition.Items.Add("Database Administrator");
        }
        public int add_NewUser()
        {
            SqlConnection conn = DBConnect.connectDBExample();

            SqlCommand cmd = new SqlCommand("AddUser_Transaction", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@userID", SqlDbType.NVarChar).Value = txtEmail.Text;
            cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
            cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@position", cboPosition.Text);

            SqlParameter result = new SqlParameter("@Result", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            cmd.Parameters.Add(result);
            cmd.ExecuteNonQuery();
            conn.Close();

            return Convert.ToInt32(result.Value);

        }
        public int checkIputForm()
        {
            int Status = 0;

            if (txtEmail.Text == "" || txtEmail.Text == null)
            {
                lbEmailErr.Text = "กรุณากรอก Email";
                txtEmail.Focus();
                Status = -1;
            }
            else
            {
                lbEmailErr.Text = "*";
                Status = 0;
            }


            if (txtPassword.Text == "" || txtPassword.Text == null)
            {
                lbCfPwdErr.Text = "กรุณากรอก รหัสผ่าน";
                txtCfPassword.Focus();
                Status = -1;
            }
            else
            {
                lbPwdErr.Text = "*";
                Status = 0;
            }



            if (!txtCfPassword.Text.Equals(txtPassword.Text))
            {
                lbCfPwdErr.Text = "รหัสผ่านไม่ตรงกัน";
                txtCfPassword.Focus();
                Status = -1;
            }
            else if (txtCfPassword.Text == "" || txtCfPassword.Text == null)
            {
                lbPwdErr.Text = "กรุณากรอก ยืนยันรหัสผ่าน";
                txtCfPassword.Focus();
                Status = -1;
            }
            else
            {
                lbCfPwdErr.Text = "*";
                Status = 0;
            }

            return Status;
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            setcbo();
            lbMsg.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFrom();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkIputForm() == -1) return;

            if (add_NewUser() == 0)
            {
                lbEmailErr.Text = "Email มีคนใช้แล้ว";
                txtEmail.Focus();
                txtEmail.SelectAll();
                lbMsg.Visible = false;
            }
            else
            {
                lbMsg.Text = "เพิ่มข้อมูลเรียบร้อย";
                lbMsg.Visible = true;
                clearFrom();
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            

            //if(txtEmail.Text == "")
            //{
            //    lbEmailErr.Visible = true;
            //}
            //else
            //{
            //    lbEmailErr.Visible = false;
            //}
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            

            //if (txtPassword.Text == "")
            //{
            //    lbEmailErr.Visible = true;
            //}
            //else
            //{
            //    lbPwdErr.Visible = false;


            //}
        }

        private void txtCfPassword_TextChanged(object sender, EventArgs e)
        {
            

            //if (txtCfPassword.Text == "")
            //{
            //    lbEmailErr.Visible = true;
            //}
            //else
            //{
            //    lbCfPwdErr.Visible = false;
            //}
        }
    }
}
