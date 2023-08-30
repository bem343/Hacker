using prjHacker.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace prjHacker.forms
{
	public partial class frmMineracao : Form
	{

		#region Variáveis
			public static bool minerado = false;
			private List<string> linhas = null;
			Random r = new Random();

			private int proximoAtaque = 0;
			private int tempoAtaque = 0;
			private int nLinhaTotal = 0;
			private int tempoMineracao = 0;
			private int tempoMineracaoLimite = 0;
		#endregion

		#region Contrutores
		public frmMineracao(Script script)
			{
				this.linhas = script.lines;
				this.nLinhaTotal = linhas.Count;
				DialogResult = DialogResult.Abort;
				InitializeComponent();
				MyFont.applyff(this.Controls);
			}
		#endregion

		private void btnSair_Click(object sender, EventArgs e)
		{
			Play.click();
			Close();
		}
		private void btnConcluir_Click(object sender, EventArgs e)
		{
			Play.click(); minerado = false; Close();
		}

		private void frmMineracao_Load(object sender, EventArgs e)
		{
			if(minerado) {
				DialogResult = DialogResult.OK;
				minerado = false;
				Close();
				return;
			}

			tempoMineracaoLimite = 7 * nLinhaTotal;
			pgProgresso.Maximum = tempoMineracaoLimite;
			rtbComandos.Text = "Loading script...\n";

			verificarVpn();
			Vpn.start();
			timerVpn.Start();
			timerTexto.Start();
			timerMineracao.Start();
		}

		#region Evento Tick dos Timers
			private bool verificarVpn()
			{
				if (Vpn.isActive)
				{
					double segundos = Vpn.maximum - Vpn.time;
					TimeSpan time = TimeSpan.FromSeconds(segundos);
					lblVpn.Text = time.ToString(@"mm\:ss");
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
			private void setAtaque()
			{
				proximoAtaque = new Random().Next(6, 11);
			}
			private void timerTexto_Tick(object sender, EventArgs e)
			{
				rtbComandos.AppendText(linhas[r.Next(nLinhaTotal)] + " ");
			}
			private void timerMineracao_Tick(object sender, EventArgs e)
			{
				if (tempoMineracao < tempoMineracaoLimite) {
					tempoMineracao++; pgProgresso.Value = tempoMineracao;
				} else {
					timerMineracao.Stop();
					timerAtaque.Stop();
					timerTexto.Stop();
					timerVpn.Stop();
					Vpn.stop();
					Play.complete();
					minerado = true;
					btnConcluir.Visible = true;
				}
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
						Play.fail();
						tempoMineracao = 0;
						pgProgresso.Value = tempoMineracao;
						rtbComandos.Clear();
					}
					else { Play.complete(); }
					tempoAtaque = 0; setAtaque();
				}
			}
		#endregion

		private void frmMineracao_FormClosing(object sender, FormClosingEventArgs e)
		{
			timerMineracao.Stop();
			timerAtaque.Stop();
			timerTexto.Stop();
			timerVpn.Stop();
			Vpn.stop();
		}
	}
}
