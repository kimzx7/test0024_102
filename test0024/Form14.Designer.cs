namespace test0024
{
    partial class Form14
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            txtFirstname = new TextBox();
            txtPassword = new TextBox();
            txtCfPassword = new TextBox();
            cboPosition = new ComboBox();
            txtLastname = new TextBox();
            lbEmailErr = new Label();
            lbPwdErr = new Label();
            lbMsg = new Label();
            btnSave = new Button();
            btnClear = new Button();
            lbCfPwdErr = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(62, 27);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "อีเมล์";
            txtEmail.Size = new Size(372, 34);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(62, 79);
            txtFirstname.Multiline = true;
            txtFirstname.Name = "txtFirstname";
            txtFirstname.PlaceholderText = "ชื่อ";
            txtFirstname.Size = new Size(372, 34);
            txtFirstname.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(62, 236);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "รหัสผ่าน";
            txtPassword.Size = new Size(372, 34);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtCfPassword
            // 
            txtCfPassword.Location = new Point(62, 293);
            txtCfPassword.Multiline = true;
            txtCfPassword.Name = "txtCfPassword";
            txtCfPassword.PasswordChar = '*';
            txtCfPassword.PlaceholderText = "ยืนยันรหัสผ่าน";
            txtCfPassword.Size = new Size(372, 34);
            txtCfPassword.TabIndex = 1;
            txtCfPassword.TextChanged += txtCfPassword_TextChanged;
            // 
            // cboPosition
            // 
            cboPosition.FormattingEnabled = true;
            cboPosition.Location = new Point(62, 190);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(372, 28);
            cboPosition.TabIndex = 2;
            cboPosition.Text = "กรุณาเลือกตำแหน่ง";
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(62, 134);
            txtLastname.Multiline = true;
            txtLastname.Name = "txtLastname";
            txtLastname.PlaceholderText = "นามสกุล";
            txtLastname.Size = new Size(372, 34);
            txtLastname.TabIndex = 1;
            // 
            // lbEmailErr
            // 
            lbEmailErr.AutoSize = true;
            lbEmailErr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmailErr.ForeColor = Color.Red;
            lbEmailErr.Location = new Point(440, 30);
            lbEmailErr.Name = "lbEmailErr";
            lbEmailErr.Size = new Size(20, 28);
            lbEmailErr.TabIndex = 4;
            lbEmailErr.Text = "*";
            // 
            // lbPwdErr
            // 
            lbPwdErr.AutoSize = true;
            lbPwdErr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPwdErr.ForeColor = Color.Red;
            lbPwdErr.Location = new Point(440, 242);
            lbPwdErr.Name = "lbPwdErr";
            lbPwdErr.Size = new Size(20, 28);
            lbPwdErr.TabIndex = 4;
            lbPwdErr.Text = "*";
            // 
            // lbMsg
            // 
            lbMsg.AutoSize = true;
            lbMsg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMsg.ForeColor = Color.DarkGreen;
            lbMsg.Location = new Point(62, 358);
            lbMsg.Name = "lbMsg";
            lbMsg.Size = new Size(20, 28);
            lbMsg.TabIndex = 4;
            lbMsg.Text = "*";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(410, 346);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 65);
            btnSave.TabIndex = 3;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(588, 346);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 65);
            btnClear.TabIndex = 3;
            btnClear.Text = "เคลียร์";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lbCfPwdErr
            // 
            lbCfPwdErr.AutoSize = true;
            lbCfPwdErr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCfPwdErr.ForeColor = Color.Red;
            lbCfPwdErr.Location = new Point(440, 299);
            lbCfPwdErr.Name = "lbCfPwdErr";
            lbCfPwdErr.Size = new Size(20, 28);
            lbCfPwdErr.TabIndex = 4;
            lbCfPwdErr.Text = "*";
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbMsg);
            Controls.Add(lbCfPwdErr);
            Controls.Add(lbPwdErr);
            Controls.Add(lbEmailErr);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(cboPosition);
            Controls.Add(txtCfPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(txtEmail);
            Name = "Form14";
            Text = "Form14";
            WindowState = FormWindowState.Maximized;
            Load += Form14_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtFirstname;
        private TextBox txtPassword;
        private TextBox txtCfPassword;
        private ComboBox cboPosition;
        private TextBox txtLastname;
        private Label lbEmailErr;
        private Label lbPwdErr;
        private Label lbMsg;
        private Button btnSave;
        private Button btnClear;
        private Label lbCfPwdErr;
    }
}