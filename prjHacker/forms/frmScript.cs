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
    public partial class frmScript : Form
    {

        #region Variáveis
            private int selecionado = -1;
        #endregion

        #region Construtores
            public frmScript()
            {
                InitializeComponent();
            }
        #endregion

        private void btnSair_Click(object sender, EventArgs e)
        {
            play.click();
            Close();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            play.click();
            my.selecionarScript(selecionado);
            Close();
        }

        private void lstScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstScripts.SelectedItems.Count <= 0) { return; }
            play.click();
            selecionado = lstScripts.SelectedIndex;
            btnCarregar.Enabled = true;
            lstScripts.ClearSelected();
        }

        private void frmScript_Load(object sender, EventArgs e)
        {
            lstScripts.DataSource = my.scriptNames();
            btnCarregar.Enabled = false;
        }
    }
}
