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
using System.Xml;

namespace prjHacker.forms
{
    public partial class frmPrincipal : Form
    {

        #region Variáveis
            private int X = 0;
            private int Y = 0;
            private int exitTime = 0;
            private Timer janela = null;
            
            private XmlNodeList quests = null;
            public static double dinheiro = 5;
            public static int experiencia = 0;
            public static int programacao = 0;
        #endregion

        #region Construtores
            public frmPrincipal()
            {
                InitializeComponent();
            }
        #endregion

        #region Page Load
            private void frmPrincipal_Load(object sender, EventArgs e)
            {
                lblDinheiro.Text = "$" + dinheiro.ToString("#0.00");
                lblExperiencia.Text = experiencia.ToString();
                lblProgramacao.Text = programacao.ToString();
                janela = new Timer();
                janela.Interval = 1;
                janela.Tick += janela_Tick;
                XmlDocument arquivo = new XmlDocument();
                arquivo.Load("quests.xml");
                quests = arquivo.GetElementsByTagName("quest");
            }
            private void janela_Tick(object sender, EventArgs e)
            {
                this.Location = new Point(Cursor.Position.X - X, Cursor.Position.Y - Y);
            }
        #endregion

        #region Métodos

            #region Atualizar dinheiro
                private void attDinheiro(double valor)
                {
                    dinheiro += valor;
                    lblDinheiro.Text = "$" + dinheiro.ToString("#0.00");
                }
            #endregion

            #region Fecha os panels da área de trabalho
                private void fecharPanels()
                {
                    foreach (Panel panel in gbAreaDeTrabalho.Controls.OfType<Panel>())
                    {
                        panel.Visible = false;
                    }
                }
            #endregion

            #region verifica o se o Vpn está ativo ou não para mostrar as labels
                private void verificarVpn()
                {
                    if (vpn.isActive)
                    {
                        double segundos = vpn.maximum - vpn.time;
                        TimeSpan time = TimeSpan.FromSeconds(segundos);
                        lblVpn.Text = time.ToString(@"mm\:ss");
                        lblVpnAtivo.Visible = true;
                        lblVpn.Visible = true;
                        btnVpn1.Enabled = false;
                        btnVpn2.Enabled = false;
                        btnVpn3.Enabled = false;
                    }
                    else
                    {
                        lblVpn.Visible = false;
                        lblVpnAtivo.Visible = false;
                        if (dinheiro >= 5) { btnVpn1.Enabled = true; }
                        if (dinheiro >= 10) { btnVpn2.Enabled = true; }
                        if (dinheiro >= 15) { btnVpn3.Enabled = true; }
                    }
                }
            #endregion

            #region Abrir uma caixa de Diálogos
                private bool dialogo(string xml)
                {
                    XmlDocument arquivo = new XmlDocument();
                    arquivo.Load(xml);
                    XmlNodeList listaDialogos = arquivo.GetElementsByTagName("dialog");
                    int nDialog = 0;

                    do
                    {
                        string[] buttons = new string[4];
                        string nome = listaDialogos[nDialog]["name"].InnerText;
                        string imageName = listaDialogos[nDialog]["image"].InnerText;
                        string dialogo = listaDialogos[nDialog]["text"].InnerText;
                        XmlNodeList listaBotoes = listaDialogos[nDialog]["buttons"].ChildNodes;
                        for (int i = 0; i < buttons.Length; i++)
                        {
                            try { buttons[i] = listaBotoes[i].InnerText; }
                            catch { buttons[i] = ""; }
                        }
                        abreDialogo(nome, imageName, dialogo, buttons);
                        nDialog++;
                    } while (nDialog != listaDialogos.Count);
                    return true;
                }
                private DialogResult abreDialogo(string nome, string imageName, string dialogo, string[] buttons)
                {
                    frmDialogo frmDialog = new frmDialogo(nome, imageName, dialogo, buttons);
                    return frmDialog.ShowDialog();
                }
                //private DialogResult dialogo(string xml)
                //{
                //    frmDialogo frmDialog = new frmDialogo(xml);
                //    return frmDialog.ShowDialog();
                //}
            #endregion

            #region Começa uma quest nova, adicionando ela na listBox
                private void startQuest()
                {
                    quest.start(
                            quests[quest.current]["name"].InnerText,
                            quests[quest.current]["instruction"].InnerText);
                    lstTrabalhos.Items.Add(quest.name); play.select();
                }
            #endregion

        #endregion

        #region Clicks do stripMenu
            private void servicos_Click(object sender, EventArgs e)
            {
                play.click();
            }
            private void vpn_click(object sender, EventArgs e)
            {
                play.click();
                verificarVpn();
                fecharPanels();
                panelVpn.Visible = true;
            }
            private void programacaoTool_Click(object sender, EventArgs e)
            {
                play.click();
            }
            private void bitCoins_Tick(object sender, EventArgs e)
            {
                play.click();
            }
            private void configuracoesTool_Click(object sender, EventArgs e)
            {
                play.click(); new frmConfiguracoes().ShowDialog();
            }
        #endregion

        #region Botão Sair personalizado
            private void btnSair_Click(object sender, EventArgs e)
            {
                play.click();
                string[] buttons = new string[4];
                buttons[0] = "Sim";
                buttons[1] = "NÃo";
                buttons[2] = "";
                buttons[3] = "";
                if (abreDialogo("", "pc.jpg", "Tem certeza que deseja sair?", buttons) == DialogResult.OK)
                {
                    Timer exitTimer = new Timer();
                    exitTimer.Interval = 400;
                    exitTimer.Tick += exitTimer_Tick;
                    exitTimer.Start();
                    Close();
                }
            }
            private void exitTimer_Tick(object sender, EventArgs e)
            {
                if (exitTime == 1) { Application.Exit(); }
                exitTime++;
            }
        #endregion

        #region Movimentação da janela
            private void menuStrip_MouseDown(object sender, MouseEventArgs e)
            {
                X = Cursor.Position.X - this.Location.X;
                Y = Cursor.Position.Y - this.Location.Y;
                janela.Start();
            }
            private void menuStrip_MouseUp(object sender, MouseEventArgs e)
            {
                janela.Stop();
            }
        #endregion

        #region Digitação na text box
            private void rtbTeste_TextChanged(object sender, EventArgs e)
            {
                play.key();
            }
        #endregion

        #region Mostra o diálogo de bem-vindo ao abrir o formulário
            private void frmPrincipal_Shown(object sender, EventArgs e)
            {
                if (dialogo("dialogs/welcome.xml"))
                {
                    startQuest();
                    servicosTool.DropDownItems.Add("VPN");
                    servicosTool.DropDownItems[0].Click += vpn_click;
                    servicosTool.DropDownItems[0].BackColor = Color.Black;
                    servicosTool.DropDownItems[0].ForeColor = Color.FromArgb(0, 200, 0);
                }
            }
        #endregion

        #region Quando Seleciona um item da lista de missões
            private void lstTrabalhos_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (lstTrabalhos.SelectedItems.Count <= 0) { return; }
                play.click();
                lblMissao.Text = quest.instruction;
                gbAreaDeTrabalho.Text = "MissÃo: " + quest.name;
                fecharPanels();
                panelMissao.Visible = true;
                //switch (lstTrabalhos.SelectedItem.ToString())
                //{
                //    case "Mascarar IP":
                //        break;
                //}
            }
        #endregion

        #region Limpa a seleção da lista de missões ao tirar o mouse de cima do controle
            private void lstTrabalhos_MouseLeave(object sender, EventArgs e)
            {
                lstTrabalhos.ClearSelected();
            }
        #endregion

        #region Botões do serviço VPN
            private void btnVpn1_Click(object sender, EventArgs e)
            {
                play.click();
                string[] buttons = new string[4];
                buttons[0] = "Sim";
                buttons[1] = "NÃo";
                buttons[2] = "";
                buttons[3] = "";
                if (abreDialogo("", "pc.jpg", "Deseja pagar $5,00 para assinar serviÇo por 1 hora?", buttons) == DialogResult.OK)
                {
                    vpn.sign(60);
                    verificarVpn();
                    attDinheiro(-5);
                    if (quest.current == 1) { q1complete(); }
                }
            }
        #endregion

        #region Conclusão das quests
            private void q1complete()
            {
                quest.complete();
                lstTrabalhos.Items.Remove("Mascarar IP");
                dialogo("dialogs/q1complete.xml");
                
                startQuest();
                programacaoTool.DropDownItems.Add("BitCoins");
                programacaoTool.DropDownItems[0].Click += bitCoins_Tick;
                programacaoTool.DropDownItems[0].BackColor = Color.Black;
                programacaoTool.DropDownItems[0].ForeColor = Color.FromArgb(0, 200, 0);
            }
        #endregion

    }
}
