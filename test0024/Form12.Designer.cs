namespace test0024
{
    partial class Form12
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
            dgvOrderDetail = new DataGridView();
            dgvOrder = new DataGridView();
            cboCountry = new ComboBox();
            cboyear = new ComboBox();
            btn1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(12, 369);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.Size = new Size(776, 69);
            dgvOrderDetail.TabIndex = 12;
            // 
            // dgvOrder
            // 
            dgvOrder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(12, 120);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(776, 213);
            dgvOrder.TabIndex = 11;
            dgvOrder.CellMouseClick += dgvOrder_CellMouseClick;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(114, 53);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(192, 28);
            cboCountry.TabIndex = 13;
            // 
            // cboyear
            // 
            cboyear.FormattingEnabled = true;
            cboyear.Location = new Point(430, 50);
            cboyear.Name = "cboyear";
            cboyear.Size = new Size(203, 28);
            cboyear.TabIndex = 14;
            // 
            // btn1
            // 
            btn1.Location = new Point(677, 52);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 15;
            btn1.Text = "ค้นหา";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 53);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 16;
            label1.Text = "ประเทศที่จัดส่ง";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 56);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 17;
            label2.Text = "ประเทศที่จัดส่ง";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 97);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 18;
            label3.Text = "ข้อมูลใบสั่งซื้อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 336);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 19;
            label4.Text = "ข้อมูลรายการสั่งซื้อ";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn1);
            Controls.Add(cboyear);
            Controls.Add(cboCountry);
            Controls.Add(dgvOrderDetail);
            Controls.Add(dgvOrder);
            Name = "Form12";
            Text = "Form12";
            WindowState = FormWindowState.Maximized;
            Load += Form12_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderDetail;
        private DataGridView dgvOrder;
        private ComboBox cboCountry;
        private ComboBox cboyear;
        private Button btn1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}