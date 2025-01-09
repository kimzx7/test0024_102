namespace test0024
{
    partial class Form5
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
            label2 = new Label();
            label1 = new Label();
            dgvResult = new DataGridView();
            btnShow = new Button();
            txtEnd = new TextBox();
            txtStart = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 38);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 11;
            label2.Text = "ถึง";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 38);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 10;
            label1.Text = "ราคาต่อหน่อย : จาก";
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(12, 93);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(776, 338);
            dgvResult.TabIndex = 9;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(568, 19);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(158, 59);
            btnShow.TabIndex = 8;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = true;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(372, 35);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(125, 27);
            txtEnd.TabIndex = 7;
            // 
            // txtStart
            // 
            txtStart.Location = new Point(189, 35);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(147, 27);
            txtStart.TabIndex = 6;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvResult);
            Controls.Add(btnShow);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView dgvResult;
        private Button btnShow;
        private TextBox txtEnd;
        private TextBox txtStart;
    }
}