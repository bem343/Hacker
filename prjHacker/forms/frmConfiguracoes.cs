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
            public const int volPortion = 10;
            public const int volMin = 1;
            public const int volMax = 10;
            public static bool som = true;
            public static int volume = 50;
        #endregion

        #region Construtores
            public frmConfiguracoes()
            {
                InitializeComponent();
                MyFont.applyff(this.Controls);
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
                if (volume/volPortion == volMin) { btnMenosVol.Enabled = false; }
                if (volume/volPortion == volMax) { btnMaisVol.Enabled = false; }
                btnSom.Text = som.ToString();
                lblVolume.Text = (volume / volPortion).ToString();
            }
        #endregion

        #region Botão Som
            private void btnSom_Click(object sender, EventArgs e)
            {
                som = !som;
                Sound.click();
                btnSom.Text = som.ToString();
                Music.play();
            }
        #endregion

        #region Botão Sair personalizado
            private void btnSair_Click(object sender, EventArgs e)
            {
                Sound.click();
                Close();
            }
        #endregion

        #region Botões para alterar volume
            private void btnMenosVol_Click(object sender, EventArgs e)
            {
                if (volume / volPortion > volMin)
                {
                    volume -= volPortion;
                    Music.decreaseVolume();
                    btnMaisVol.Enabled = true;
                    verificaBotoes();
                } else { btnMenosVol.Enabled = false; }
                Sound.click();
            }
            private void btnMaisVol_Click(object sender, EventArgs e)
            {
                if (volume / volPortion < volMax)
                {
                    volume += volPortion;
                    Music.increaseVolume();
                    btnMenosVol.Enabled = true;
                    verificaBotoes();
                } else { btnMaisVol.Enabled = false; }
                Sound.click();
            }
        #endregion

    }
}
