using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseHWSoccer
{
    public partial class PlayersForm : Form
    {
        public PlayersForm()
        {
            InitializeComponent();
        }

        private void playersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.soccerDataSet);

        }

        private void PlayersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'soccerDataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.soccerDataSet.Players);

        }



        private void manUPlayersShowButton_Click(object sender, EventArgs e)
        {
            // pull out only Manchester players
            this.playersTableAdapter.FillByManU(this.soccerDataSet.Players);
        }

        private void maxGoalButton_Click(object sender, EventArgs e)
        {
            this.playersTableAdapter.MaxGoalsPlayer(this.soccerDataSet.Players);
        }

        private void spainPlayersButton_Click(object sender, EventArgs e)
        {
            // pull out only spain team players
            this.playersTableAdapter.FillBySpainPlayers(this.soccerDataSet.Players);
        }

        private void sortByTeamButton_Click(object sender, EventArgs e)
        {
            // asceding order of name teams
            this.playersTableAdapter.FillBySortedTeams(this.soccerDataSet.Players);
        }

        private void greaterOrEqualButton_Click(object sender, EventArgs e)
        {
            // greater or equal
            this.playersTableAdapter.FillByGreaterOrEqual(this.soccerDataSet.Players);
        }

        private void showEnglishPlayersButton_Click(object sender, EventArgs e)
        {
            OnlyEnglishPlayersForm englishPlayers = new OnlyEnglishPlayersForm();

            englishPlayers.ShowDialog();

            this.playersTableAdapter.FillByOnlyEnglish(this.soccerDataSet.Players);

            // changed method in only english players form as well !!!
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(searchLastNameTextbox.Text != "")
            {
                string lastName = "";
                lastName = searchLastNameTextbox.Text;

                this.playersTableAdapter.FillBySearchedLastName(this.soccerDataSet.Players, lastName);
            }

            else
            {
                MessageBox.Show("Please enter last name.");
            }
        }

        private void clearAndShowButton_Click(object sender, EventArgs e)
        {
            searchLastNameTextbox.Text = "";
            searchLastNameTextbox.Focus();

            this.playersTableAdapter.Fill(this.soccerDataSet.Players);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            this.playersTableAdapter.Fill(this.soccerDataSet.Players);
        }
    }
}
