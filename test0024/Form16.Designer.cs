namespace test0024
{
    partial class Form16
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
            cmb1 = new ComboBox();
            cmb2 = new ComboBox();
            btn_show = new Button();
            dgv1 = new DataGridView();
            dgv2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            SuspendLayout();
            // 
            // cmb1
            // 
            cmb1.FormattingEnabled = true;
            cmb1.Location = new Point(50, 43);
            cmb1.Name = "cmb1";
            cmb1.Size = new Size(235, 28);
            cmb1.TabIndex = 0;
            // 
            // cmb2
            // 
            cmb2.FormattingEnabled = true;
            cmb2.Location = new Point(347, 43);
            cmb2.Name = "cmb2";
            cmb2.Size = new Size(235, 28);
            cmb2.TabIndex = 1;
            // 
            // btn_show
            // 
            btn_show.Location = new Point(604, 43);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(123, 29);
            btn_show.TabIndex = 2;
            btn_show.Text = "button1";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(12, 95);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 51;
            dgv1.Size = new Size(370, 343);
            dgv1.TabIndex = 3;
            dgv1.CellClick += dgv1_CellClick;
            // 
            // dgv2
            // 
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv2.Location = new Point(418, 95);
            dgv2.Name = "dgv2";
            dgv2.RowHeadersWidth = 51;
            dgv2.Size = new Size(370, 343);
            dgv2.TabIndex = 3;
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv2);
            Controls.Add(dgv1);
            Controls.Add(btn_show);
            Controls.Add(cmb2);
            Controls.Add(cmb1);
            Name = "Form16";
            Text = "Form16";
            Load += Form16_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmb1;
        private ComboBox cmb2;
        private Button btn_show;
        private DataGridView dgv1;
        private DataGridView dgv2;
    }
}