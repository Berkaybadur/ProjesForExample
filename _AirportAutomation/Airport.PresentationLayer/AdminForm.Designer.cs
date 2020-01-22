namespace Airport.PresentationLayer
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.havaalanıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uçakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.destekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destekToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // havaalanıToolStripMenuItem
            // 
            this.havaalanıToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("havaalanıToolStripMenuItem.Image")));
            this.havaalanıToolStripMenuItem.Name = "havaalanıToolStripMenuItem";
            this.havaalanıToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.havaalanıToolStripMenuItem.Text = "Personel";
            // 
            // uçakToolStripMenuItem
            // 
            this.uçakToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uçakToolStripMenuItem.Image")));
            this.uçakToolStripMenuItem.Name = "uçakToolStripMenuItem";
            this.uçakToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.uçakToolStripMenuItem.Text = "Uçak";
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kullanıcıToolStripMenuItem.Image")));
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaShell;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.destekToolStripMenuItem,
            this.havaalanıToolStripMenuItem,
            this.uçakToolStripMenuItem,
            this.kullanıcıToolStripMenuItem,
            this.seferlerToolStripMenuItem,
            this.biletToolStripMenuItem,
            this.toolStripMenuItem1,
            this.destekToolStripMenuItem1,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // destekToolStripMenuItem
            // 
            this.destekToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("destekToolStripMenuItem.Image")));
            this.destekToolStripMenuItem.Name = "destekToolStripMenuItem";
            this.destekToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.destekToolStripMenuItem.Text = "Panel";
            // 
            // seferlerToolStripMenuItem
            // 
            this.seferlerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seferlerToolStripMenuItem.Image")));
            this.seferlerToolStripMenuItem.Name = "seferlerToolStripMenuItem";
            this.seferlerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.seferlerToolStripMenuItem.Text = "Seferler";
            // 
            // biletToolStripMenuItem
            // 
            this.biletToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("biletToolStripMenuItem.Image")));
            this.biletToolStripMenuItem.Name = "biletToolStripMenuItem";
            this.biletToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.biletToolStripMenuItem.Text = "Bilet";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // destekToolStripMenuItem1
            // 
            this.destekToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("destekToolStripMenuItem1.Image")));
            this.destekToolStripMenuItem1.Name = "destekToolStripMenuItem1";
            this.destekToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.destekToolStripMenuItem1.Text = "Destek";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(838, 546);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem havaalanıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uçakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seferlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem destekToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}