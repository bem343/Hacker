using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using prjHacker.classes;

namespace prjHacker.forms
{
    public partial class frmCodigoScript : Form
    {

        #region Variáveis
            private List<string> linhas = null; 
            private int proximoAtaque = 0;
            private int tempoAtaque = 0;
            private string linha = "";
            private int nLinha = 0;
            private int nLinhaTotal = 0;
        #endregion

        #region Contrutores
            public frmCodigoScript()
            {                
                InitializeComponent();
                MyFont.applyff(this.Controls);
            }
        #endregion

        #region Form Load
            private void frmMineracao_Load(object sender, EventArgs e)
            {
                linhas = frmNovoScript.script.lines;
                nLinha = frmNovoScript.script.linesP;
                nLinhaTotal = linhas.Count;

                if(nLinha == nLinhaTotal) { DialogResult = DialogResult.OK; Close(); return; }

                verificarVpn();
                lblLinhas.Text = nLinha + "/" + linhas.Count;
                linha = linhas[nLinha];
                lblLinha.Text = linha;
                pbLinha.Maximum = linha.Length;
                txtLinha.Focus(); Vpn.start();
                timerVpn.Start();
            }
        #endregion

        #region Métodos
            private void verificaLinha()
            {
                if (pbLinha.Value == pbLinha.Maximum)
                {
                    nLinha++; frmNovoScript.script.linesP++;
                    lblLinhas.Text = nLinha + "/" + linhas.Count;
                    if (nLinha != nLinhaTotal)
                    {
                        linha = linhas[nLinha];
                        lblLinha.Text = linha;
                        pbLinha.Value = 0;
                        pbLinha.Maximum = linha.Length;
                        txtLinha.Clear();
                        txtLinha.Focus();
                    }
                    else
                    {
                        Vpn.stop();
                        timerVpn.Stop();
                        timerAtaque.Stop();
                        txtLinha.TextChanged -= txtLinha_TextChanged;
                        txtLinha.Clear();
                        lblLinha.Text = "";
                        btnSair.Visible = false;
                        btnConcluir.Visible = true;
                        btnConcluir.Focus();
                        Play.complete();
                    }
                }
            }
            private bool verificarVpn()
            {
                if (Vpn.isActive)
                {
                    double segundos = Vpn.maximum - Vpn.time;
                    TimeSpan time = TimeSpan.FromSeconds(segundos);
                    lblVpn.Text = time.ToString(@"mm\:ss");
                    lblVpnAtivo.Visible = true;
                    lblVpn.Visible = true;
                    if ((Vpn.maximum - Vpn.time) <= 10) {
                    lblVpn.ForeColor = Color.FromArgb(200, 0, 0); }
                    return true;
                }
                lblVpn.Visible = false;
                lblVpnAtivo.Visible = false;
                return false;
            }
        #endregion

        #region Quando digita na caixa de texto
            private void txtLinha_TextChanged(object sender, EventArgs e)
            {
                Play.key();
                if (txtLinha.TextLength == 0) { pbLinha.Value = 0; return; }
                if (txtLinha.TextLength == pbLinha.Value) {
                    if (linha.Substring(0, pbLinha.Value) == txtLinha.Text.Substring(0, pbLinha.Value))
                    { txtLinha.ForeColor = Color.FromArgb(0, 200, 0); } return;
                }
                if (linha.Substring(pbLinha.Value, 1) == txtLinha.Text.Substring(pbLinha.Value, 1))
                { pbLinha.Value++; txtLinha.ForeColor = Color.FromArgb(0, 200, 0); }
                else { txtLinha.ForeColor = Color.FromArgb(200, 0, 0); return; } verificaLinha();
            }

            private void txtLinha_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyValue == 8)
                {
                    if (txtLinha.TextLength == pbLinha.Value && pbLinha.Value != 0)
                    { pbLinha.Value--; }
                }
            }
        #endregion

        #region Botão de sair personalizado
            private void btnSair_Click(object sender, EventArgs e)
            {
                Play.click();
                Close();
            }
        #endregion

        #region Evento Tick dos Timers
            private void setAtaque()
            {
                proximoAtaque = new Random().Next(6, 16);
            }
            private void timerVpn_Tick(object sender, EventArgs e)
            {
                if (!verificarVpn()) { timerVpn.Stop(); setAtaque(); timerAtaque.Start(); }
            }
            private void timerAtaque_Tick(object sender, EventArgs e)
            {
                tempoAtaque++; if (tempoAtaque == proximoAtaque) {
                    frmAtaque ataque = new frmAtaque();
                    DialogResult resultado = ataque.ShowDialog();
                    if (resultado == DialogResult.None)
                    {
                        do { resultado = ataque.DialogResult; }
                        while (ataque.DialogResult == DialogResult.None);
                    }
                    if (resultado != DialogResult.OK)
                    { pbLinha.Value = 0; txtLinha.Clear(); txtLinha.Focus(); Play.fail(); }
                    else { Play.complete(); } tempoAtaque = 0; setAtaque();
                }
            }
        #endregion

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Play.click();
            Close();
        }

        private void frmMineracao_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerAtaque.Stop();
            timerVpn.Stop();
            Vpn.stop();
        }
    }
}
