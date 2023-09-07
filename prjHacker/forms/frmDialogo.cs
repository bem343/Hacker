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
            private string nome = "";
            private string dialogo = "";
            private string imageName = "";
            private string[] buttons = null;
            private Timer dialog = null;
            private int dialogTime = -1;
        #endregion

        #region Construtores
            public frmDialogo(string nome, string imageName, string dialogo, string[] buttons)
            {
                this.nome = nome;
                this.imageName = imageName;
                this.dialogo = dialogo;
                this.buttons = buttons;
                InitializeComponent();
                MyFont.applyff(this.Controls);
            }
            public frmDialogo(string nome, string imageName, string dialogo, string[] buttons, string color)
            {
                this.nome = nome;
                this.imageName = imageName;
                this.dialogo = dialogo;
                this.buttons = buttons;
                InitializeComponent();
                MyFont.applyff(this.Controls);
                lblDialogo.ForeColor = Color.FromName(color);
                lblNome.ForeColor = Color.FromName(color);
                btnResponse1.FlatAppearance.MouseDownBackColor = Color.FromName(color);
                btnResponse2.FlatAppearance.MouseDownBackColor = Color.FromName(color);
                btnResponse3.FlatAppearance.MouseDownBackColor = Color.FromName(color);
                btnResponse4.FlatAppearance.MouseDownBackColor = Color.FromName(color);
            }
        #endregion

        #region Page Load
            private void frmDialogo_Load(object sender, EventArgs e)
            {
                if (nome != "") { lblNome.Text = nome; }
                else { lblNome.Visible = false; }
                pcbAvatar.Image = Image.FromFile("images/" + imageName);
                if (buttons[0] != "") { btnResponse1.Text = buttons[0]; }
                if (buttons[1] != "") { btnResponse2.Text = buttons[1]; }
                if (buttons[2] != "") { btnResponse3.Text = buttons[2]; }
                if (buttons[3] != "") { btnResponse4.Text = buttons[3]; }

                dialog = new Timer();
                dialog.Interval = 70;
                dialog.Tick += dialog_Tick;
                dialogTime = -1;
                dialog.Start();
            }
            private void dialog_Tick(object sender, EventArgs e)
            {
                if (dialogTime >= 0 && dialogTime < dialogo.Length) {
                    Sound.key();
                    lblDialogo.Text += dialogo.Substring(dialogTime, 1);
                }
                else {
                    if (lblDialogo.Text.Length > 0)
                        endDialog();
                } dialogTime++;
            }

            #region Método que termina um diálogo
                private void endDialog()
                {
                    dialog.Stop();
                    if (buttons[0] != "") { btnResponse1.Visible = true; }
                    if (buttons[1] != "") { btnResponse2.Visible = true; }
                    if (buttons[2] != "") { btnResponse3.Visible = true; }
                    if (buttons[3] != "") { btnResponse4.Visible = true; }
                }
            #endregion

        #endregion

        #region Evento padrão dos botões de resposta
            private void ClickPadrao(object sender, EventArgs e)
            {
                Sound.click();
                Close();
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

		#region Form Closing
		    private void frmDialogo_FormClosing(object sender, FormClosingEventArgs e)
		    {
                //Impede que a janela seja fechada no ALT-F4
			    if (e.CloseReason == CloseReason.UserClosing && this.DialogResult == DialogResult.Cancel)
			    {
				    e.Cancel = true;
				    return;
			    }
		    }
        #endregion
	}
}
