namespace Menustrip
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nUMEROPRIMOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Primo = new System.Windows.Forms.ToolStripMenuItem();
            this.nUMEROPERFECTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERIEFIBONACCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUMEROPRIMOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nUMEROPRIMOToolStripMenuItem
            // 
            this.nUMEROPRIMOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Primo,
            this.nUMEROPERFECTOToolStripMenuItem,
            this.sERIEFIBONACCIToolStripMenuItem});
            this.nUMEROPRIMOToolStripMenuItem.Name = "nUMEROPRIMOToolStripMenuItem";
            this.nUMEROPRIMOToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.nUMEROPRIMOToolStripMenuItem.Text = "FORMULARIOS";
            this.nUMEROPRIMOToolStripMenuItem.Click += new System.EventHandler(this.nUMEROPRIMOToolStripMenuItem_Click);
            // 
            // Primo
            // 
            this.Primo.Name = "Primo";
            this.Primo.Size = new System.Drawing.Size(182, 22);
            this.Primo.Text = "CAMPOS";
            this.Primo.Click += new System.EventHandler(this.nUMEROPRIMOToolStripMenuItem1_Click);
            // 
            // nUMEROPERFECTOToolStripMenuItem
            // 
            this.nUMEROPERFECTOToolStripMenuItem.Name = "nUMEROPERFECTOToolStripMenuItem";
            this.nUMEROPERFECTOToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.nUMEROPERFECTOToolStripMenuItem.Text = "CONVERTIDOR DE DIVISAS";
            this.nUMEROPERFECTOToolStripMenuItem.Click += new System.EventHandler(this.nUMEROPERFECTOToolStripMenuItem_Click);
            // 
            // sERIEFIBONACCIToolStripMenuItem
            // 
            this.sERIEFIBONACCIToolStripMenuItem.Name = "sERIEFIBONACCIToolStripMenuItem";
            this.sERIEFIBONACCIToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.sERIEFIBONACCIToolStripMenuItem.Text = "SERIE FIBONACCI";
            this.sERIEFIBONACCIToolStripMenuItem.Click += new System.EventHandler(this.sERIEFIBONACCIToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(762, 559);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "CONTROL MENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nUMEROPRIMOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Primo;
        private System.Windows.Forms.ToolStripMenuItem nUMEROPERFECTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERIEFIBONACCIToolStripMenuItem;
    }
}

