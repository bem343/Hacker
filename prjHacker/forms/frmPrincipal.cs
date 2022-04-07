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
            public static int skill = 0;
            public static int nivel = 0;
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
                lblProgramacao.Text = skill.ToString();
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
                    skill += valor;
                    lblProgramacao.Text = skill.ToString();
                }
                private void attExperiencia(double valor)
                {
                    experiencia += valor;
                    double total = experiencia / 100;
                    nivel = Convert.ToInt32(Math.Floor(total));
                    lblExperiencia.Text = nivel.ToString();
                    double quebrado = (total - nivel);
                    double porcentagem = quebrado * 100;
                    pbExperiencia.Value = Convert.ToInt32(Math.Floor(porcentagem));
                    Application.DoEvents();
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
                            if (dinheiro >= 10) { btnVpn1.Enabled = true; }
                            if (dinheiro >= 15) { btnVpn2.Enabled = true; }
                            if (dinheiro >= 20) { btnVpn3.Enabled = true; }
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

            #region Adiciona um item na dropdown dos itens do menu
                private void addItem(int item, string nome, EventHandler evento)
                {
                    int indice = 0;
                    switch (item)
                    {
                        case 0:
                            servicosTool.DropDownItems.Add(nome);
                            indice = servicosTool.DropDownItems.Count - 1;
                            servicosTool.DropDownItems.Insert(0, servicosTool.DropDownItems[indice]);
                            servicosTool.DropDownItems[0].Click += evento;
                            servicosTool.DropDownItems[0].BackColor = Color.Black;
                            servicosTool.DropDownItems[0].ForeColor = Color.FromArgb(0, 200, 0);
                            break;
                        case 1:
                            programacaoTool.DropDownItems.Add(nome);
                            indice = programacaoTool.DropDownItems.Count - 1;
                            programacaoTool.DropDownItems.Insert(0, programacaoTool.DropDownItems[indice]);
                            programacaoTool.DropDownItems[0].Click += evento;
                            programacaoTool.DropDownItems[0].BackColor = Color.Black;
                            programacaoTool.DropDownItems[0].ForeColor = Color.FromArgb(0, 200, 0);
                            break;
                    }
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
            private void revisarCodigos_Tick(object sender, EventArgs e)
            {
                play.click();
                fecharPanels();
                panelCodigos.Visible = true;
                gbAreaDeTrabalho.Text = "Área de Trabalho";
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
                    Close();
                }
            }
            private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
            {
                Timer exitTimer = new Timer();
                exitTimer.Interval = 400;
                exitTimer.Tick += exitTimer_Tick;
                exitTimer.Start();
                Music.stop();
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
                //if (dialogo("dialogs/welcome.xml"))
                if (dialogo("dialogs/teste.xml"))
                {
                    startQuest();
                    addItem(0, "VPN", vpn_click);
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

        #region Conclusão das quests
            private void qComplete()
            {
                quest.complete();
                attExperiencia(55 + (0.5 * quest.current));
                lstTrabalhos.Items.Remove(quests[(quest.current - 1)]["name"].InnerText);
            }
            private void q1complete()
            {
                qComplete();
                //dialogo("dialogs/q1complete.xml");
                dialogo("dialogs/teste.xml");

                startQuest();
                addItem(1, "BitCoins", bitCoins_Tick);
                my.scriptsAdd(new script("js", "zeck_script.js", 3));
            }
            private void q2complete()
            {
                qComplete();
                //dialogo("dialogs/q2complete.xml");
                dialogo("dialogs/teste.xml");

                startQuest();
                addItem(1, "Revisar cÓdigos", revisarCodigos_Tick);
            }
            private void q3complete()
            {
                qComplete();
                //dialogo("dialogs/q3complete.xml");

                //startQuest();
                //addItem(1, "", );
            }
        #endregion

        #region Área de serviço VPN
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

        #region Área de mineração de Bitcoin
            private void btnScript_Click(object sender, EventArgs e)
            {
                if (new frmScript().ShowDialog() == DialogResult.OK)
                {
                    btnMinerar.Enabled = true;
                    pcbScript.Visible = true;
                    lblScript.Visible = true;
                    lblLinesTitle.Visible = true;
                    lblLinesScript.Visible = true;
                    lblScript.Text = my.currentScript().name;
                    lblLinesScript.Text = my.currentScript().lines.ToString();
                }
            }
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

                    //Recompensas
                    int vProgramacao = my.currentScript().lines * 10;
                    double vDinheiro = my.currentScript().lines * 15.5;
                    double vExperiencia = my.currentScript().lines * 5.2;
                    //Relatório final da mineração
                    string mensagem = "MineraÇÃo finalizada! VocÊ conseguiu: ";
                    mensagem += "$" + vDinheiro.ToString("#0.00") + ";  ";
                    mensagem += vProgramacao + " P. Skill;  ";
                    mensagem += vExperiencia.ToString("#0.0") + " de ExperiÊncia. ";
                    mensagem += "Minerando BitCoins.";
                    string[] buttons = new string[4];
                    buttons[0] = "Ok";
                    buttons[1] = "";
                    buttons[2] = "";
                    buttons[3] = "";
                    abreDialogo("S.H.A.R.K", "sharkgreen.png", mensagem, buttons);

                    attProgramacao(vProgramacao);
                    attDinheiro(vDinheiro);
                    attExperiencia(vExperiencia);
                    if (quest.current == 2) { q2complete(); }
                    my.scriptsRemove();
                } else { Music.play("# (5).mp3"); }
            }
        #endregion

        #region Área de Revisar códigos
            int buscarTime = 0;
            int buscarMax = 0;
            bool primeiraVez = true;
            Timer buscaTimer = new Timer();
            private void panelCodigos_VisibleChanged(object sender, EventArgs e)
            {
                if (primeiraVez)
                { buscaTimer.Tick += buscaTimer_Tick; primeiraVez = false; }
                if (panelCodigos.Visible) { listCodigosRefresh(); }
                else { buscaTimer.Stop(); lstCodigos.Items.Clear(); }
            }
            private void buscaTimer_Tick(object sender, EventArgs e)
            {
                buscarTime++; if (buscarTime == buscarMax)
                {
                    buscaTimer.Stop();
                    pcbLoad.Visible = false;
                    btnRefresh.Enabled = true;
                    play.complete(); return;
                } int erros = new Random().Next(3, 4 + (nivel * 2));
                lstCodigos.Items.Add("xX_Gamer_Xx - " + erros + " erros");
                play.select(); buscaTimer.Interval = new Random().Next(100, 1001);
            }
            private void btnRefresh_Click(object sender, EventArgs e)
            {
                play.click(); listCodigosRefresh();
            }
            private void listCodigosRefresh()
            {
                buscarTime = 0; buscarMax = 6;
                btnRefresh.Enabled = false;
                lstCodigos.ClearSelected();
                lstCodigos.Items.Clear();
                btnRevisar.Enabled = false;
                buscaTimer.Interval = 1000;
                pcbLoad.Visible = true;
                buscaTimer.Start();
            }
            private void lstCodigos_SelectedIndexChanged(object sender, EventArgs e)
            {
                play.click();
                if (lstCodigos.SelectedItems.Count > 0) { btnRevisar.Enabled = true; }
                lstCodigos.ClearSelected();
            }
            private void btnRevisar_Click(object sender, EventArgs e)
            {
                play.click(); buscaTimer.Stop();
                btnRefresh.Enabled = false;
                btnRevisar.Enabled = false;
                pcbLoad.Visible = false;
                lstCodigos.Items.Clear();
                Music.play("# (4).mp3");
                frmCodigo frmCodigo = new frmCodigo(3);
                if (frmCodigo.ShowDialog() == DialogResult.OK)
                {
                    Music.play("# (5).mp3");

                    //Recompensas
                    double vDinheiro = 0; if (
                        new Random().Next(0, 2) == 1 ? true : false
                    ) { vDinheiro = 2.5; }
                    double vExperiencia = 80;
                    int vProgramacao = 300;
                    //Relatório final da mineração
                    string mensagem = "RevisÃo ConcluÍda! VocÊ conseguiu: ";
                    mensagem += "$" + vDinheiro.ToString("#0.00") + ";  ";
                    mensagem += vProgramacao + " P. Skill;  ";
                    mensagem += vExperiencia.ToString("#0.0") + " de ExperiÊncia. ";
                    mensagem += "Revisando CÓdigos";
                    string[] buttons = new string[4];
                    buttons[0] = "Ok";
                    buttons[1] = "";
                    buttons[2] = "";
                    buttons[3] = "";
                    abreDialogo("S.H.A.R.K", "sharkgreen.png", mensagem, buttons);

                    attProgramacao(vProgramacao);
                    attDinheiro(vDinheiro);
                    attExperiencia(vExperiencia);
                    if (quest.current == 3) { q3complete(); }
                } else { Music.play("# (5).mp3"); } listCodigosRefresh();
            }
        #endregion

    }
}
