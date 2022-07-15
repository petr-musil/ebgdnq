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
        private List<FirstRoundGroup> groups = new();
        System.Drawing.Font normalFont;
        System.Drawing.Font boldFont;
        
        public frmMain()
        {
            boldFont = new System.Drawing.Font("Segoe UI", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            normalFont = new System.Drawing.Font("Segoe UI", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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

        private void newTournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTournamentForm newTournamentForm = new NewTournamentForm();
            newTournamentForm.SelectedContestantsUpdated += NewTournamentForm_SelectedContestantsUpdated;
            newTournamentForm.ShowDialog();
        }

        private void NewTournamentForm_SelectedContestantsUpdated(List<Contestant> selectedContestants)
        {
            this.tabControl.Visible = true;
            groups.Clear();
            
            int k = 0;
            for(int i = 0; i < 8; i++)
            {
                groups.Add(new FirstRoundGroup(selectedContestants[k], selectedContestants[k + 1]));
                k += 2;
            }
            for(int i = k; i < selectedContestants.Count(); i++)
            {
                groups[k - 16].addThirdContestant(selectedContestants[i]);
                k += 1;
            }
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirstRoundGroup currentGroup = groups[this.cmbGroup.SelectedIndex];
            this.lblPlayerA.Text = currentGroup.getContestantString('A');
            this.lblPlayerB.Text = currentGroup.getContestantString('B');
            this.lblPlayerC.Text = currentGroup.getContestantString('C');

            this.nmrPlayerA.Value = currentGroup.getContestantPoints('A');
            this.nmrPlayerB.Value = currentGroup.getContestantPoints('B');
            if (currentGroup.getContestantPoints('C') == -1)
                this.nmrPlayerC.Visible = false;
            else
            {
                this.nmrPlayerC.Visible = true;
                this.nmrPlayerC.Value = currentGroup.getContestantPoints('C');
            }
        }
        private void nmrPlayerA_ValueChanged(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedIndex >= 0)
            {
                groups[this.cmbGroup.SelectedIndex].setContestantPoints('A', (short)nmrPlayerA.Value);
            }
        }
        private void nmrPlayerB_ValueChanged(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedIndex >= 0)
            {
                groups[this.cmbGroup.SelectedIndex].setContestantPoints('B', (short)nmrPlayerB.Value);
            }
        }
        private void nmrPlayerC_ValueChanged(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedIndex >= 0)
            {
                groups[this.cmbGroup.SelectedIndex].setContestantPoints('C', (short)nmrPlayerC.Value);
            }
        }
        private char mapIndexToGroup(int index)
        {
            switch(index)
            {
                case 0: return 'A';
                case 1: return 'B';
                case 2: return 'C';
                case 3: return 'D';
                case 4: return 'E';
                case 5: return 'F';
                case 6: return 'G';
                case 7: return 'H';
                default: return ' ';
            }    
        }
        private void tabGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedIndex == 1)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (groups[i].getWinner() == null)
                    {
                        string errorMessage = "Ve skupině " + mapIndexToGroup(i) + " nelze kvůli bodové shodě určit vítěze.";
                        MessageBox.Show(errorMessage, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                for (int i = 0; i < 8; i++)
                {
                    if (groups[i].getSecond() == null)
                    {
                        string errorMessage = "Ve skupině " + mapIndexToGroup(i) + " nelze kvůli bodové shodě určit druhé místo.";
                        MessageBox.Show(errorMessage, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                SecondRound secondRound = new SecondRound(groups);
                lblContestantA1.Text = secondRound.contestantA1 != null ? secondRound.contestantA1.ToString() : "Vítěz neurčen!";
                lblContestantB1.Text = secondRound.contestantB1 != null ? secondRound.contestantB1.ToString() : "Vítěz neurčen!";
                lblContestantC1.Text = secondRound.contestantC1 != null ? secondRound.contestantC1.ToString() : "Vítěz neurčen!";
                lblContestantD1.Text = secondRound.contestantD1 != null ? secondRound.contestantD1.ToString() : "Vítěz neurčen!";
                lblContestantE1.Text = secondRound.contestantE1 != null ? secondRound.contestantE1.ToString() : "Vítěz neurčen!";
                lblContestantF1.Text = secondRound.contestantF1 != null ? secondRound.contestantF1.ToString() : "Vítěz neurčen!";
                lblContestantG1.Text = secondRound.contestantG1 != null ? secondRound.contestantG1.ToString() : "Vítěz neurčen!";
                lblContestantH1.Text = secondRound.contestantH1 != null ? secondRound.contestantH1.ToString() : "Vítěz neurčen!";
                
                lblContestantA2.Text = secondRound.contestantA2 != null ? secondRound.contestantA2.ToString() : "2. místo neurčeno!";
                lblContestantB2.Text = secondRound.contestantB2 != null ? secondRound.contestantB2.ToString() : "2. místo neurčeno!";
                lblContestantC2.Text = secondRound.contestantC2 != null ? secondRound.contestantC2.ToString() : "2. místo neurčeno!";
                lblContestantD2.Text = secondRound.contestantD2 != null ? secondRound.contestantD2.ToString() : "2. místo neurčeno!";
                lblContestantE2.Text = secondRound.contestantE2 != null ? secondRound.contestantE2.ToString() : "2. místo neurčeno!";
                lblContestantF2.Text = secondRound.contestantF2 != null ? secondRound.contestantF2.ToString() : "2. místo neurčeno!";
                lblContestantG2.Text = secondRound.contestantG2 != null ? secondRound.contestantG2.ToString() : "2. místo neurčeno!";
                lblContestantH2.Text = secondRound.contestantH2 != null ? secondRound.contestantH2.ToString() : "2. místo neurčeno!";
            }
        }
        private void resetFontsForThirdRound()
        {
            lblContestantO1.Font = normalFont;
            lblContestantO2.Font = normalFont;
            lblContestantO3.Font = normalFont;
            lblContestantO4.Font = normalFont;
            lblContestantO5.Font = normalFont;
            lblContestantO6.Font = normalFont;
            lblContestantO7.Font = normalFont;
            lblContestantO8.Font = normalFont;
        }

        private void resetFontsForFourthRound()
        {
            lblContestantS1.Font = normalFont;
            lblContestantS2.Font = normalFont;
            lblContestantS3.Font = normalFont;
            lblContestantS4.Font = normalFont;
        }
        private void resetFontsForFifthRound()
        {
            lblContestant1.Font = normalFont;
            lblContestant2.Font = normalFont;
        }
        private void lblContestantA1_Click(object sender, EventArgs e)
        {
            lblContestantA1.Font = boldFont;
            lblContestantH2.Font = normalFont;

            lblContestantO1.Text = lblContestantA1.Text;
            resetFontsForThirdRound();
        }

        private void lblContestantH2_Click(object sender, EventArgs e)
        {
            lblContestantH2.Font = boldFont;
            lblContestantA2.Font = normalFont;
            
            lblContestantO1.Text = lblContestantH1.Text;
            resetFontsForThirdRound();
        }

        private void lblContestantB1_Click(object sender, EventArgs e)
        {
            lblContestantB1.Font = boldFont;
            lblContestantG2.Font = normalFont;

            lblContestantO2.Text = lblContestantB1.Text;
            resetFontsForThirdRound();
        }

        private void lblContestantG2_Click(object sender, EventArgs e)
        {
            lblContestantG2.Font = boldFont;
            lblContestantB1.Font = normalFont;
            
            lblContestantO2.Text = lblContestantG2.Text;
            resetFontsForThirdRound();
        }

        private void lblContestantC1_Click(object sender, EventArgs e)
        {
            lblContestantC1.Font = boldFont;
            lblContestantF2.Font = normalFont;

            lblContestantO3.Text = lblContestantC1.Text;
            resetFontsForThirdRound();
        }

        private void lblContestantF2_Click(object sender, EventArgs e)
        {
            lblContestantF2.Font = boldFont;
            lblContestantC1.Font = normalFont;

            lblContestantO3.Text = lblContestantF2.Text;
            resetFontsForThirdRound();
        }

        private void lblContestantD1_Click(object sender, EventArgs e)
        {
            lblContestantD1.Font = boldFont;
            lblContestantE2.Font = normalFont;

            lblContestantO4.Text = lblContestantD1.Text;
            resetFontsForThirdRound();
        }

        private void lblContestantE2_Click(object sender, EventArgs e)
        {
            lblContestantE2.Font = boldFont;
            lblContestantD1.Font = normalFont;

            lblContestantO4.Text = lblContestantE2.Text;
            resetFontsForThirdRound();
        }

        private void lblContestantE1_Click(object sender, EventArgs e)
        {
            lblContestantE1.Font = boldFont;
            lblContestantD2.Font = normalFont;

            lblContestantO5.Text = lblContestantE1.Text;
            resetFontsForThirdRound();
        }
        private void lblContestantD2_Click(object sender, EventArgs e)
        {
            lblContestantD2.Font = boldFont;
            lblContestantE1.Font = normalFont;

            lblContestantO5.Text = lblContestantD2.Text;
            resetFontsForThirdRound();
        }

        private void lblContestantF1_Click(object sender, EventArgs e)
        {
            lblContestantF1.Font = boldFont;
            lblContestantC2.Font = normalFont;

            lblContestantO6.Text = lblContestantF1.Text;
            resetFontsForThirdRound();
        }

        private void lblContestantC2_Click(object sender, EventArgs e)
        {
            lblContestantC2.Font = boldFont;
            lblContestantF1.Font = normalFont;

            lblContestantO6.Text = lblContestantC2.Text;
            resetFontsForThirdRound();
        }

        private void lblContestantG1_Click(object sender, EventArgs e)
        {
            lblContestantG1.Font = boldFont;
            lblContestantB2.Font = normalFont;

            lblContestantO7.Text = lblContestantG1.Text;
            resetFontsForThirdRound();
        }

        private void lblContestantB2_Click(object sender, EventArgs e)
        {
            lblContestantB2.Font = boldFont;
            lblContestantG1.Font = normalFont;

            lblContestantO7.Text = lblContestantB2.Text;
            resetFontsForThirdRound();
        }

        private void lblContestantH1_Click(object sender, EventArgs e)
        {
            lblContestantH1.Font = boldFont;
            lblContestantA2.Font = normalFont;

            lblContestantO8.Text = lblContestantH1.Text;
            resetFontsForThirdRound();
        }

        private void lblContestantA2_Click(object sender, EventArgs e)
        {
            lblContestantA2.Font = boldFont;
            lblContestantH1.Font = normalFont;

            lblContestantO8.Text = lblContestantA2.Text;
            resetFontsForThirdRound();
        }

        private void lblContestantO1_Click(object sender, EventArgs e)
        {
            lblContestantO1.Font = boldFont;
            lblContestantO2.Font = normalFont;

            lblContestantS1.Text = lblContestantO1.Text;
            resetFontsForFourthRound();
        }

        private void lblContestantO2_Click(object sender, EventArgs e)
        {
            lblContestantO2.Font = boldFont;
            lblContestantO1.Font = normalFont;

            lblContestantS1.Text = lblContestantO2.Text;
            resetFontsForFourthRound();
        }

        private void lblContestantO3_Click(object sender, EventArgs e)
        {
            lblContestantO3.Font = boldFont;
            lblContestantO4.Font = normalFont;

            lblContestantS4.Text = lblContestantO3.Text;
            resetFontsForFourthRound();
        }

        private void lblContestantO4_Click(object sender, EventArgs e)
        {
            lblContestantO4.Font = boldFont;
            lblContestantO3.Font = normalFont;

            lblContestantS4.Text = lblContestantO4.Text;
            resetFontsForFourthRound();
        }

        private void lblContestantO5_Click(object sender, EventArgs e)
        {
            lblContestantO5.Font = boldFont;
            lblContestantO6.Font = normalFont;

            lblContestantS2.Text = lblContestantO5.Text;
            resetFontsForFourthRound();
        }

        private void lblContestantO6_Click(object sender, EventArgs e)
        {
            lblContestantO6.Font = boldFont;
            lblContestantO5.Font = normalFont;

            lblContestantS2.Text = lblContestantO6.Text;
            resetFontsForFourthRound();
        }

        private void lblContestantO7_Click(object sender, EventArgs e)
        {
            lblContestantO7.Font = boldFont;
            lblContestantO8.Font = normalFont;

            lblContestantS3.Text = lblContestantO7.Text;
            resetFontsForFourthRound();
        }

        private void lblContestantO8_Click(object sender, EventArgs e)
        {
            lblContestantO8.Font = boldFont;
            lblContestantO7.Font = normalFont;

            lblContestantS3.Text = lblContestantO8.Text;
            resetFontsForFourthRound();
        }

        private void lblContestantS1_Click(object sender, EventArgs e)
        {
            lblContestantS1.Font = boldFont;
            lblContestantS2.Font = normalFont;

            lblContestant1.Text = lblContestantS1.Text;
            resetFontsForFifthRound();
        }

        private void lblContestantS2_Click(object sender, EventArgs e)
        {
            lblContestantS2.Font = boldFont;
            lblContestantS1.Font = normalFont;

            lblContestant1.Text = lblContestantS2.Text;
            resetFontsForFifthRound();
        }

        private void lblContestantS3_Click(object sender, EventArgs e)
        {
            lblContestantS3.Font = boldFont;
            lblContestantS4.Font = normalFont;

            lblContestant2.Text = lblContestantS3.Text;
            resetFontsForFifthRound();
        }

        private void lblContestantS4_Click(object sender, EventArgs e)
        {
            lblContestantS4.Font = boldFont;
            lblContestantS3.Font = normalFont;

            lblContestant2.Text = lblContestantS4.Text;
            resetFontsForFifthRound();
        }

        private void lblContestant1_Click(object sender, EventArgs e)
        {
            lblContestant1.Font = boldFont;
            lblContestant2.Font = normalFont;

            lblWinner.Text = lblContestant1.Text;
        }

        private void lblContestant2_Click(object sender, EventArgs e)
        {
            lblContestant2.Font = boldFont;
            lblContestant1.Font = normalFont;

            lblWinner.Text = lblContestant2.Text;
        }
    }
}
