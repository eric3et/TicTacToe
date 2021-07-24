﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainMenuPage : Form
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }

        private void btnLocalMulti_Click(object sender, EventArgs e)
        {
            LocalMultiPlayerPage p = new LocalMultiPlayerPage();
            p.Show();
            
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            SinglePlayerPage p = new SinglePlayerPage();
            p.Show();
        }

        private void btnOnlineMulti_Click(object sender, EventArgs e)
        {
            OnlineMultiPlayerPage p = new OnlineMultiPlayerPage();
            p.Show();
            
        }
    }
}