﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void showPlayersButton_Click(object sender, EventArgs e)
        {
            PlayersForm playersForm = new PlayersForm();

            playersForm.ShowDialog();

            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
