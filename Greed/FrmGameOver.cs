﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greed
{
    public partial class FrmGameOver : Form
    {
        public FrmGameOver(Player winner)
        {
            InitializeComponent();
            TxtWinner.Text = winner.Name + " wins!\nThanks for playing!";
        }

        private void FrmGameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnPlayAgainNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPlayAgainYes_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
