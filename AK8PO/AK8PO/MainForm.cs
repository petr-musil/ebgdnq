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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addContestantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newContestantForm = new NewContestantForm();
            newContestantForm.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageContestantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newContestantsForm = new ContestantsForm();
            newContestantsForm.ShowDialog();
        }
    }
}
