namespace AK8PO
{
    partial class NewContestantForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.nmuAge = new System.Windows.Forms.NumericUpDown();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.btnAddContestant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmuAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Jméno";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(19, 32);
            this.txtName.MaxLength = 256;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 27);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(350, 32);
            this.txtSurname.MaxLength = 256;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(300, 27);
            this.txtSurname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(346, 9);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(63, 20);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Příjmení";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(19, 95);
            this.txtEmail.MaxLength = 256;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(346, 72);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 20);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Věk";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(15, 135);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(120, 20);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.Text = "Technický stupeň";
            // 
            // nmuAge
            // 
            this.nmuAge.Location = new System.Drawing.Point(350, 95);
            this.nmuAge.Name = "nmuAge";
            this.nmuAge.Size = new System.Drawing.Size(300, 27);
            this.nmuAge.TabIndex = 4;
            this.nmuAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
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
            this.cmbLevel.Location = new System.Drawing.Point(19, 158);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(300, 28);
            this.cmbLevel.TabIndex = 5;
            // 
            // btnAddContestant
            // 
            this.btnAddContestant.Location = new System.Drawing.Point(350, 151);
            this.btnAddContestant.Name = "btnAddContestant";
            this.btnAddContestant.Size = new System.Drawing.Size(300, 36);
            this.btnAddContestant.TabIndex = 6;
            this.btnAddContestant.Text = "Přidat zápasníka";
            this.btnAddContestant.UseVisualStyleBackColor = true;
            this.btnAddContestant.Click += new System.EventHandler(this.btnAddContestant_Click);
            // 
            // NewContestantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 219);
            this.Controls.Add(this.btnAddContestant);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.nmuAge);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.Name = "NewContestantForm";
            this.Text = "Nový zápasník";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewContestantForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nmuAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.NumericUpDown nmuAge;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.Button btnAddContestant;
    }
}