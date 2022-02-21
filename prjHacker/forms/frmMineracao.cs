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
    public partial class frmMineracao : Form
    {

        private List<string> linhas = new List<string>()
        {
            "if (x == 0) { this.numero = x; }",
            "if (x > 0) { x--; }",
            "if (x < 0) { x++; }"
        };
        private string linha = "";
        private int nLinha = 0;

        #region Contrutores
            public frmMineracao()
            {
                InitializeComponent();
            }
        #endregion

        #region Verificar o vpn e atualizar o tempo
            private void verificarVpn()
            {
                if (vpn.isActive)
                {
                    double segundos = vpn.maximum - vpn.time;
                    TimeSpan time = TimeSpan.FromSeconds(segundos);
                    lblVpn.Text = time.ToString(@"mm\:ss");
                    lblVpnAtivo.Visible = true;
                    lblVpn.Visible = true;
                }
                else
                {
                    lblVpn.Visible = false;
                    lblVpnAtivo.Visible = false;
                }
            }
        #endregion

        private void frmMineracao_Load(object sender, EventArgs e)
        {
            verificarVpn();
            lblLinhas.Text = (nLinha + 1) + "/" + linhas.Count;
            linha = linhas[0];
            lblLinha.Text = linha;
            pbLinha.Maximum = linha.Length;
            txtLinha.Focus();
            vpn.start();
            timerVpn.Start();
        }

        private void verificaLinha()
        {
            if (pbLinha.Value == pbLinha.Maximum)
            {
                nLinha++;
                if (nLinha != linhas.Count)
                {
                    lblLinhas.Text = (nLinha + 1) + "/" + linhas.Count;
                    linha = linhas[nLinha];
                    lblLinha.Text = linha;
                    pbLinha.Value = 0;
                    pbLinha.Maximum = linha.Length;
                    txtLinha.Clear();
                    txtLinha.Focus();
                }
                else
                {
                    vpn.stop();
                    timerVpn.Stop();
                    Close();
                }
            }
        }

        private void txtLinha_TextChanged(object sender, EventArgs e)
        {
            play.key();
            if (txtLinha.TextLength == pbLinha.Value) { return; }
            if (linha.Substring(pbLinha.Value, 1) == txtLinha.Text.Substring(pbLinha.Value, 1))
            { pbLinha.Value++; } else { return; } verificaLinha();
        }

        private void txtLinha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 8)
            {
                if (txtLinha.TextLength == pbLinha.Value && pbLinha.Value != 0)
                { pbLinha.Value--; }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            play.click();
            vpn.stop();
            timerVpn.Stop();
            Close();
        }

        private void timerVpn_Tick(object sender, EventArgs e)
        {
            verificarVpn();
        }
    }
}
