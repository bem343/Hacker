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
            string user = "";
            string codigoOriginal = "";
            string originalSeco = "";
            string codigoFinal = "";
            private int proximoAtaque = 0;
            private int tempoAtaque = 0;
            public static XmlNodeList codes = null;
        #endregion

        #region Construtores
            public frmCodigo(string user, int erros)
            {
                this.erros = erros;
                this.user = user;
                DialogResult = DialogResult.Abort;
                InitializeComponent();
                MyFont.applyff(this.Controls);
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

        #region Page Load
            private void frmCodigo_Load(object sender, EventArgs e)
            {
                int r = new Random().Next(0, codes.Count);
                codigoOriginal = codes[r].InnerText;

                Random posicaoAleatoria = new Random();
                originalSeco = codigoOriginal.Replace(" ", "");

                //Gera os erros no código
                codigoFinal = codigoOriginal;
                for (int i = 0; i < erros; i++)
                {
                    int posicao;
                    do {
                        posicao = posicaoAleatoria.Next(codigoFinal.Length);
                    } while (codigoFinal.Substring(posicao, 1) == " ");
                    codigoFinal = codigoFinal.Remove(posicao, 1);
                }

                lblOriginal.Text = codigoOriginal; rtbFinal.Text = codigoFinal;
                lblUsuario.Text = "Script de: " + user; verificarVpn();
                lblErros.Text = erros.ToString(); rtbFinal.Focus();
                timerVpn.Start(); Vpn.start();
            }
        #endregion

        #region Evento Tick dos Timers
            private void setAtaque()
            {
                proximoAtaque = new Random().Next(15, 31);
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
						rtbFinal.Text = codigoFinal;
                        rtbFinal.Focus();
					}
					else { Sound.complete(); }
					tempoAtaque = 0; setAtaque();
				}
            }
        #endregion

        #region Verifica as mudanças digitadas no código final
            private void rtbFinal_TextChanged(object sender, EventArgs e)
            {
                Sound.key();
                string rascunhoSeco = rtbFinal.Text.Replace(" ", "").Replace("\n", "");

                //Verificação dos erros
                int errosA = erros; erros = 0;
                for (int i = 0; i < originalSeco.Length; i++)
                {
                    if(i - erros < rascunhoSeco.Length) {
                        if (rascunhoSeco.Substring(i - erros, 1) != originalSeco.Substring(i, 1))
                            erros++;
                    } else { erros++; }
                } lblErros.Text = erros.ToString(); if ((errosA - erros) < -1)
                { lblErros.ForeColor = Color.FromArgb(200, 0, 0); }
                else { lblErros.ForeColor = Color.White; }

                //Verificação do todo
                if (rascunhoSeco == originalSeco)
                {
                    Vpn.stop();
                    timerVpn.Stop();
                    timerAtaque.Stop();
                    rtbFinal.ReadOnly = true;
                    btnRefazer.Visible = false;
                    btnConcluir.Visible = true;
                    btnConcluir.Focus();
                    Sound.complete();
                }
            }
            private void btnConcluir_Click(object sender, EventArgs e)
            {
                Sound.click();
                Close();
            }
        #endregion

        #region Botão Sair personalizado
            private void btnSair_Click(object sender, EventArgs e)
            {
                Sound.click();
                Close();
            }
            private void frmCodigo_FormClosing(object sender, FormClosingEventArgs e)
            {
                timerAtaque.Stop();
                timerVpn.Stop();
                Vpn.stop();
            }
        #endregion

        #region Botão Refazer
            private void btnRefazer_Click(object sender, EventArgs e)
            {
                Sound.select();
                rtbFinal.Text = codigoFinal;
                rtbFinal.Focus();
            }
        #endregion

    }
}