namespace AK8PO
{
    partial class NewTournamentForm
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
            this.grbLevel = new System.Windows.Forms.GroupBox();
            this.cmbLevelTo = new System.Windows.Forms.ComboBox();
            this.cmbLevelFrom = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.grbAge = new System.Windows.Forms.GroupBox();
            this.nmuAgeTo = new System.Windows.Forms.NumericUpDown();
            this.nmuAgeFrom = new System.Windows.Forms.NumericUpDown();
            this.lblTo2 = new System.Windows.Forms.Label();
            this.lblNumberOfPools = new System.Windows.Forms.Label();
            this.lblNumberOfContestants = new System.Windows.Forms.Label();
            this.nmuNumberOfPools = new System.Windows.Forms.NumericUpDown();
            this.nmuNumberOfContestants = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatistics = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGenerateTournament = new System.Windows.Forms.Button();
            this.grbLevel.SuspendLayout();
            this.grbAge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuAgeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuAgeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuNumberOfPools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuNumberOfContestants)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLevel
            // 
            this.grbLevel.Controls.Add(this.cmbLevelTo);
            this.grbLevel.Controls.Add(this.cmbLevelFrom);
            this.grbLevel.Controls.Add(this.lblTo);
            this.grbLevel.Location = new System.Drawing.Point(19, 22);
            this.grbLevel.Name = "grbLevel";
            this.grbLevel.Size = new System.Drawing.Size(389, 76);
            this.grbLevel.TabIndex = 0;
            this.grbLevel.TabStop = false;
            this.grbLevel.Text = "Technický stupeň";
            // 
            // cmbLevelTo
            // 
            this.cmbLevelTo.FormattingEnabled = true;
            this.cmbLevelTo.Items.AddRange(new object[] {
            "10 kyu",
            "9 kyu",
            "8 kyu",
            "7 kyu",
            "6 kyu",
            "5 kyu",
            "4 kyu",
            "3 kyu",
            "2 kyu",
            "1 kyu",
            "1 dan",
            "2 dan",
            "3 dan",
            "4 dan",
            "5 dan",
            "6 dan",
            "7 dan",
            "8 dan",
            "9 dan",
            "10 dan"});
            this.cmbLevelTo.Location = new System.Drawing.Point(215, 27);
            this.cmbLevelTo.Name = "cmbLevelTo";
            this.cmbLevelTo.Size = new System.Drawing.Size(167, 29);
            this.cmbLevelTo.TabIndex = 2;
            this.cmbLevelTo.DropDownClosed += new System.EventHandler(this.statusStripUpdate);
            // 
            // cmbLevelFrom
            // 
            this.cmbLevelFrom.FormattingEnabled = true;
            this.cmbLevelFrom.Items.AddRange(new object[] {
            "10 kyu",
            "9 kyu",
            "8 kyu",
            "7 kyu",
            "6 kyu",
            "5 kyu",
            "4 kyu",
            "3 kyu",
            "2 kyu",
            "1 kyu",
            "1 dan",
            "2 dan",
            "3 dan",
            "4 dan",
            "5 dan",
            "6 dan",
            "7 dan",
            "8 dan",
            "9 dan",
            "10 dan"});
            this.cmbLevelFrom.Location = new System.Drawing.Point(7, 27);
            this.cmbLevelFrom.Name = "cmbLevelFrom";
            this.cmbLevelFrom.Size = new System.Drawing.Size(167, 29);
            this.cmbLevelFrom.TabIndex = 1;
            this.cmbLevelFrom.DropDownClosed += new System.EventHandler(this.statusStripUpdate);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(181, 30);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 21);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "až";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbAge
            // 
            this.grbAge.Controls.Add(this.nmuAgeTo);
            this.grbAge.Controls.Add(this.nmuAgeFrom);
            this.grbAge.Controls.Add(this.lblTo2);
            this.grbAge.Location = new System.Drawing.Point(415, 22);
            this.grbAge.Name = "grbAge";
            this.grbAge.Size = new System.Drawing.Size(389, 76);
            this.grbAge.TabIndex = 1;
            this.grbAge.TabStop = false;
            this.grbAge.Text = "Věk";
            // 
            // nmuAgeTo
            // 
            this.nmuAgeTo.Location = new System.Drawing.Point(215, 27);
            this.nmuAgeTo.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmuAgeTo.Name = "nmuAgeTo";
            this.nmuAgeTo.Size = new System.Drawing.Size(168, 29);
            this.nmuAgeTo.TabIndex = 4;
            this.nmuAgeTo.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmuAgeTo.ValueChanged += new System.EventHandler(this.statusStripUpdate);
            // 
            // nmuAgeFrom
            // 
            this.nmuAgeFrom.Location = new System.Drawing.Point(7, 27);
            this.nmuAgeFrom.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmuAgeFrom.Name = "nmuAgeFrom";
            this.nmuAgeFrom.Size = new System.Drawing.Size(168, 29);
            this.nmuAgeFrom.TabIndex = 3;
            this.nmuAgeFrom.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nmuAgeFrom.ValueChanged += new System.EventHandler(this.statusStripUpdate);
            // 
            // lblTo2
            // 
            this.lblTo2.AutoSize = true;
            this.lblTo2.Location = new System.Drawing.Point(181, 30);
            this.lblTo2.Name = "lblTo2";
            this.lblTo2.Size = new System.Drawing.Size(25, 21);
            this.lblTo2.TabIndex = 0;
            this.lblTo2.Text = "až";
            this.lblTo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfPools
            // 
            this.lblNumberOfPools.AutoSize = true;
            this.lblNumberOfPools.Location = new System.Drawing.Point(26, 112);
            this.lblNumberOfPools.Name = "lblNumberOfPools";
            this.lblNumberOfPools.Size = new System.Drawing.Size(209, 21);
            this.lblNumberOfPools.TabIndex = 2;
            this.lblNumberOfPools.Text = "Počet skupin základního kola";
            this.lblNumberOfPools.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfContestants
            // 
            this.lblNumberOfContestants.AutoSize = true;
            this.lblNumberOfContestants.Location = new System.Drawing.Point(422, 112);
            this.lblNumberOfContestants.Name = "lblNumberOfContestants";
            this.lblNumberOfContestants.Size = new System.Drawing.Size(232, 21);
            this.lblNumberOfContestants.TabIndex = 3;
            this.lblNumberOfContestants.Text = "Počet zápasníků základního kola";
            this.lblNumberOfContestants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmuNumberOfPools
            // 
            this.nmuNumberOfPools.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmuNumberOfPools.Location = new System.Drawing.Point(26, 136);
            this.nmuNumberOfPools.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nmuNumberOfPools.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nmuNumberOfPools.Name = "nmuNumberOfPools";
            this.nmuNumberOfPools.Size = new System.Drawing.Size(376, 29);
            this.nmuNumberOfPools.TabIndex = 5;
            this.nmuNumberOfPools.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // nmuNumberOfContestants
            // 
            this.nmuNumberOfContestants.Location = new System.Drawing.Point(422, 136);
            this.nmuNumberOfContestants.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nmuNumberOfContestants.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nmuNumberOfContestants.Name = "nmuNumberOfContestants";
            this.nmuNumberOfContestants.Size = new System.Drawing.Size(376, 29);
            this.nmuNumberOfContestants.TabIndex = 6;
            this.nmuNumberOfContestants.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatistics});
            this.statusStrip1.Location = new System.Drawing.Point(0, 251);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(821, 28);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatistics
            // 
            this.tssStatistics.Name = "tssStatistics";
            this.tssStatistics.Size = new System.Drawing.Size(298, 21);
            this.tssStatistics.Text = "Počet zápasníků vyhovujících kritériím: 54";
            // 
            // btnGenerateTournament
            // 
            this.btnGenerateTournament.Location = new System.Drawing.Point(19, 185);
            this.btnGenerateTournament.Name = "btnGenerateTournament";
            this.btnGenerateTournament.Size = new System.Drawing.Size(785, 41);
            this.btnGenerateTournament.TabIndex = 11;
            this.btnGenerateTournament.Text = "Vygenerovat turnaj";
            this.btnGenerateTournament.UseVisualStyleBackColor = true;
            this.btnGenerateTournament.Click += new System.EventHandler(this.btnGenerateTournament_Click);
            // 
            // NewTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 279);
            this.Controls.Add(this.btnGenerateTournament);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.nmuNumberOfContestants);
            this.Controls.Add(this.nmuNumberOfPools);
            this.Controls.Add(this.lblNumberOfContestants);
            this.Controls.Add(this.lblNumberOfPools);
            this.Controls.Add(this.grbAge);
            this.Controls.Add(this.grbLevel);
            this.MaximizeBox = false;
            this.Name = "NewTournamentForm";
            this.Text = "Nový turnaj";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewTournamentForm_KeyDown);
            this.grbLevel.ResumeLayout(false);
            this.grbLevel.PerformLayout();
            this.grbAge.ResumeLayout(false);
            this.grbAge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuAgeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuAgeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuNumberOfPools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuNumberOfContestants)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLevel;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox cmbLevelTo;
        private System.Windows.Forms.ComboBox cmbLevelFrom;
        private System.Windows.Forms.GroupBox grbAge;
        private System.Windows.Forms.Label lblTo2;
        private System.Windows.Forms.NumericUpDown nmuAgeTo;
        private System.Windows.Forms.NumericUpDown nmuAgeFrom;
        private System.Windows.Forms.Label lblNumberOfPools;
        private System.Windows.Forms.Label lblNumberOfContestants;
        private System.Windows.Forms.NumericUpDown nmuNumberOfPools;
        private System.Windows.Forms.NumericUpDown nmuNumberOfContestants;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatistics;
        private System.Windows.Forms.Button btnGenerateTournament;
    }
}