﻿using System;
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
            public static int volume = 5;
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
                btnSom.Text = som.ToString();
                lblVolume.Text = volume.ToString();
            }
        #endregion

        #region Botão Som
            private void btnSom_Click(object sender, EventArgs e)
            {
                som = !som;
                play.click();
                btnSom.Text = som.ToString();
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
                if (volume > 1) { volume--; lblVolume.Text = volume.ToString(); }
                play.click();
            }
            private void btnMaisVol_Click(object sender, EventArgs e)
            {
                if (volume < 5) { volume++; lblVolume.Text = volume.ToString(); }
                play.click();
            }
        #endregion

    }
}
