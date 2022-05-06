namespace AK8PO
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zápasníkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContestantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageContestantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zápasyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vytvořitZápasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zápasníkToolStripMenuItem,
            this.zápasyToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zápasníkToolStripMenuItem
            // 
            this.zápasníkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContestantToolStripMenuItem,
            this.manageContestantsToolStripMenuItem});
            this.zápasníkToolStripMenuItem.Name = "zápasníkToolStripMenuItem";
            this.zápasníkToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.zápasníkToolStripMenuItem.Text = "Zápasníci";
            // 
            // addContestantToolStripMenuItem
            // 
            this.addContestantToolStripMenuItem.Name = "addContestantToolStripMenuItem";
            this.addContestantToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addContestantToolStripMenuItem.Text = "Přidat zápasníka";
            this.addContestantToolStripMenuItem.Click += new System.EventHandler(this.addContestantToolStripMenuItem_Click);
            // 
            // manageContestantsToolStripMenuItem
            // 
            this.manageContestantsToolStripMenuItem.Name = "manageContestantsToolStripMenuItem";
            this.manageContestantsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageContestantsToolStripMenuItem.Text = "Správa zápasníků";
            this.manageContestantsToolStripMenuItem.Click += new System.EventHandler(this.manageContestantsToolStripMenuItem_Click);
            // 
            // zápasyToolStripMenuItem
            // 
            this.zápasyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vytvořitZápasToolStripMenuItem});
            this.zápasyToolStripMenuItem.Name = "zápasyToolStripMenuItem";
            this.zápasyToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.zápasyToolStripMenuItem.Text = "Zápasy";
            // 
            // vytvořitZápasToolStripMenuItem
            // 
            this.vytvořitZápasToolStripMenuItem.Name = "vytvořitZápasToolStripMenuItem";
            this.vytvořitZápasToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.vytvořitZápasToolStripMenuItem.Text = "Vytvořit zápas";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quitToolStripMenuItem.Text = "Ukončit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "AK8PO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zápasníkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContestantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageContestantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zápasyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vytvořitZápasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}
