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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { workshopToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // workshopToolStripMenuItem
            // 
            workshopToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { w1ToolStripMenuItem, w3ToolStripMenuItem, w45ToolStripMenuItem, toolStripMenuItem2 });
            workshopToolStripMenuItem.Name = "workshopToolStripMenuItem";
            workshopToolStripMenuItem.Size = new Size(89, 24);
            workshopToolStripMenuItem.Text = "Workshop";
            // 
            // w1ToolStripMenuItem
            // 
            w1ToolStripMenuItem.Name = "w1ToolStripMenuItem";
            w1ToolStripMenuItem.Size = new Size(224, 26);
            w1ToolStripMenuItem.Text = "w1-2";
            w1ToolStripMenuItem.Click += w1ToolStripMenuItem_Click;
            // 
            // w3ToolStripMenuItem
            // 
            w3ToolStripMenuItem.Name = "w3ToolStripMenuItem";
            w3ToolStripMenuItem.Size = new Size(224, 26);
            w3ToolStripMenuItem.Text = "w3";
            w3ToolStripMenuItem.Click += w3ToolStripMenuItem_Click;
            // 
            // w45ToolStripMenuItem
            // 
            w45ToolStripMenuItem.Name = "w45ToolStripMenuItem";
            w45ToolStripMenuItem.Size = new Size(224, 26);
            w45ToolStripMenuItem.Text = "w4-5";
            w45ToolStripMenuItem.Click += w45ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(224, 26);
            toolStripMenuItem2.Text = "w6";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
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
    }
}