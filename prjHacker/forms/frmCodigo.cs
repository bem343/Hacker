using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjHacker.classes;
using System.Xml;

namespace prjHacker.forms
{
    public partial class frmCodigo : Form
    {

        #region Variáveis
            int erros = 0;
            string codigoOriginal = "";
            string originalSeco = "";
            string codigoFinal = "";
            private int proximoAtaque = 0;
            private int tempoAtaque = 0;
            private XmlNodeList codes = null;
        #endregion

        #region Construtores
            public frmCodigo(int erros)
            {
                this.erros = erros;
                DialogResult = DialogResult.Abort;
                InitializeComponent();
            }   
        #endregion

        #region Métodos
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
        #endregion

        #region Page Load
            private void frmCodigo_Load(object sender, EventArgs e)
            {
                XmlDocument arquivo = new XmlDocument();
                arquivo.Load("codes.xml");
                codes = arquivo.GetElementsByTagName("code");

                int r = new Random().Next(0, codes.Count);
                codigoOriginal = codes[r].InnerText;
                Random posicaoAleatoria = new Random();
                originalSeco = codigoOriginal.Replace(" ", "");
                int init = 0; for (int i = 0; i < erros; i++)
                {
                    int fim = 0; do {
                        fim = posicaoAleatoria.Next(init, (codigoOriginal.Length - (erros - i)));
                    } while (codigoOriginal.Substring(fim, 1) == " ");
                    codigoFinal += codigoOriginal.Substring(init, (fim - init)); init = fim + 1;
                } codigoFinal += codigoOriginal.Substring(init, (codigoOriginal.Length - init));

                lblOriginal.Text = codigoOriginal; rtbFinal.Text = codigoFinal;
                lblUsuario.Text = "Script de: bem343"; verificarVpn();
                lblErros.Text = erros.ToString(); rtbFinal.Focus();
                vpn.start(); timerVpn.Start();
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
                tempoAtaque++; if (tempoAtaque == proximoAtaque)
                {
                    frmAtaque ataque = new frmAtaque();
                    DialogResult resultado = ataque.ShowDialog();
                    if (resultado == DialogResult.None)
                    {
                        do { resultado = ataque.DialogResult; }
                        while (ataque.DialogResult == DialogResult.None);
                    }
                    if (resultado != DialogResult.OK)
                    { rtbFinal.Text = codigoFinal; lblErros.Text = "0"; rtbFinal.Focus(); play.fail(); }
                    else { play.complete(); } stop.hacking(); tempoAtaque = 0; setAtaque();
                }
            }
        #endregion

        #region Verifica as mudanças digitadas no código final
            private void rtbFinal_TextChanged(object sender, EventArgs e)
            {
                string rascunhoSeco = rtbFinal.Text.Replace(" ", "").Replace("\n", "");
                //Verificação dos erros
                erros = 0;
                for (int i = 0; i < originalSeco.Length; i++)
                {
                    if(rascunhoSeco.Substring(i - erros, 1) != originalSeco.Substring(i, 1))
                    {
                        erros++;
                    }
                } lblErros.Text = erros.ToString();
                //Verificação do todo
                if (rascunhoSeco == originalSeco)
                {
                    vpn.stop();
                    timerVpn.Stop();
                    timerAtaque.Stop();
                    rtbFinal.ReadOnly = true;
                    btnRefazer.Visible = false;
                    btnConcluir.Visible = true;
                    btnConcluir.Focus();
                }
            }
            private void btnConcluir_Click(object sender, EventArgs e)
            {
                play.complete(); Close();
            }
        #endregion

        #region Botão Sair personalizado
            private void btnSair_Click(object sender, EventArgs e)
            {
                Close();
            }
            private void frmCodigo_FormClosing(object sender, FormClosingEventArgs e)
            {
                timerAtaque.Stop();
                timerVpn.Stop();
                vpn.stop();
            }
        #endregion

        #region Botão Refazer
            private void btnRefazer_Click(object sender, EventArgs e)
            {
                rtbFinal.Text = codigoFinal;
            }
        #endregion

    }
}