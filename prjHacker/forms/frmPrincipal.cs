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
using System.Runtime.InteropServices;

namespace prjHacker.forms
{
    public partial class frmPrincipal : Form
    {

        #region Variáveis
            public static XmlNodeList quests = null;
            public static XmlNodeList users = null;

            public static double dinheiro = 150;
            public static double experiencia = 0;
            public static int skill = 1000;
            //public static int skill = 0;
            public static int nivel = 0;
		#endregion

        #region Construtores
            public frmPrincipal()
            {
                InitializeComponent();
                foreach (Panel panel in gbAreaDeTrabalho.Controls.OfType<Panel>())
                {panel.Dock = DockStyle.Fill;}
                MyFont.applyff(this.Controls);
                MyFont.applyff(this.contextMenuStrip);
            }
        #endregion

        #region Page Load
            private void frmPrincipal_Load(object sender, EventArgs e)
            {
                //Carrega os valores nas labels
                lblDinheiro.Text = "$" + dinheiro.ToString("#0.00");
                lblExperiencia.Text = experiencia.ToString();
                lblProgramacao.Text = skill.ToString();

                Music.initPlayer();
            }
        #endregion

        #region Mostra o diálogo de bem-vindo ao abrir o formulário
            private void frmPrincipal_Shown(object sender, EventArgs e)
            {
                if (dialogo("dialogs/welcome.xml"))
                //if (dialogo("dialogs/teste.xml"))
                {
                    StartQuest(0);
                    vpnMenuItem.Visible = true;
                }
            }
        #endregion

        #region Movimentação da janela
            // Constantes para mensagens do Windows
            private const int WM_NCLBUTTONDOWN = 0xA1;
            private const int HT_CAPTION = 0x2;

            // Importar a função SendMessage do user32.dll
            [DllImport("user32.dll")]
            private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

            // Importar a função ReleaseCapture do user32.dll
            [DllImport("user32.dll")]
            private static extern bool ReleaseCapture();

            // Manipulador de eventos MouseDown para começar a mover a janela
            private void MenuStrip_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }

            // Manipulador de eventos MouseMove para continuar a mover a janela
            private void MenuStrip_MouseMove(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
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
                    if (Vpn.isActive)
                    {
                        lblVpn.Text = Vpn.timeRemaining();
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
                        if(!CurrentQuests.Contains(0))
                        {
                            if (dinheiro >= custoBaseVpn) { btnVpn1.Enabled = true; }
                            if (dinheiro >= custoBaseVpn * 2.5) { btnVpn2.Enabled = true; }
                            if (dinheiro >= custoBaseVpn * 5) { btnVpn3.Enabled = true; }
                        }
                    }
                }
            #endregion

            #region Abrir uma caixa de Diálogos
                private bool dialogo(string xml)
                {
                    XmlDocument arquivo = new XmlDocument(); arquivo.Load(xml);
                    XmlNodeList listaDialogos = arquivo.GetElementsByTagName("dialog");
                    int nDialog = 0; do {
                        string[] buttons = new string[4];
                        string nome = listaDialogos[nDialog]["name"].InnerText;
                        string imageName = listaDialogos[nDialog]["image"].InnerText;
                        string dialogo = listaDialogos[nDialog]["text"].InnerText;
                        XmlNodeList listaBotoes = listaDialogos[nDialog]["buttons"].ChildNodes;
                        for (int i = 0; i < buttons.Length; i++) {
                            buttons[i] = listaBotoes[i]?.InnerText ?? "";
                        } if(listaDialogos[nDialog]["color"] != null) {
                            string color = listaDialogos[nDialog]["color"].InnerText;
                            abreDialogo(nome, imageName, dialogo, buttons, color);
                        } else { abreDialogo(nome, imageName, dialogo, buttons); }
                        nDialog++;
                    } while (nDialog != listaDialogos.Count);
                    return true;
                }
                private DialogResult dialogoComRetorno(string xml)
                {
                    XmlDocument arquivo = new XmlDocument(); arquivo.Load(xml);
                    XmlNodeList listaDialogos = arquivo.GetElementsByTagName("dialog");
                    DialogResult dr = DialogResult.OK; int nDialog = 0; do {
                        string[] buttons = new string[4];
                        string nome = listaDialogos[nDialog]["name"].InnerText;
                        string imageName = listaDialogos[nDialog]["image"].InnerText;
                        string dialogo = listaDialogos[nDialog]["text"].InnerText;
                        XmlNodeList listaBotoes = listaDialogos[nDialog]["buttons"].ChildNodes;
                        for (int i = 0; i < buttons.Length; i++) {
                            buttons[i] = listaBotoes[i]?.InnerText ?? "";
                        } if(listaDialogos[nDialog]["color"] != null) {
                            string color = listaDialogos[nDialog]["color"].InnerText;
                            dr = abreDialogo(nome, imageName, dialogo, buttons, color);
                        } else { dr = abreDialogo(nome, imageName, dialogo, buttons); }
                        if(dr != DialogResult.OK) return dr; nDialog++;
                    } while (nDialog != listaDialogos.Count); return dr;
                }
                private DialogResult dialogoUnico(string xml)
                {
                    XmlDocument arquivo = new XmlDocument(); arquivo.Load(xml);
                    XmlNodeList listaDialogos = arquivo.GetElementsByTagName("dialog");

                    int nDialog = 0; string[] buttons = new string[4];
                    string nome = listaDialogos[nDialog]["name"].InnerText;
                    string imageName = listaDialogos[nDialog]["image"].InnerText;
                    string dialogo = listaDialogos[nDialog]["text"].InnerText;
                    XmlNodeList listaBotoes = listaDialogos[nDialog]["buttons"].ChildNodes;
                    for (int i = 0; i < buttons.Length; i++) {
                        buttons[i] = listaBotoes[i]?.InnerText ?? "";
                    } if(listaDialogos[nDialog]["color"] != null) {
                        string color = listaDialogos[nDialog]["color"].InnerText;
                        return abreDialogo(nome, imageName, dialogo, buttons, color);
                    } else { return abreDialogo(nome, imageName, dialogo, buttons); }
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

        #endregion

        #region Clicks do stripMenu
            //Tools
            private void defaultTool_Click(object sender, EventArgs e)
            {
                Sound.click();
            }
            private void configTool_Click(object sender, EventArgs e)
            {
                Sound.click(); new frmConfiguracoes().ShowDialog();
            }
            //MenuItems
            private void vpnMenuItem_Click(object sender, EventArgs e)
            {
                Sound.click();
                verificarVpn();
                fecharPanels();
                panelVpn.Visible = true;
                gbAreaDeTrabalho.Text = "Área de Trabalho";
            }
            private void revisarCodigosMenuItem_Click(object sender, EventArgs e)
            {
                Sound.click();
                fecharPanels();
                panelCodigos.Visible = true;
                gbAreaDeTrabalho.Text = "Área de Trabalho";
            }
            private void minerarBitcoinMenuItem_Click(object sender, EventArgs e)
            {
                Sound.click();
                fecharPanels();
                panelBitcoin.Visible = true;
                gbAreaDeTrabalho.Text = "Área de Trabalho";
            }
            private void scriptMenuItem_Click(object sender, EventArgs e)
            {
                Sound.click();
                fecharPanels();
                panelScripts.Visible = true;
                gbAreaDeTrabalho.Text = "Área de Trabalho";
            }
            
        #endregion

        #region Clicks do contextMenuStrip
            int contAjuda = 0;
            private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
            {
                switch (contAjuda)
                {
                    case 0:
                        if (dialogoComRetorno("dialogs/ajuda/1.xml") == DialogResult.Cancel)
                            dialogo("dialogs/ajuda/2.xml"); contAjuda++; break;
                    case 1: dialogo("dialogs/ajuda/3.xml"); contAjuda++; break;
                    default: dialogo("dialogs/ajuda/4.xml"); Application.Exit(); break;
                }
            }
        #endregion

        #region Botão Sair personalizado
            private int exitTime = 0;
            private void btnSair_Click(object sender, EventArgs e)
            {
                Sound.click();
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

        #region Quando Seleciona um item da lista de missões
            List<int> CurrentQuests = new List<int>();
            private void lstTrabalhos_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (lstTrabalhos.SelectedItems.Count <= 0) { return; }
                Sound.click();
                int index = CurrentQuests[lstTrabalhos.SelectedIndex];
                lblMissao.Text = quests[index]["instruction"].InnerText;
                gbAreaDeTrabalho.Text = quests[index]["name"].InnerText;
                fecharPanels();
                panelMissao.Visible = true;
                lstTrabalhos.ClearSelected();
            }
        #endregion

        #region Conclusão das quests
            private void CompleteQuest(int QuestI)
            {
                Sound.select();
                attExperiencia(55 + (0.5 * (QuestI + 1)));
                string name = quests[QuestI]["name"].InnerText;
                lstTrabalhos.Items.Remove(name);
                CurrentQuests.Remove(QuestI);
            }
            private void StartQuest(int QuestI)
            {
                string name = quests[QuestI]["name"].InnerText;
                lstTrabalhos.Items.Add(name);
                CurrentQuests.Add(QuestI);
                Sound.select(); 
            }
            private void q0complete()
            {
                CompleteQuest(0);
                dialogo("dialogs/q0complete.xml");
                //dialogo("dialogs/teste.xml");

                StartQuest(1);
                receitasTool.Visible = true;
                minerarBitcoinMenuItem.Visible = true;
                MyScripts.Add(new Script("js", "zeck_script.js", 3));
            }
            private void q1complete()
            {
                CompleteQuest(1);
                dialogo("dialogs/q1complete.xml");
                //dialogo("dialogs/teste.xml");

                StartQuest(2);
                aprenderTool.Visible = true;
                revisarCodigosMenuItem.Visible = true;
            }
            private void q2complete()
            {
                CompleteQuest(2);
                dialogo("dialogs/q2complete.xml");
                //dialogo("dialogs/teste.xml");

                StartQuest(3);
                desenvTool.Visible = true;
                scriptMenuItem.Visible = true;
            }
            private void q3complete()
            {
                CompleteQuest(3);
                dialogo("dialogs/q3complete.xml");
                //dialogo("dialogs/teste.xml");

                //StartQuest(4);
                //addItem(1, "", _Click);
            }
		#endregion

		#region Áreas do jogo (Panels)

		    #region Área de serviço VPN
                private const int tempoBaseVpn = 60;
                private const double custoBaseVpn = 30;                
		        private void btnVpn(int tempo, double valor)
                {
                    Sound.click();
                    int horas = tempo / 60;
                    int minutos = tempo % 60;

                    string dialogo = "Deseja pagar $" + valor.ToString("#0.00");
                    dialogo += " para assinar o serviÇo por " + horas + " hora" + (horas != 1 ? "s" : "");
                    if(minutos > 0) dialogo += " e " + minutos + " minuto" + (minutos != 1 ? "s" : "");
                    dialogo += "?";

                    string[] buttons = new string[4];
                    buttons[0] = "Sim";
                    buttons[1] = "NÃo";
                    buttons[2] = "";
                    buttons[3] = "";
                    
                    if (abreDialogo("S.H.A.R.K", "sharkgreen.png", dialogo, buttons) == DialogResult.OK) {
                        Vpn.sign(tempo);
                        verificarVpn();
                        attDinheiro(-valor);
                        if (CurrentQuests.Contains(0)) q0complete();
                    }
                }
                private void btnVpn1_Click(object sender, EventArgs e)
                {
                    btnVpn(tempoBaseVpn, custoBaseVpn);
                }
                private void btnVpn2_Click(object sender, EventArgs e)
                {
                    btnVpn((int)(tempoBaseVpn * 2.5), custoBaseVpn * 2.5);
                }
                private void btnVpn3_Click(object sender, EventArgs e)
                {
                    btnVpn((int)(tempoBaseVpn * 5), custoBaseVpn * 5);
                }
            #endregion

            #region Área de mineração de Bitcoin
                private void btnScript_Click(object sender, EventArgs e)
                {
                    if (new frmScript().ShowDialog() == DialogResult.OK)
                    {
                        Script script = MyScripts.Current();
                        btnMinerar.Text = "Iniciar MineraÇÃo";
                        btnMinerar.Enabled = true;
                        pcbScript.Visible = true;
                        lblScript.Visible = true;
                        lblLinesTitle.Visible = true;
                        lblLinesScript.Visible = true;
                        lblScript.Text = script.name;
                        lblLinesScript.Text = script.lines.Count.ToString();
                    }
                }
                private void btnMinerar_Click(object sender, EventArgs e)
                {
                    btnScript.Enabled = false;
                    Script script = MyScripts.Current();
                    Music.play("# (6).mp3"); MyScripts.lost = 0;
                    frmMineracao frmMineracao = new frmMineracao(script);
                    if (frmMineracao.ShowDialog() == DialogResult.OK)
                    {
                        Music.play("# (5).mp3");
                        btnMinerar.Enabled = false;
                        pcbScript.Visible = false;
                        lblScript.Visible = false;
                        lblLinesTitle.Visible = false;
                        lblLinesScript.Visible = false;
                        btnScript.Enabled = true;

                        //Recompensas
                        double vDinheiro = (script.lines.Count * 25) * LanguageLevel(script.language);
                        double vExperiencia = script.lines.Count * 6;
                        //Relatório final da mineração
                        frmRelatorio relatorio = new frmRelatorio
                        ((vDinheiro - MyScripts.lost), 0, vExperiencia, "MineraÇÃo ConcluÍda!");
                        relatorio.ShowDialog();

                        attDinheiro(vDinheiro - MyScripts.lost);
                        attExperiencia(vExperiencia);
                        if (CurrentQuests.Contains(1)) q1complete();
                        MyScripts.Remove();
                    } else {
                        Music.play("# (5).mp3"); attDinheiro(-MyScripts.lost);
                        if(frmMineracao.minerado) btnMinerar.Text = "Concluir MineraÇÃo";
                    }
                }
                private int LanguageLevel(string languageTarget)
                {
                    int i = 1;
                    List<string> languages = new List<string>()
                    { "js", "c", "c#", "c++" };
                    foreach(string language in languages) {
                        if(language == languageTarget)
                            return i;
                            i++;
                    } return 0;
                }
            #endregion

            #region Área de Revisar códigos
                int buscarTime = 0;
                int buscarMax = 0;
                int selectedIndex = 0;
                bool primeiraVez = true;
		        Timer buscaTimer = new Timer();
                Random aleatorize = new Random();
                List<object[]> itensRevisao = new List<object[]>();
                private void panelCodigos_VisibleChanged(object sender, EventArgs e)
                {
                    if (primeiraVez)
                    { buscaTimer.Tick += buscaTimer_Tick; primeiraVez = false; }
                    if (panelCodigos.Visible) { listCodigosRefresh(); }
                    else { buscaTimer.Stop(); lstCodigos.Items.Clear(); }
                }
                private void buscaTimer_Tick(object sender, EventArgs e)
                {
                    buscarTime++;
                    if (buscarTime == buscarMax) {
                        buscaTimer.Stop();
                        pcbLoad.Visible = false;
                        btnRefresh.Enabled = true;
                        Sound.complete(); return;
                    }

                    string user = users[aleatorize.Next(users.Count)].InnerText;
                    int erros = aleatorize.Next(3, 5 + (nivel / 3));
                    itensRevisao.Add(new object[2] { user, erros });
                    lstCodigos.Items.Add(user + " - " + erros + " erros");
                    Sound.select(); buscaTimer.Interval = aleatorize.Next(100, 1001);
                }
                private void btnRefresh_Click(object sender, EventArgs e)
                {
                    Sound.click(); listCodigosRefresh();
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
                    itensRevisao.Clear();
                    buscaTimer.Start();
                }
                private void lstCodigos_SelectedIndexChanged(object sender, EventArgs e)
                {
                    Sound.click();
                    if (lstCodigos.SelectedItems.Count > 0) {
                        selectedIndex = lstCodigos.SelectedIndex;
                        btnRevisar.Enabled = true;
                    } lstCodigos.ClearSelected();
                }
                private void btnRevisar_Click(object sender, EventArgs e)
                {
                    Sound.click(); buscaTimer.Stop();
                    btnRefresh.Enabled = false;
                    btnRevisar.Enabled = false;
                    pcbLoad.Visible = false;
                    lstCodigos.Items.Clear();
                    Music.play("# (4).mp3"); MyScripts.lost = 0;

                    string user = itensRevisao[selectedIndex][0].ToString();
                    int erros = int.Parse(itensRevisao[selectedIndex][1].ToString());
                    frmCodigo frmCodigo = new frmCodigo(user, erros);
                    if (frmCodigo.ShowDialog() == DialogResult.OK)
                    {
                        Music.play("# (5).mp3");

                        //Recompensas
                        double vDinheiro = new Random().Next(0, 2) == 1 ? 0 : pagamento();
                        double vExperiencia = erros * 10;
                        int vProgramacao = erros * 22;
                        //Relatório final da revisão
                        frmRelatorio relatorio = new frmRelatorio
                        ((vDinheiro - MyScripts.lost), vProgramacao, vExperiencia, "RevisÃo ConcluÍda!");
                        relatorio.ShowDialog();

                        attProgramacao(vProgramacao);
                        attDinheiro(vDinheiro - MyScripts.lost);
                        attExperiencia(vExperiencia);
                        if (CurrentQuests.Contains(2)) q2complete();
                    } else { Music.play("# (5).mp3"); attDinheiro(-MyScripts.lost); } listCodigosRefresh();
                }
                // Método para gerar o pagamento, caso o usuário deseje
                private double pagamento() { return new Random().Next(2, 6) + new Random().NextDouble(); }
		    #endregion

		    #region Área de criação de códigos
		        private void btnCriarScript_Click(object sender, EventArgs e)
		        {
                    Sound.click();
                    if(new frmNovoScript().ShowDialog() == DialogResult.OK)
                    {
                        Script script = frmNovoScript.script;
                        lblLinesScript2.Text = script.linesP + "/" + script.lines.Count;
                        lblScript2.Text = script.name;
                        pcbScript2.Visible = true;
                        lblScript2.Visible = true;
                        lblLinesTitle2.Visible = true;
                        lblLinesScript2.Visible = true;
                        btnCriarScript.Enabled = false;
                        btnContinuarScript.Visible = true;
                        btnContinuarScript.Text = "Continuar";
                        attProgramacao(-frmNovoScript.skill);
                    } else { return; }

                    Music.play("# (4).mp3"); MyScripts.lost = 0;
                    if (new frmCodigoScript().ShowDialog() == DialogResult.OK)
                    {
                        Music.play("# (5).mp3");
                        btnCriarScript.Enabled = true;
                        btnContinuarScript.Visible = false;
                        pcbScript2.Visible = false;
                        lblScript2.Visible = false;
                        lblLinesTitle2.Visible = false;
                        lblLinesScript2.Visible = false;

                        //Recompensas
                        double vExperiencia = frmNovoScript.script.lines.Count * 5.2;
                        //Relatório final da mineração
                        frmRelatorio relatorio = new frmRelatorio
                        (-MyScripts.lost, 0, vExperiencia, "Script concluÍdo!");
                        relatorio.ShowDialog();

                        attDinheiro(-MyScripts.lost);
                        attExperiencia(vExperiencia);
                        frmNovoScript.concluirScript();
                        if (CurrentQuests.Contains(3)) q3complete();
                    } else {
                        Music.play("# (5).mp3"); attDinheiro(-MyScripts.lost);
                        Script script = frmNovoScript.script;
                        lblLinesScript2.Text = script.linesP + "/" + script.lines.Count;
                        if(script.linesP == script.lines.Count) btnContinuarScript.Text = "Terminar";
                    }

		        }
                private void btnContinuarScript_Click(object sender, EventArgs e)
		        {
                    Sound.click();
                    Music.play("# (4).mp3"); MyScripts.lost = 0;
                    if (new frmCodigoScript().ShowDialog() == DialogResult.OK)
                    {
                        Music.play("# (5).mp3");
                        btnCriarScript.Enabled = true;
                        btnContinuarScript.Visible = false;
                        pcbScript2.Visible = false;
                        lblScript2.Visible = false;
                        lblLinesTitle2.Visible = false;
                        lblLinesScript2.Visible = false;

                        //Recompensas
                        double vExperiencia = frmNovoScript.script.lines.Count * 5.2;
                        //Relatório final da mineração
                        frmRelatorio relatorio = new frmRelatorio
                        (-MyScripts.lost, 0, vExperiencia, "Script concluÍdo!");
                        relatorio.ShowDialog();

                        attDinheiro(-MyScripts.lost);
                        attExperiencia(vExperiencia);
                        frmNovoScript.concluirScript();
                        if (CurrentQuests.Contains(3)) q3complete();
                    } else {
                        Music.play("# (5).mp3"); attDinheiro(-MyScripts.lost);
                        Script script = frmNovoScript.script;
                        lblLinesScript2.Text = script.linesP + "/" + script.lines.Count;
                        if(script.linesP == script.lines.Count) btnContinuarScript.Text = "Terminar";
                    }
		        }
		#endregion

		#endregion

		
	}
}
