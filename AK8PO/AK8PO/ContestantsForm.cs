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
    public partial class ContestantsForm : Form
    {
        public ContestantsForm()
        {
            this.KeyPreview = true;
            InitializeComponent();

            this.ltvMain.View = View.Details;
            this.ltvMain.Columns.Add("Jméno", 100, HorizontalAlignment.Left);
            this.ltvMain.Columns.Add("Příjmení", 100, HorizontalAlignment.Left);
            this.ltvMain.Columns.Add("Email", 100, HorizontalAlignment.Left);
            this.ltvMain.Columns.Add("Věk", 100, HorizontalAlignment.Right);
            this.ltvMain.Columns.Add("Stupeň", 100, HorizontalAlignment.Center);

            List<Contestant> contestants = Contestants.GetAllContestants();

            this.ltvMain.BeginUpdate();
            foreach (Contestant contestant in contestants)
            {
                ListViewItem item = new ListViewItem();
                item.Text = contestant.Name.ToString();
                item.SubItems.Add(contestant.Surname.ToString());
                item.SubItems.Add(contestant.Email.ToString());
                item.SubItems.Add(contestant.Age.ToString());
                item.SubItems.Add(contestant.Level.ToString());
                ltvMain.Items.Add(item);
            }
            this.ltvMain.EndUpdate();
        }
        private void ContestantsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = false;
                Close();
            }
            if (e.KeyCode == Keys.Delete)
            {
                if (ltvMain.SelectedIndices.Count < 1)
                {
                    MessageBox.Show("Nevybrali jste žádného zápasníka ke smazání.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Opravdu si přejete vymazat zápasníka?", "Varování", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Contestants.DeleteContestant(ltvMain.Items[ltvMain.SelectedIndices[0]].SubItems[2].Text);
                        ltvMain.Items[ltvMain.SelectedIndices[0]].Remove();
                    }
                }

            }
        }
    }
}
