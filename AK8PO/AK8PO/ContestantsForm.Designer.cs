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
            this.ltvMain.Location = new System.Drawing.Point(12, 12);
            this.ltvMain.Name = "ltvMain";
            this.ltvMain.Size = new System.Drawing.Size(776, 426);
            this.ltvMain.TabIndex = 0;
            this.ltvMain.UseCompatibleStateImageBehavior = false;
            // 
            // ContestantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ltvMain);
            this.Name = "ContestantsForm";
            this.Text = "ContestantsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ltvMain;
    }
}