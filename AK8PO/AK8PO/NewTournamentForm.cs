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
    public delegate void SelectedContestantsHandler(List<Contestant> selectedContestants);
    public partial class NewTournamentForm : Form
    {
        private List<Contestant> loadedContestants;
        private List<Contestant> filteredContestants;
        private static Random random = new Random();

        public event SelectedContestantsHandler SelectedContestantsUpdated;

        public NewTournamentForm()
        {
            this.KeyPreview = true;
            InitializeComponent();
            loadedContestants = Contestants.GetAllContestants();
            filteredContestants = loadedContestants;
            this.tssStatistics.Text = "Počet zápasníků vyhovujících kritériím: " + loadedContestants.Count();
        }

        private void btnGenerateTournament_Click(object sender, EventArgs e)
        {
            int numberOfContestants = (int)this.nmuNumberOfContestants.Value;
            if (numberOfContestants > filteredContestants.Count())
            {
                MessageBox.Show("Počet zápasníků splňující kritéria zápasu je menší než počet zápasníků zadaných do závodu!", "Chyba", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                filteredContestants = filteredContestants.OrderBy(Contestant => random.Next()).ToList();
                SelectedContestantsUpdated(filteredContestants.Take(numberOfContestants).ToList());
                Close();
            }
        }

        private void NewTournamentForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = false;
                Close();
            }
        }

        private void statusStripUpdate(object sender, EventArgs e)
        {
            ushort minimalAge = (ushort)this.nmuAgeFrom.Value;
            ushort maximalAge = (ushort)this.nmuAgeTo.Value;
            ushort minimalLevel = (ushort)this.cmbLevelFrom.SelectedIndex;
            ushort maximalLevel = (ushort)this.cmbLevelTo.SelectedIndex;

            filteredContestants = loadedContestants.Where(Contestant => Contestant.Age >= minimalAge)
                                                   .Where(Contestant => Contestant.Age <= maximalAge)
                                                   .Where(Contestant => (int)Contestant.Level >= minimalLevel)
                                                   .Where(Contestant => (int)Contestant.Level <= maximalLevel)
                                                   .Select(Contestant => Contestant)
                                                   .ToList();
            this.tssStatistics.Text = "Počet zápasníků vyhovujících kritériím: " + filteredContestants.Count();
        }
    }
}
