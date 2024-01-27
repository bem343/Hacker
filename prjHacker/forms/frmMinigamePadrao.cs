using prjHacker.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjHacker.forms
{
	public partial class frmMinigamePadrao : prjHacker.forms.frmPadrao
	{

		#region Variáveis Globais

			private Random r = new Random();
			protected int proximoAtaque = 0;
			protected int tempoAtaque = 0;
			protected int[] limitesTempo;

		#endregion

		#region Contrutores
			public frmMinigamePadrao() : base()
			{
				DialogResult = DialogResult.Abort;
				InitializeComponent();
			}
			public frmMinigamePadrao(string titulo, int[] limitesTempo) : base(titulo, false)
			{
				DialogResult = DialogResult.Abort;
				InitializeComponent();
				this.limitesTempo = limitesTempo;
			}
			public frmMinigamePadrao(string titulo, int[] limitesTempo, EventHandler eventoAtaque) : base(titulo, false)
			{
				DialogResult = DialogResult.Abort;
				InitializeComponent();
				this.limitesTempo = limitesTempo;
				timerAtaque.Tick -= timerAtaque_Tick;
				timerAtaque.Tick += eventoAtaque;
			}
		#endregion

		#region Métodos
			private bool verificarVpn()
			{
				if (Vpn.isActive)
				{
					lblVpn.Text = Vpn.timeRemaining();
					lblVpnAtivo.Visible = true;
					lblVpn.Visible = true;
					if ((Vpn.maximum - Vpn.time) <= 10)
					{
						lblVpn.ForeColor = Color.FromArgb(200, 0, 0);
					}
					return true;
				}
				lblVpn.Visible = false;
				lblVpnAtivo.Visible = false;
				return false;
			}
		#endregion

		#region Eventos Tick dos timers
			protected void setAtaque()
            {
                proximoAtaque = r.Next(limitesTempo[0], limitesTempo[1]);
            }
			private void timerVpn_Tick(object sender, EventArgs e)
			{
				if (!verificarVpn()) { timerVpn.Stop(); setAtaque(); timerAtaque.Start(); }
			}
			private void timerAtaque_Tick(object sender, EventArgs e)
			{
				tempoAtaque++; if (tempoAtaque == proximoAtaque)
				{
					frmAtaque ataque = new frmAtaque();
					DialogResult resultado = ataque.ShowDialog();
					if (resultado == DialogResult.None)
					{
						do { resultado = ataque.DialogResult; }
						while (ataque.DialogResult == DialogResult.None);
					}
					if (resultado != DialogResult.OK) {
						//Perde o progresso do que seja porque perdeu pro hacker
					}
					else { Sound.complete(); }
					tempoAtaque = 0; setAtaque();
				}
			}
		#endregion

		private void frmMinigamePadrao_Load(object sender, EventArgs e)
		{
			verificarVpn();
			timerVpn.Start();
			Vpn.start();
		}

		private void frmMinigamePadrao_FormClosing(object sender, FormClosingEventArgs e)
		{
			timerAtaque.Stop();
			timerVpn.Stop();
			Vpn.stop();
		}
		
	}
}
