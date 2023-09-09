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
            private XmlNodeList dialogList { get; set; }
            private string xml { get; set; }

            private int nDialog = 0;
            private int dialogTime = -1;

            private string nome = "";
            private string dialogo = "";
            private string imageName = "";
            private string[] buttons = null;    
        #endregion

        #region Construtores
            public frmDialogo(string xml)
            {
                this.xml = xml;
                InitializeComponent();
                MyFont.applyff(this.Controls);

                //Define os eventos click dos botões
                btnResponse1.Click += ClickPadrao2;
                btnResponse2.Click += ClickPadrao2;
                btnResponse3.Click += ClickPadrao2;
                btnResponse4.Click += ClickPadrao2;
            }
            public frmDialogo(string nome, string imageName, string dialogo, string[] buttons)
            {
                this.nome = nome;
                this.imageName = imageName;
                this.dialogo = dialogo;
                this.buttons = buttons;
                InitializeComponent();
                MyFont.applyff(this.Controls);

                //Define os eventos click dos botões
                btnResponse1.Click += ClickPadrao;
                btnResponse2.Click += ClickPadrao;
                btnResponse3.Click += ClickPadrao;
                btnResponse4.Click += ClickPadrao;
                btnResponse1.DialogResult = DialogResult.OK;
                btnResponse2.DialogResult = DialogResult.Ignore;
                btnResponse3.DialogResult = DialogResult.No;
                btnResponse4.DialogResult = DialogResult.Yes;
            }
            public frmDialogo(string nome, string imageName, string dialogo, string[] buttons, string color)
            {
                this.nome = nome;
                this.imageName = imageName;
                this.dialogo = dialogo;
                this.buttons = buttons;
                InitializeComponent();
                MyFont.applyff(this.Controls);

                //Adiciona a cor ao diálogo
                lblDialogo.ForeColor = Color.FromName(color);
                lblNome.ForeColor = Color.FromName(color);
                btnResponse1.FlatAppearance.MouseDownBackColor = Color.FromName(color);
                btnResponse2.FlatAppearance.MouseDownBackColor = Color.FromName(color);
                btnResponse3.FlatAppearance.MouseDownBackColor = Color.FromName(color);
                btnResponse4.FlatAppearance.MouseDownBackColor = Color.FromName(color);

                //Define os eventos click dos botões
                btnResponse1.Click += ClickPadrao;
                btnResponse2.Click += ClickPadrao;
                btnResponse3.Click += ClickPadrao;
                btnResponse4.Click += ClickPadrao;
                btnResponse1.DialogResult = DialogResult.OK;
                btnResponse2.DialogResult = DialogResult.Ignore;
                btnResponse3.DialogResult = DialogResult.No;
                btnResponse4.DialogResult = DialogResult.Yes;
            }
        #endregion

        #region Page Load
            private void frmDialogo_Load(object sender, EventArgs e)
            {
                if(xml != null) {
                    XmlDocument arquivo = new XmlDocument();
                    arquivo.Load(xml);
                    dialogList = arquivo.GetElementsByTagName("dialog");
                    dialogLoad();
                }
                else
                {
                    dialogShow();
                }
            }
		#endregion
            
        #region Carrega o diálogo
            private void dialogLoad()
            {
                nome = dialogList[nDialog]["name"].InnerText;
                imageName = dialogList[nDialog]["image"].InnerText;
                dialogo = dialogList[nDialog]["text"].InnerText;

                buttons = new string[4];
                XmlNodeList listaBotoes = dialogList[nDialog]["buttons"].ChildNodes;
                for (int i = 0; i < buttons.Length; i++) {
                    buttons[i] = listaBotoes[i]?.InnerText ?? "";
                }

                Color color;
                if(dialogList[nDialog]["color"] != null)
                    color = Color.FromName(dialogList[nDialog]["color"].InnerText);
                else
                    color = Color.FromArgb(0, 200, 0);

                lblDialogo.ForeColor = color;
                lblNome.ForeColor = color;
                btnResponse1.FlatAppearance.MouseDownBackColor = color;
                btnResponse2.FlatAppearance.MouseDownBackColor = color;
                btnResponse3.FlatAppearance.MouseDownBackColor = color;
                btnResponse4.FlatAppearance.MouseDownBackColor = color;

                dialogShow();
            }
            private void dialogShow()
            {
                if (nome != "")
                    lblNome.Text = nome;
                else
                    lblNome.Visible = false;

                pcbAvatar.Image = Image.FromFile("images/" + imageName);
                if (buttons[0] != "") btnResponse1.Text = buttons[0];
                if (buttons[1] != "") btnResponse2.Text = buttons[1];
                if (buttons[2] != "") btnResponse3.Text = buttons[2];
                if (buttons[3] != "") btnResponse4.Text = buttons[3];
                
                timerDialog.Start();
            }
            private void dialogNext()
            {
                nDialog++;

                if(nDialog < dialogList.Count) {
                    lblDialogo.Text = "";
                    btnResponse1.Visible = false;
                    btnResponse1.Enabled = false;
                    btnResponse2.Visible = false;
                    btnResponse2.Enabled = false;
                    btnResponse3.Visible = false;
                    btnResponse3.Enabled = false;
                    btnResponse4.Visible = false;
                    btnResponse4.Enabled = false;
                    this.Focus();
                    dialogLoad();
                }
                else {
                    this.DialogResult = DialogResult.OK;
                }
            }
        #endregion

        #region Preenche a caixa de diálogo
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
            private void endDialog()
            {
                timerDialog.Stop();
                dialogTime = -1;
                if (buttons[0] != "") {
                    btnResponse1.Visible = true;
                    btnResponse1.Enabled = true;
                }
                if (buttons[1] != "") {
                    btnResponse2.Visible = true;
                    btnResponse2.Enabled = true;
                }
                if (buttons[2] != "") {
                    btnResponse3.Visible = true;
                    btnResponse3.Enabled = true;
                }
                if (buttons[3] != "") {
                    btnResponse4.Visible = true;
                    btnResponse4.Enabled = true;
                }
            }
        #endregion

        #region Eventos padrão dos botões de resposta
            private void ClickPadrao(object sender, EventArgs e)
            {
                Sound.click();
            }
            private void ClickPadrao2(object sender, EventArgs e)
            {
                Sound.click();
                dialogNext();
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
