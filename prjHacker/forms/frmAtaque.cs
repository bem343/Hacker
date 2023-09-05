using System;
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

        double perdaT = 0;
        int ataque = 0;
        int tempo = 0;

        public frmAtaque()
        {
            Random cord = new Random();
            int x = cord.Next(1, Screen.PrimaryScreen.WorkingArea.Width - 406);
            int y = cord.Next(1, Screen.PrimaryScreen.WorkingArea.Height - 250);
            this.Location = new Point(x, y);
            DialogResult = DialogResult.Abort;
            InitializeComponent();
            MyFont.applyff(this.Controls);
        }

        private void frmAtaque_Load(object sender, EventArgs e)
        {
            Sound.hacking(true);
            timer.Interval = 82;
            pbAtaque.Maximum = 22;
            segundos.Start();
            timer.Start();
        }

        private void frmAtaque_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sound.hacking(false);
            timer.Stop();
            segundos.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ataque++;
            if (ataque >= pbAtaque.Maximum) { Close(); return; }
            if (ataque >= 0) { pbAtaque.Value = ataque; }
        }
        private void segundos_Tick(object sender, EventArgs e)
        {
            if (tempo > 2)
            {
                double perdaI = new Random().Next(2);
                double perdaQ = new Random().NextDouble();
                perdaT += perdaQ + perdaI; MyScripts.lost += perdaT;
                lblPerda.Text = "- $" + perdaT.ToString("#0.00");
            } else { tempo++; }
        }

        private void btnContraAtaque_Click(object sender, EventArgs e)
        {
            Sound.click();
            ataque -= 2;
            if (ataque <= 0)
            { DialogResult = DialogResult.OK; Close(); return; }
            if (ataque >= 0) { pbAtaque.Value = ataque; }
        }

    }
}
