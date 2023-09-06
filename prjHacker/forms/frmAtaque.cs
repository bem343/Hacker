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

        //Constantes
        private const int AtaqueSpeed = 82;
        private const int AtaqueMaximum = 22;
        private const int AtaqueDecrease = 2;
        private const int AtaqueIncrease = 1;
        private const int StartLost = 2;
        private const int QuantLost = 2;
        private const int PosHackSec = 2;
        private const int PosHackLostMin = 10;
        private const int PosHackLostMax = 30;

        //Variáveis
        public static double lost = 0;
        public static int qtHacked = 0;
        Random r = new Random();
        double perdaT = 0;
        int ataque = 0;
        int tempo = 0;

        public frmAtaque()
        {
            DialogResult = DialogResult.Abort;

            //Posição da janela
            int x = r.Next(1, Screen.PrimaryScreen.WorkingArea.Width - 406);
            int y = r.Next(1, Screen.PrimaryScreen.WorkingArea.Height - 250);
            this.Location = new Point(x, y);
            
            InitializeComponent();
            MyFont.applyff(this.Controls);

            //Define valores iniciais para alguns controles
            timer.Interval = AtaqueSpeed;
            pbAtaque.Maximum = AtaqueMaximum;
        }

        private void frmAtaque_Load(object sender, EventArgs e)
        {
            Sound.hacking(true);
            segundos.Start();
            timer.Start();
        }

        private void frmAtaque_FormClosing(object sender, FormClosingEventArgs e)
        {
			//Impede que a janela seja fechada no ALT-F4
			if (e.CloseReason == CloseReason.UserClosing && this.DialogResult == DialogResult.Cancel) {
				e.Cancel = true;
				return;
			}

			timer.Stop();
            segundos.Stop();
            animation.Stop();
            posHack.Stop();
            Sound.hacking(false);
        }

		#region Evento Tick dos timers
		    private void timer_Tick(object sender, EventArgs e)
            {
                ataque += AtaqueIncrease;

                //Completou o hacking?
                if (ataque >= pbAtaque.Maximum) {
                    timer.Stop();
                    segundos.Stop();
                    Sound.hacking(false);
                    Sound.fail();
                    pbAtaque.Value = AtaqueMaximum;
                    Application.DoEvents();
                    
                    //Executa operações pós hackeamento :P
                    int extra = r.Next(PosHackLostMin, PosHackLostMax + 1);
                    perdaT += extra; lost += extra;
                    lblPerdaT.Text = "- $" + perdaT.ToString("#0.00");
                    lblPerdaPosHack.Text = "- $" + extra.ToString("#0.00");

                    btnContraAtaque.Visible = false;
                    lblPerdaPosHack.Visible = true;
                    lblPosHack.Visible = true;
                    qtHacked++; tempo = 0;
                    posHack.Start();
                    animation.Start();
                    return;
                }

                if (ataque >= 0) {
                    pbAtaque.Value = ataque;
                    Application.DoEvents();
                }
            }
            private void segundos_Tick(object sender, EventArgs e)
            {
                if (tempo > StartLost) {
                    double perdaI = r.Next(QuantLost);
                    double perdaQ = r.NextDouble();
                    perdaT += perdaQ + perdaI;
                    lost += perdaQ + perdaI;
                    lblPerdaT.Text = "- $" + perdaT.ToString("#0.00");
                } tempo++;
            }
            private void posHack_Tick(object sender, EventArgs e)
		    {
                if (tempo > PosHackSec) {
                    posHack.Stop();
                    animation.Stop();
                    DialogResult = DialogResult.Ignore;
                    this.Close();
                } tempo++;
		    }
            private void animation_Tick(object sender, EventArgs e)
		    {
                lblPosHack.Visible = !lblPosHack.Visible;
                lblPerdaPosHack.Visible = !lblPerdaPosHack.Visible;
                
                if(animation.Interval == 800)
                    animation.Interval = 200;
                else
                    animation.Interval = 800;
            }
		#endregion

		private void btnContraAtaque_Click(object sender, EventArgs e)
        {
            Sound.click();
            ataque -= AtaqueDecrease;

            //Impediu o hacking?
            if (ataque <= 0) {
                timer.Stop();
                segundos.Stop();
                Sound.hacking(false);
                pbAtaque.Value = 0;
                Application.DoEvents();

                DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            pbAtaque.Value = ataque;
            Application.DoEvents();
        }
	}
}
