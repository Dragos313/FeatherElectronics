namespace FeatherElectronics
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoriiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vanzareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RaportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaUtilizatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adiministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vanzatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DespreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vanzareToolStripMenuItem1,
            this.produsToolStripMenuItem,
            this.categoriiToolStripMenuItem,
            this.adaugaUtilizatorToolStripMenuItem,
            this.DespreToolStripMenuItem1,
            this.iesireToolStripMenuItem,
            this.RaportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoriiToolStripMenuItem
            // 
            this.categoriiToolStripMenuItem.Name = "categoriiToolStripMenuItem";
            this.categoriiToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.categoriiToolStripMenuItem.Text = "Categorii";
            this.categoriiToolStripMenuItem.Click += new System.EventHandler(this.categoriiToolStripMenuItem_Click);
            // 
            // produsToolStripMenuItem
            // 
            this.produsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaProdusToolStripMenuItem});
            this.produsToolStripMenuItem.Name = "produsToolStripMenuItem";
            this.produsToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.produsToolStripMenuItem.Text = "Produs";
            this.produsToolStripMenuItem.Click += new System.EventHandler(this.produsToolStripMenuItem_Click);
            // 
            // adaugaProdusToolStripMenuItem
            // 
            this.adaugaProdusToolStripMenuItem.Name = "adaugaProdusToolStripMenuItem";
            this.adaugaProdusToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.adaugaProdusToolStripMenuItem.Text = "Adauga Produs";
            this.adaugaProdusToolStripMenuItem.Click += new System.EventHandler(this.adaugaProdusToolStripMenuItem_Click);
            // 
            // vanzareToolStripMenuItem1
            // 
            this.vanzareToolStripMenuItem1.Name = "vanzareToolStripMenuItem1";
            this.vanzareToolStripMenuItem1.Size = new System.Drawing.Size(97, 29);
            this.vanzareToolStripMenuItem1.Text = "Vanzare";
            this.vanzareToolStripMenuItem1.Click += new System.EventHandler(this.vanzareToolStripMenuItem1_Click);
            // 
            // RaportToolStripMenuItem
            // 
            this.RaportToolStripMenuItem.Name = "RaportToolStripMenuItem";
            this.RaportToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.RaportToolStripMenuItem.Text = "Raport";
            this.RaportToolStripMenuItem.Visible = false;
            this.RaportToolStripMenuItem.Click += new System.EventHandler(this.RaportToolStripMenuItem_Click);
            // 
            // adaugaUtilizatorToolStripMenuItem
            // 
            this.adaugaUtilizatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adiministratorToolStripMenuItem,
            this.vanzatorToolStripMenuItem});
            this.adaugaUtilizatorToolStripMenuItem.Name = "adaugaUtilizatorToolStripMenuItem";
            this.adaugaUtilizatorToolStripMenuItem.Size = new System.Drawing.Size(182, 29);
            this.adaugaUtilizatorToolStripMenuItem.Text = "Adauga Utilizator";
            this.adaugaUtilizatorToolStripMenuItem.Click += new System.EventHandler(this.adaugaUtilizatorToolStripMenuItem_Click);
            // 
            // adiministratorToolStripMenuItem
            // 
            this.adiministratorToolStripMenuItem.Name = "adiministratorToolStripMenuItem";
            this.adiministratorToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.adiministratorToolStripMenuItem.Text = "Administrator";
            this.adiministratorToolStripMenuItem.Click += new System.EventHandler(this.adiministratorToolStripMenuItem_Click);
            // 
            // vanzatorToolStripMenuItem
            // 
            this.vanzatorToolStripMenuItem.Name = "vanzatorToolStripMenuItem";
            this.vanzatorToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.vanzatorToolStripMenuItem.Text = "Vanzator";
            this.vanzatorToolStripMenuItem.Click += new System.EventHandler(this.vanzatorToolStripMenuItem_Click);
            // 
            // DespreToolStripMenuItem1
            // 
            this.DespreToolStripMenuItem1.Name = "DespreToolStripMenuItem1";
            this.DespreToolStripMenuItem1.Size = new System.Drawing.Size(88, 29);
            this.DespreToolStripMenuItem1.Text = "Despre";
            this.DespreToolStripMenuItem1.Click += new System.EventHandler(this.DespreToolStripMenuItem1_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(160, 20);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(49)))), ((int)(((byte)(130)))));
            this.pictureBox1.Image = global::FeatherElectronics.Properties.Resources.pngimg_com___feather_PNG109994;
            this.pictureBox1.Location = new System.Drawing.Point(0, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 418);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feather Electronics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoriiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vanzareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem RaportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaUtilizatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adiministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vanzatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DespreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}