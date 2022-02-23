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
            public static double dinheiro = 15;
            public static double experiencia = 0;
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
                foreach (Panel panel in gbAreaDeTrabalho.Controls.OfType<Panel>())
                {
                    panel.Dock = DockStyle.Fill;
                }
                lblDinheiro.Text = "$" + dinheiro.ToString("#0.00");
                lblExperiencia.Text = experiencia.ToString();
                lblProgramacao.Text = programacao.ToString();
                janela = new Timer { Interval = 1 };
                janela.Tick += janela_Tick;
                XmlDocument arquivo = new XmlDocument();
                arquivo.Load("quests.xml");
                quests = arquivo.GetElementsByTagName("quest");
                Music.initPlayer();
            }
            private void janela_Tick(object sender, EventArgs e)
            {
                this.Location = new Point(Cursor.Position.X - X, Cursor.Position.Y - Y);
            }
        #endregion

        #region Métodos

            #region Atualizar valores do personagem
                private void attDinheiro(double valor)
                {
                    dinheiro += valor;
                    lblDinheiro.Text = "$" + dinheiro.ToString("#0.00");
                }
                private void attProgramacao(int valor)
                {
                    programacao += valor;
                    lblProgramacao.Text = programacao.ToString();
                }
            #endregion

            #region Entrega as recompensas ao jogador
                private void receberRecompensas()
                {
                    double valor = 55;
                    experiencia += valor;
                    double total = experiencia / 100;
                    lblExperiencia.Text = (int.Parse(experiencia.ToString()) / 100).ToString();
                    double quebrado = (total - int.Parse(lblExperiencia.Text));
                    double porcentagem = quebrado * 100;
                    pbExperiencia.Value = int.Parse(porcentagem.ToString());
                    Application.DoEvents();
                    //if (pbExperiencia.Value == 100)
                    //{ pbExperiencia.Value = 0; }
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
                        if(quest.current != 1)
                        {
                            if (dinheiro >= 5) { btnVpn1.Enabled = true; }
                            if (dinheiro >= 10) { btnVpn2.Enabled = true; }
                            if (dinheiro >= 15) { btnVpn3.Enabled = true; }
                        }
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
                            if (listaBotoes[i] != null)
                                buttons[i] = listaBotoes[i].InnerText;
                            else
                                buttons[i] = "";
                        }
                        try { string color = listaDialogos[nDialog]["color"].InnerText;
                        abreDialogo(nome, imageName, dialogo, buttons, color); }
	                    catch { abreDialogo(nome, imageName, dialogo, buttons); }
                        nDialog++;
                    } while (nDialog != listaDialogos.Count);
                    return true;
                }
                private DialogResult abreDialogo(string nome, string imageName, string dialogo, string[] buttons)
                {
                    frmDialogo frmDialog = new frmDialogo(nome, imageName, dialogo, buttons);
                    return frmDialog.ShowDialog();
                }
                private DialogResult abreDialogo(string nome, string imageName, string dialogo, string[] buttons, string color)
                {
                    frmDialogo frmDialog = new frmDialogo(nome, imageName, dialogo, buttons, color);
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
                        quests[quest.current]["instruction"].InnerText
                    );
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
                gbAreaDeTrabalho.Text = "Área de Trabalho";
            }
            private void programacaoTool_Click(object sender, EventArgs e)
            {
                play.click();
            }
            private void bitCoins_Tick(object sender, EventArgs e)
            {
                play.click();
                fecharPanels();
                panelBitcoin.Visible = true;
                gbAreaDeTrabalho.Text = "Área de Trabalho";
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
                if (abreDialogo("S.H.A.R.K", "sharkgreen.png", "Tem certeza que deseja sair?", buttons) == DialogResult.OK)
                {
                    Timer exitTimer = new Timer();
                    exitTimer.Interval = 400;
                    exitTimer.Tick += exitTimer_Tick;
                    exitTimer.Start();
                    Music.stop();
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
                lstTrabalhos.ClearSelected();
            }
        #endregion

        #region Botões do serviço VPN
            private void btnVpn(int tempo, double valor)
            {
                play.click();
                int hora = (tempo / 60);
                string s = "s"; if (hora == 1) { s = ""; }
                string[] buttons = new string[4];
                buttons[0] = "Sim";
                buttons[1] = "NÃo";
                buttons[2] = "";
                buttons[3] = "";
                if ( abreDialogo
                (
                    "S.H.A.R.K",
                    "sharkgreen.png",
                    "Deseja pagar $" + valor.ToString("#0.00") + " para assinar serviÇo por " + hora + " hora" + s + "?",
                    buttons
                ) == DialogResult.OK)
                {
                    vpn.sign(tempo);
                    verificarVpn();
                    attDinheiro(-valor);
                    if (quest.current == 1) { q1complete(); }
                }
            }
            private void btnVpn1_Click(object sender, EventArgs e)
            {
                btnVpn(60, 10);
            }
            private void btnVpn2_Click(object sender, EventArgs e)
            {
                btnVpn(90, 15);
            }
            private void btnVpn3_Click(object sender, EventArgs e)
            {
                btnVpn(120, 20);
            }
        #endregion

        #region Conclusão das quests
            private void qComplete()
            {
                quest.complete();
                receberRecompensas();
                lstTrabalhos.Items.Remove(quests[(quest.current - 1)]["name"].InnerText);
            }
            private void q1complete()
            {
                qComplete();
                dialogo("dialogs/q1complete.xml");
                
                startQuest();
                programacaoTool.DropDownItems.Add("BitCoins");
                programacaoTool.DropDownItems[0].Click += bitCoins_Tick;
                programacaoTool.DropDownItems[0].BackColor = Color.Black;
                programacaoTool.DropDownItems[0].ForeColor = Color.FromArgb(0, 200, 0);
                my.scripts.Add(new script("js", "zeck_script.js", 3));
            }
            private void q2complete()
            {
                qComplete();
                //dialogo("dialogs/q1complete.xml");

                //startQuest();
                //programacaoTool.DropDownItems.Add("BitCoins");
                //programacaoTool.DropDownItems[0].Click += bitCoins_Tick;
                //programacaoTool.DropDownItems[0].BackColor = Color.Black;
                //programacaoTool.DropDownItems[0].ForeColor = Color.FromArgb(0, 200, 0);
            }
        #endregion

        #region Botão de carregar script
            private void btnScript_Click(object sender, EventArgs e)
            {
                if (new frmScript().ShowDialog() == DialogResult.OK)
                {
                    btnMinerar.Enabled = true;
                    pcbScript.Visible = true;
                    lblScript.Visible = true;
                    lblLinesTitle.Visible = true;
                    lblLinesScript.Visible = true;
                    lblScript.Text = my.selectedScript.name;
                    lblLinesScript.Text = my.selectedScript.lines.ToString();
                }
            }
        #endregion
        
        private void btnMinerar_Click(object sender, EventArgs e)
        {
            Music.play("# (4).mp3");
            frmMineracao frmMineracao = new frmMineracao();
            if (frmMineracao.ShowDialog() == DialogResult.OK)
            {
                Music.play("# (5).mp3");
                btnMinerar.Enabled = false;
                pcbScript.Visible = false;
                lblScript.Visible = false;
                lblLinesTitle.Visible = false;
                lblLinesScript.Visible = false;

                int vProgramacao = my.selectedScript.lines * 10;
                double vDinheiro = my.selectedScript.lines * 15.5;

                string mensagem = "MineraÇÃo finalizada! VocÊ conseguiu ";
                mensagem += "$" + vDinheiro.ToString("#0.00") + "  e  ";
                mensagem += vProgramacao + " P. ProgramaÇÃo";
                string[] buttons = new string[4];
                buttons[0] = "Ok";
                buttons[1] = "";
                buttons[2] = "";
                buttons[3] = "";
                abreDialogo("S.H.A.R.K", "sharkgreen.png", mensagem, buttons);

                attProgramacao(vProgramacao);
                attDinheiro(vDinheiro);
                if (quest.current == 2) { q2complete(); }
            }
            else { vpn.stop(); Music.play("# (5).mp3"); }
        }
    }
}
