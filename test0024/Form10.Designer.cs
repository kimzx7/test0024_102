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
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // btnShow
            // 
            btnShow.Location = new Point(668, 31);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 13;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = true;
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
            cboEmployee.Location = new Point(97, 32);
            cboEmployee.Name = "cboEmployee";
            cboEmployee.Size = new Size(199, 28);
            cboEmployee.TabIndex = 11;
            // 
            // dgvDetail
            // 
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Location = new Point(12, 309);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.RowHeadersWidth = 51;
            dgvDetail.Size = new Size(776, 110);
            dgvDetail.TabIndex = 10;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(12, 101);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(776, 179);
            dgvOrder.TabIndex = 9;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShow);
            Controls.Add(cboCountry);
            Controls.Add(cboEmployee);
            Controls.Add(dgvDetail);
            Controls.Add(dgvOrder);
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnShow;
        private ComboBox cboCountry;
        private ComboBox cboEmployee;
        private DataGridView dgvDetail;
        private DataGridView dgvOrder;
    }
}