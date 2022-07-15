using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK8PO
{
    public partial class NewContestantForm : Form
    {
        public NewContestantForm()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void btnAddContestant_Click(object sender, EventArgs e)
        {
            Contestant contestant = new Contestant(this.txtName.Text, this.txtSurname.Text, this.txtEmail.Text, (short)this.nmuAge.Value, (ArtLevel)this.cmbLevel.SelectedIndex);
            
            Contestants.AddContestant(contestant);

            Close();
        }

        private void NewContestantForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = false;
                Close();
            }
        }
    }
}
