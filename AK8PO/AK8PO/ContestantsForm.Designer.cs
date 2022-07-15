namespace AK8PO
{
    partial class ContestantsForm
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
            this.ltvMain = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ltvMain
            // 
            this.ltvMain.FullRowSelect = true;
            this.ltvMain.HideSelection = false;
            this.ltvMain.Location = new System.Drawing.Point(14, 13);
            this.ltvMain.Name = "ltvMain";
            this.ltvMain.Size = new System.Drawing.Size(872, 447);
            this.ltvMain.TabIndex = 0;
            this.ltvMain.UseCompatibleStateImageBehavior = false;
            this.ltvMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContestantsForm_KeyDown);
            // 
            // ContestantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 472);
            this.Controls.Add(this.ltvMain);
            this.Name = "ContestantsForm";
            this.Text = "ContestantsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ltvMain;
    }
}