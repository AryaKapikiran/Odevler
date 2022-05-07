namespace UI_Hamburger
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hamburgerMenuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hamburgerMenuEkleToolStripMenuItem,
            this.ekstraEkleToolStripMenuItem,
            this.siparisVerToolStripMenuItem,
            this.raporlaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1325, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hamburgerMenuEkleToolStripMenuItem
            // 
            this.hamburgerMenuEkleToolStripMenuItem.Name = "hamburgerMenuEkleToolStripMenuItem";
            this.hamburgerMenuEkleToolStripMenuItem.Size = new System.Drawing.Size(202, 30);
            this.hamburgerMenuEkleToolStripMenuItem.Text = "HamburgerMenuCrud";
            this.hamburgerMenuEkleToolStripMenuItem.Click += new System.EventHandler(this.hamburgerMenuEkleToolStripMenuItem_Click);
            // 
            // ekstraEkleToolStripMenuItem
            // 
            this.ekstraEkleToolStripMenuItem.Name = "ekstraEkleToolStripMenuItem";
            this.ekstraEkleToolStripMenuItem.Size = new System.Drawing.Size(113, 30);
            this.ekstraEkleToolStripMenuItem.Text = "EkstraCrud";
            this.ekstraEkleToolStripMenuItem.Click += new System.EventHandler(this.ekstraEkleToolStripMenuItem_Click);
            // 
            // siparisVerToolStripMenuItem
            // 
            this.siparisVerToolStripMenuItem.Name = "siparisVerToolStripMenuItem";
            this.siparisVerToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.siparisVerToolStripMenuItem.Text = "SiparisVer";
            this.siparisVerToolStripMenuItem.Click += new System.EventHandler(this.siparisVerToolStripMenuItem_Click);
            // 
            // raporlaToolStripMenuItem
            // 
            this.raporlaToolStripMenuItem.Name = "raporlaToolStripMenuItem";
            this.raporlaToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.raporlaToolStripMenuItem.Text = "Raporla";
            this.raporlaToolStripMenuItem.Click += new System.EventHandler(this.raporlaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 748);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hamburgerMenuEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekstraEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlaToolStripMenuItem;
    }
}

