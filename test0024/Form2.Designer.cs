namespace test0024
{
    partial class Form2
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
            txtStart = new TextBox();
            txtEnd = new TextBox();
            btnShow = new Button();
            dgvResult = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // txtStart
            // 
            txtStart.Location = new Point(172, 27);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(182, 27);
            txtStart.TabIndex = 2;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(172, 85);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(182, 27);
            txtEnd.TabIndex = 3;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(422, 27);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(183, 90);
            btnShow.TabIndex = 4;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(34, 158);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(695, 280);
            dgvResult.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TH Krub", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 24);
            label3.Name = "label3";
            label3.Size = new Size(132, 30);
            label3.TabIndex = 6;
            label3.Text = "ราคาเริ่มต้น";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH Krub", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 82);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 7;
            label1.Text = "ถึงราคา";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dgvResult);
            Controls.Add(btnShow);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Name = "Form2";
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtStart;
        private TextBox txtEnd;
        private Button btnShow;
        private DataGridView dgvResult;
        private Label label3;
        private Label label1;
    }
}