namespace test0024
{
    partial class Form9
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
            dgvDetail = new DataGridView();
            DgvOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvDetail
            // 
            dgvDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Location = new Point(12, 321);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.RowHeadersWidth = 51;
            dgvDetail.Size = new Size(776, 110);
            dgvDetail.TabIndex = 5;
            // 
            // DgvOrder
            // 
            DgvOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvOrder.Location = new Point(12, 20);
            DgvOrder.Name = "DgvOrder";
            DgvOrder.RowHeadersWidth = 51;
            DgvOrder.Size = new Size(776, 272);
            DgvOrder.TabIndex = 4;
            DgvOrder.CellMouseClick += DgvOrder_CellMouseClick;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDetail);
            Controls.Add(DgvOrder);
            Name = "Form9";
            Text = "Form9";
            WindowState = FormWindowState.Maximized;
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDetail;
        private DataGridView DgvOrder;
    }
}