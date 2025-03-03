namespace test0024
{
    partial class Form15
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
            btn_show = new Button();
            show_Country = new ComboBox();
            show_City = new ComboBox();
            dgv_Category = new DataGridView();
            dgv_Product = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Category).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Product).BeginInit();
            SuspendLayout();
            // 
            // btn_show
            // 
            btn_show.Location = new Point(654, 51);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(134, 29);
            btn_show.TabIndex = 0;
            btn_show.Text = "แสดง";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // show_Country
            // 
            show_Country.FormattingEnabled = true;
            show_Country.Location = new Point(21, 52);
            show_Country.Name = "show_Country";
            show_Country.Size = new Size(273, 28);
            show_Country.TabIndex = 1;
            show_Country.SelectedIndexChanged += show_Country_SelectedIndexChanged;
            // 
            // show_City
            // 
            show_City.FormattingEnabled = true;
            show_City.Location = new Point(337, 51);
            show_City.Name = "show_City";
            show_City.Size = new Size(273, 28);
            show_City.TabIndex = 1;
            // 
            // dgv_Category
            // 
            dgv_Category.AllowUserToAddRows = false;
            dgv_Category.AllowUserToDeleteRows = false;
            dgv_Category.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Category.Location = new Point(21, 98);
            dgv_Category.Name = "dgv_Category";
            dgv_Category.ReadOnly = true;
            dgv_Category.RowHeadersWidth = 51;
            dgv_Category.Size = new Size(1092, 211);
            dgv_Category.TabIndex = 2;
            dgv_Category.CellClick += dgv_Category_CellClick;
            // 
            // dgv_Product
            // 
            dgv_Product.AllowUserToAddRows = false;
            dgv_Product.AllowUserToDeleteRows = false;
            dgv_Product.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Product.Location = new Point(21, 352);
            dgv_Product.Name = "dgv_Product";
            dgv_Product.ReadOnly = true;
            dgv_Product.RowHeadersWidth = 51;
            dgv_Product.Size = new Size(1092, 200);
            dgv_Product.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 3;
            label1.Text = "ประเทศที่ตั้งของลูกค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 28);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 3;
            label2.Text = "เมืองที่ตั้งของลูกค้า";
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 623);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_Product);
            Controls.Add(dgv_Category);
            Controls.Add(show_City);
            Controls.Add(show_Country);
            Controls.Add(btn_show);
            Name = "Form15";
            Text = "Form15";
            Load += Form15_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Category).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_show;
        private ComboBox show_Country;
        private ComboBox show_City;
        private DataGridView dgv_Category;
        private DataGridView dgv_Product;
        private Label label1;
        private Label label2;
    }
}