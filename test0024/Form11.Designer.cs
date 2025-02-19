namespace test0024
{
    partial class Form11
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvResult = new DataGridView();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            BtnAdd = new Button();
            btnClear = new Button();
            cboCid = new ComboBox();
            txtPrice = new TextBox();
            txtDes = new TextBox();
            txtPname = new TextBox();
            txtPid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(570, 146);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 28);
            label5.TabIndex = 29;
            label5.Text = "ประเภทสินค้า :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(634, 78);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 28;
            label4.Text = "ราคา :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 141);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 28);
            label3.TabIndex = 27;
            label3.Text = "รายละเอียด :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 81);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 26;
            label2.Text = "ชื่อสินค้า :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 25;
            label1.Text = "รหัสสินค้า :";
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(16, 327);
            dgvResult.Margin = new Padding(4);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(1071, 286);
            dgvResult.TabIndex = 24;
            dgvResult.CellContentClick += dgvResult_CellContentClick;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(948, 194);
            BtnDelete.Margin = new Padding(4);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(98, 74);
            BtnDelete.TabIndex = 23;
            BtnDelete.Text = "ลบ";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(823, 194);
            BtnUpdate.Margin = new Padding(4);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(113, 74);
            BtnUpdate.TabIndex = 22;
            BtnUpdate.Text = "แก้ไข";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(704, 194);
            BtnAdd.Margin = new Padding(4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(111, 74);
            BtnAdd.TabIndex = 21;
            BtnAdd.Text = "เพิ่ม";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(577, 194);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 74);
            btnClear.TabIndex = 20;
            btnClear.Text = "เคลียร์";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cboCid
            // 
            cboCid.FormattingEnabled = true;
            cboCid.Location = new Point(704, 146);
            cboCid.Margin = new Padding(4);
            cboCid.Name = "cboCid";
            cboCid.Size = new Size(342, 36);
            cboCid.TabIndex = 19;
            cboCid.SelectedIndexChanged += cboCid_SelectedIndexChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(704, 78);
            txtPrice.Margin = new Padding(4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(342, 34);
            txtPrice.TabIndex = 18;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(129, 141);
            txtDes.Margin = new Padding(4);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(412, 127);
            txtDes.TabIndex = 17;
            // 
            // txtPname
            // 
            txtPname.Location = new Point(129, 81);
            txtPname.Margin = new Padding(4);
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(412, 34);
            txtPname.TabIndex = 16;
            // 
            // txtPid
            // 
            txtPid.Location = new Point(129, 15);
            txtPid.Margin = new Padding(4);
            txtPid.Name = "txtPid";
            txtPid.ReadOnly = true;
            txtPid.Size = new Size(161, 34);
            txtPid.TabIndex = 15;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvResult);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnAdd);
            Controls.Add(btnClear);
            Controls.Add(cboCid);
            Controls.Add(txtPrice);
            Controls.Add(txtDes);
            Controls.Add(txtPname);
            Controls.Add(txtPid);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form11";
            Text = "Form11";
            WindowState = FormWindowState.Maximized;
            Load += Form11_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvResult;
        private Button BtnDelete;
        private Button BtnUpdate;
        private Button BtnAdd;
        private Button btnClear;
        private ComboBox cboCid;
        private TextBox txtPrice;
        private TextBox txtDes;
        private TextBox txtPname;
        private TextBox txtPid;
    }
}