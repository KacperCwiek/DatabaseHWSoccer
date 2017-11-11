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
    public partial class OnlyEnglishPlayersForm : Form
    {
        public OnlyEnglishPlayersForm()
        {
            InitializeComponent();
        }

        private void playersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.soccerDataSet);

        }

        private void OnlyEnglishPlayersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'soccerDataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.FillByOnlyEnglish(this.soccerDataSet.Players);

        }
    }
}
