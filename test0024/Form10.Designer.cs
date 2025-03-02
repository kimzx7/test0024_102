namespace test0024
{
    partial class Form10
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
            btnShow = new Button();
            cboCountry = new ComboBox();
            cboEmployee = new ComboBox();
            dgvDetail = new DataGridView();
            dgvOrder = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // btnShow
            // 
            btnShow.Location = new Point(633, 21);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(125, 48);
            btnShow.TabIndex = 13;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(407, 32);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(192, 28);
            cboCountry.TabIndex = 12;
            // 
            // cboEmployee
            // 
            cboEmployee.FormattingEnabled = true;
            cboEmployee.Location = new Point(103, 32);
            cboEmployee.Name = "cboEmployee";
            cboEmployee.Size = new Size(199, 28);
            cboEmployee.TabIndex = 11;
            // 
            // dgvDetail
            // 
            dgvDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Location = new Point(12, 309);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.RowHeadersWidth = 51;
            dgvDetail.Size = new Size(776, 110);
            dgvDetail.TabIndex = 10;
            // 
            // dgvOrder
            // 
            dgvOrder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(12, 101);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(776, 179);
            dgvOrder.TabIndex = 9;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick;
            dgvOrder.CellMouseClick += dgvOrder_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 35);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 14;
            label1.Text = "ชื่อพนักงาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 35);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 14;
            label2.Text = "ประเทศ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 76);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 15;
            label3.Text = "ใบสั่งซื้อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 286);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 15;
            label4.Text = "รายการสั่งซื้อ";
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnShow);
            Controls.Add(cboCountry);
            Controls.Add(cboEmployee);
            Controls.Add(dgvDetail);
            Controls.Add(dgvOrder);
            Name = "Form10";
            Text = "Form10";
            WindowState = FormWindowState.Maximized;
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShow;
        private ComboBox cboCountry;
        private ComboBox cboEmployee;
        private DataGridView dgvDetail;
        private DataGridView dgvOrder;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}