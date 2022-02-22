using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using prjHacker.classes;

namespace prjHacker.forms
{
    public partial class frmConfiguracoes : Form
    {

        #region Variáveis
            public static bool som = true;
            public static int volume = 100;
            public static int nVolume = 5;
        #endregion

        #region Construtores
            public frmConfiguracoes()
            {
                InitializeComponent();
            }
        #endregion

        #region Page Load
            private void frmConfiguracoes_Load(object sender, EventArgs e)
            {
                verificaBotoes();
            }
        #endregion

        #region Verifica os botões de aumentar e diminuir volume, além de atualizar o valor do mesmo
            private void verificaBotoes()
            {
                if (nVolume == 1) { btnMenosVol.Enabled = false; }
                if (nVolume == 5) { btnMaisVol.Enabled = false; }
                btnSom.Text = som.ToString();
                lblVolume.Text = nVolume.ToString();
            }
        #endregion

        #region Botão Som
            private void btnSom_Click(object sender, EventArgs e)
            {
                som = !som;
                play.click();
                btnSom.Text = som.ToString();
                
                if(som)
                    Music.play();
                else
                    Music.pause();
            }
        #endregion

        #region Botão Sair personalizado
            private void btnSair_Click(object sender, EventArgs e)
            {
                play.click();
                Close();
            }
        #endregion

        #region Botões para alterar volume
            private void btnMenosVol_Click(object sender, EventArgs e)
            {
                if (nVolume > 1)
                {
                    nVolume--;
                    volume -= 20;
                    Music.decreaseVolume();
                    btnMaisVol.Enabled = true;
                    verificaBotoes();
                } else { btnMenosVol.Enabled = false; }
                play.click();
            }
            private void btnMaisVol_Click(object sender, EventArgs e)
            {
                if (nVolume < 5)
                {
                    nVolume++;
                    volume += 20;
                    Music.increaseVolume();
                    btnMenosVol.Enabled = true;
                    verificaBotoes();
                } else { btnMaisVol.Enabled = false; }
                play.click();
            }
        #endregion

    }
}
