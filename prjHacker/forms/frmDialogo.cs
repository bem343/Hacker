using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Xml;
using prjHacker.classes;

namespace prjHacker.forms
{
    public partial class frmDialogo : Form
    {

        #region Variáveis
            private string xml = "";
            private string dialogo = "";
            private int nDialog = 0;
            private Timer dialog = null;
            private int dialogTime = -1;
            private XmlNodeList listaDialogos = null;
        #endregion

        #region Construtores
            public frmDialogo(string xml)
            {
                this.xml = xml;
                InitializeComponent();
            }
        #endregion

        #region Carregar um diálogo
            private void carregarDialogo()
            {
                lblNome.Text = listaDialogos[nDialog]["nome"].InnerText;
                dialogo = listaDialogos[nDialog]["texto"].InnerText;
                btnResponse1.Text = listaDialogos[nDialog]["botoes"].FirstChild.InnerText;
                lblDialogo.Text = "";

                btnResponse1.Visible = false;
                dialog = new Timer();
                dialog.Interval = 70;
                dialog.Tick += dialog_Tick;
                dialogTime = -1;
                this.Focus();
                dialog.Start();
            }
        #endregion

        #region Page Load
            private void frmDialogo_Load(object sender, EventArgs e)
            {
                XmlDocument arquivo = new XmlDocument();
                arquivo.Load(xml);
                listaDialogos = arquivo.GetElementsByTagName("dialogo");
                carregarDialogo();
            }
            private void dialog_Tick(object sender, EventArgs e)
            {
                if (dialogTime >= 0 && dialogTime < dialogo.Length)
                {
                    play.key();
                    lblDialogo.Text += dialogo.Substring(dialogTime, 1);
                }
                else{ if (lblDialogo.Text.Length > 0){ endDialog(); } }
                dialogTime++;
            }

            #region Método que termina um diálogo
                private void endDialog()
                {
                    dialog.Stop();
                    btnResponse1.Visible = true;
                }
            #endregion

        #endregion

        #region Evento padrão do Botão de resposta 1
            private void ClickPadrao(object sender, EventArgs e)
            {
                play.click();
                if(nDialog != (listaDialogos.Count - 1))
                {
                    nDialog++; carregarDialogo();
                } else { Close(); }
            }
        #endregion

        #region Termina o diálogo ao precionar a tecla X
            private void frmDialogo_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyValue == 88)
                {
                    endDialog();
                    lblDialogo.Text = dialogo;
                    return;
                }
            }
        #endregion

    }
}
