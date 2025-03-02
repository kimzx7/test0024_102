namespace test0024
{
    partial class main
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
            menuStrip1 = new MenuStrip();
            workshopToolStripMenuItem = new ToolStripMenuItem();
            w1ToolStripMenuItem = new ToolStripMenuItem();
            w3ToolStripMenuItem = new ToolStripMenuItem();
            w45ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            จดการขอมลToolStripMenuItem = new ToolStripMenuItem();
            worksohopVimeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            workshoptestToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { workshopToolStripMenuItem, จดการขอมลToolStripMenuItem, worksohopVimeToolStripMenuItem, workshoptestToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // workshopToolStripMenuItem
            // 
            workshopToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { w1ToolStripMenuItem, w3ToolStripMenuItem, w45ToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            workshopToolStripMenuItem.Name = "workshopToolStripMenuItem";
            workshopToolStripMenuItem.Size = new Size(89, 24);
            workshopToolStripMenuItem.Text = "Workshop";
            // 
            // w1ToolStripMenuItem
            // 
            w1ToolStripMenuItem.Name = "w1ToolStripMenuItem";
            w1ToolStripMenuItem.Size = new Size(114, 26);
            w1ToolStripMenuItem.Text = "1-2";
            w1ToolStripMenuItem.Click += w1ToolStripMenuItem_Click;
            // 
            // w3ToolStripMenuItem
            // 
            w3ToolStripMenuItem.Name = "w3ToolStripMenuItem";
            w3ToolStripMenuItem.Size = new Size(114, 26);
            w3ToolStripMenuItem.Text = "3";
            w3ToolStripMenuItem.Click += w3ToolStripMenuItem_Click;
            // 
            // w45ToolStripMenuItem
            // 
            w45ToolStripMenuItem.Name = "w45ToolStripMenuItem";
            w45ToolStripMenuItem.Size = new Size(114, 26);
            w45ToolStripMenuItem.Text = "4-5";
            w45ToolStripMenuItem.Click += w45ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(114, 26);
            toolStripMenuItem2.Text = "6";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(114, 26);
            toolStripMenuItem3.Text = "2.6";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(114, 26);
            toolStripMenuItem4.Text = "2.7";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // จดการขอมลToolStripMenuItem
            // 
            จดการขอมลToolStripMenuItem.Name = "จดการขอมลToolStripMenuItem";
            จดการขอมลToolStripMenuItem.Size = new Size(95, 24);
            จดการขอมลToolStripMenuItem.Text = "จัดการข้อมูล";
            จดการขอมลToolStripMenuItem.Click += จดการขอมลToolStripMenuItem_Click;
            // 
            // worksohopVimeToolStripMenuItem
            // 
            worksohopVimeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem5 });
            worksohopVimeToolStripMenuItem.Name = "worksohopVimeToolStripMenuItem";
            worksohopVimeToolStripMenuItem.Size = new Size(136, 24);
            worksohopVimeToolStripMenuItem.Text = "Worksohop_View";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(224, 26);
            toolStripMenuItem5.Text = "1";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // workshoptestToolStripMenuItem
            // 
            workshoptestToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem6, toolStripMenuItem7 });
            workshoptestToolStripMenuItem.Name = "workshoptestToolStripMenuItem";
            workshoptestToolStripMenuItem.Size = new Size(130, 24);
            workshoptestToolStripMenuItem.Text = "Workshop_Store";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(224, 26);
            toolStripMenuItem6.Text = "1";
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(224, 26);
            toolStripMenuItem7.Text = "2";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "main";
            Text = "main";
            WindowState = FormWindowState.Maximized;
            Load += main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem workshopToolStripMenuItem;
        private ToolStripMenuItem w1ToolStripMenuItem;
        private ToolStripMenuItem w3ToolStripMenuItem;
        private ToolStripMenuItem w45ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem จดการขอมลToolStripMenuItem;
        private ToolStripMenuItem worksohopVimeToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem workshoptestToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
    }
}