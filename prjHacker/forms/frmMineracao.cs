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
			private List<string> linhas = new List<string>();
			private XmlNodeList lines = null;
			Random r = new Random();

			private int proximoAtaque = 0;
			private int tempoAtaque = 0;
			private int nLinhaTotal = 0;
			private int tempoMineracao = 0;
			private int tempoMineracaoLimite = 0;
		#endregion

		#region Contrutores
		public frmMineracao(int nLinhaTotal)
			{
				this.nLinhaTotal = nLinhaTotal;
				DialogResult = DialogResult.Abort;
				InitializeComponent();
			}
		#endregion

		private void btnSair_Click(object sender, EventArgs e)
		{
			play.click();
			Close();
		}
		private void btnConcluir_Click(object sender, EventArgs e)
		{
			play.click();
			Close();
		}

		private void frmMineracao_Load(object sender, EventArgs e)
		{
			tempoMineracaoLimite = 7 * nLinhaTotal;
			pgProgresso.Maximum = tempoMineracaoLimite;
			rtbComandos.Text = "Carregando...";

			XmlDocument arquivo = new XmlDocument();
			arquivo.Load("lines.xml");
			lines = arquivo.GetElementsByTagName("line");

			for (int i = 0; i < nLinhaTotal; i++)
			{
				int nr = r.Next(lines.Count);
				linhas.Add(lines[nr].InnerText);
			}

			verificarVpn();
			vpn.start();
			timerVpn.Start();
			timerMineracao.Start();
		}

		#region Evento Tick dos Timers
			private bool verificarVpn()
			{
				if (vpn.isActive)
				{
					double segundos = vpn.maximum - vpn.time;
					TimeSpan time = TimeSpan.FromSeconds(segundos);
					lblVpn.Text = time.ToString(@"mm\:ss");
					lblVpnAtivo.Visible = true;
					lblVpn.Visible = true;
					if ((vpn.maximum - vpn.time) <= 10)
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
			private void timerMineracao_Tick(object sender, EventArgs e)
			{
				if (tempoMineracao < tempoMineracaoLimite) {
					rtbComandos.AppendText(linhas[r.Next(nLinhaTotal)]);
					tempoMineracao++; pgProgresso.Value = tempoMineracao;
				} else {
					timerAtaque.Stop();
					timerVpn.Stop();
					vpn.stop();
					play.complete();
					btnConcluir.Visible = true;
					timerMineracao.Stop();
					return;
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
						play.fail();
						tempoMineracao = 0;
						pgProgresso.Value = tempoMineracao;
						rtbComandos.Clear();
					}
					else { play.complete(); }
					tempoAtaque = 0; setAtaque();
				}
			}
		#endregion

		private void frmMineracao_FormClosing(object sender, FormClosingEventArgs e)
		{
			timerMineracao.Stop();
			timerAtaque.Stop();
			timerVpn.Stop();
			vpn.stop();
		}

		
	}
}
