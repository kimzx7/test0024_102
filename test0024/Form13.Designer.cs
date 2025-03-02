namespace test0024
{
    partial class Form13
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
            txtPname = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnadd = new Button();
            dgvProduct = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // txtPname
            // 
            txtPname.Location = new Point(374, 62);
            txtPname.Multiline = true;
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(314, 38);
            txtPname.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(374, 141);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(314, 38);
            txtPrice.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 62);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 2;
            label1.Text = "ชื่อสินค้า :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 144);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 3;
            label2.Text = "ราคาต่อหน่วย :";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(730, 89);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(136, 60);
            btnadd.TabIndex = 4;
            btnadd.Text = "เพิ่มข้อมูล";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(12, 211);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(1076, 295);
            dgvProduct.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(885, 89);
            button1.Name = "button1";
            button1.Size = new Size(136, 60);
            button1.TabIndex = 4;
            button1.Text = "ล้างข้อมูล";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(dgvProduct);
            Controls.Add(button1);
            Controls.Add(btnadd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtPname);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form13";
            Text = "Form13";
            WindowState = FormWindowState.Maximized;
            Load += Form13_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPname;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private Button btnadd;
        private DataGridView dgvProduct;
        private Button button1;
    }
}