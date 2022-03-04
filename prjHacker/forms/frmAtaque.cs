﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjHacker.classes;

namespace prjHacker.forms
{
    public partial class frmAtaque : Form
    {

        int ataque = 0;

        public frmAtaque()
        {
            Random cord = new Random();
            int x = cord.Next(1, Screen.PrimaryScreen.WorkingArea.Width - 406);
            int y = cord.Next(1, Screen.PrimaryScreen.WorkingArea.Height - 250);
            this.Location = new Point(x, y);
            DialogResult = DialogResult.Abort;
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ataque++;
            if (ataque >= pbAtaque.Maximum)
            { Close(); return; }
            if (ataque >= 0) { pbAtaque.Value = ataque; }
        }

        private void btnContraAtaque_Click(object sender, EventArgs e)
        {
            play.click();
            ataque -= 2;
            if (ataque <= 0)
            { DialogResult = DialogResult.OK; Close(); return; }
            if (ataque >= 0) { pbAtaque.Value = ataque; }
        }

        private void frmAtaque_Load(object sender, EventArgs e)
        {
            play.hacking();
            timer.Interval = 80;
            timer.Start();
            pbAtaque.Maximum = 22;
        }

        private void frmAtaque_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }
    }
}
