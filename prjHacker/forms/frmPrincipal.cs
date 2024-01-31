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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace prjHacker.forms
{
    public partial class frmPrincipal : Form
    {

        #region Variáveis
            private Timer exitTimer = new Timer();
            public static XmlNodeList quests = null;
            public static XmlNodeList users = null;
            public static XmlNodeList classes = null;
            public static XmlNodeList languages = null;
            Random r = new Random();

            public static double dinheiro = 150;
            public static double experiencia = 0;
            public static int skill = 2000;
            //public static int skill = 0;
            public static int nivel = 0;
            public static double languageLevel = 0;
		#endregion

        #region Construtores
            public frmPrincipal()
            {
                this.DialogResult = DialogResult.Abort;
                
                InitializeComponent();
                MyFont.applyff(this.Controls);
                MyFont.applyff(this.contextMenuStrip);

                //Muda o tamanho da fonte da grid (Porque ela fica mudando sozinha)
                Font fBase = (Font)gvCursos.DefaultCellStyle.Font.Clone();
			    gvCursos.DefaultCellStyle.Font = new Font(MyFont.select(), 18, fBase.Style);
                fBase = (Font)gvCursos.ColumnHeadersDefaultCellStyle.Font.Clone();
			    gvCursos.ColumnHeadersDefaultCellStyle.Font = new Font(MyFont.select(), 18, fBase.Style);

                exitTimer.Interval = 100;
                exitTimer.Tick += ExitTimer_Tick;

                foreach (Panel panel in gbAreaDeTrabalho.Controls.OfType<Panel>())
                {panel.Dock = DockStyle.Fill;}

                //Só para teste
                panelCursos.Visible = true;
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
                abreDialogo("dialogs/welcome.xml");
                StartQuest(0);
                vpnMenuItem.Visible = true;
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
                        if(!Quest.IsCurrent(0))
                        {
                            if (dinheiro >= custoBaseVpn) { btnVpn1.Enabled = true; }
                            if (dinheiro >= custoBaseVpn * 2.5) { btnVpn2.Enabled = true; }
                            if (dinheiro >= custoBaseVpn * 5) { btnVpn3.Enabled = true; }
                        }
                    }
                }
            #endregion

            #region Abrir uma caixa de Diálogos
                private void abreDialogo(string xml)
                {
                    frmDialogo frmDialog = new frmDialogo(xml);
                    frmDialog.ShowDialog();
                }
		        private DialogResult abreDialogo(string nome, string imageName, string dialogo, string[,] buttons)
                {
                    frmDialogo frmDialog = new frmDialogo(nome, imageName, dialogo, buttons);
                    return frmDialog.ShowDialog();
                }
                private DialogResult abreDialogo(string nome, string imageName, string dialogo, string[,] buttons, string color)
                {
                    frmDialogo frmDialog = new frmDialogo(nome, imageName, dialogo, buttons, color);
                    return frmDialog.ShowDialog();
                }
            #endregion

            #region Formatação
                private string formatTime(double time)
		        {
			        TimeSpan timeSpan = TimeSpan.FromSeconds(time);
			        return string.Format("{0:D2}:{1:D2}", (int)timeSpan.TotalMinutes, timeSpan.Seconds);
		        }
            #endregion

        #endregion

        #region Clicks do MenuStrip
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
            private void linguagensMenuItem_Click(object sender, EventArgs e)
		    {
                Sound.click();
                fecharPanels();
                panelCursos.Visible = true;
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
                        //if (dialogoComRetorno("dialogs/ajuda/1.xml") == DialogResult.Ignore)
                        //    dialogo("dialogs/ajuda/2.xml"); contAjuda++;
                        abreDialogo("dialogs/ajuda/0.xml"); contAjuda++; break;
                    case 1: abreDialogo("dialogs/ajuda/3.xml"); contAjuda++; break;
                    default: abreDialogo("dialogs/ajuda/4.xml"); altF4 = false; Close(); break;
                }
            }
        #endregion

        #region Botão Sair personalizado
            private bool altF4 = true;
            
            private void btnSair_Click(object sender, EventArgs e)
            {
                Sound.click();
                string[,] buttons = new string[4, 2];
                buttons[0, 0] = "Sim";
                buttons[1, 0] = "NÃo";
                buttons[2, 0] = "";
                buttons[3, 0] = "";
                if (abreDialogo("S.H.A.R.K", "sharkgreen.png", "Tem certeza que deseja sair?", buttons) == DialogResult.OK)
                {
                    altF4 = false;
                    Close();
                }
            }
            private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
            {
                if(altF4) {
                    e.Cancel = true;
                    return;
                }

                Music.stop();
                exitTimer.Start();
            }
            private void ExitTimer_Tick(object sender, EventArgs e)
            {
                exitTimer.Stop();
                Application.Exit();
            }
        #endregion

        #region Quando Seleciona um item da lista de missões
            private void lstTrabalhos_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (lstTrabalhos.SelectedItems.Count <= 0) { return; }

                Sound.click();

                int index = Quest.QuestIndex(lstTrabalhos.SelectedIndex);

                gbAreaDeTrabalho.Text = "Quest";
                lblTitMissao.Text = quests[index]["name"].InnerText;
                lblMissao.Text = quests[index]["instruction"].InnerText;
                lblExperienciaMissao.Text = "+" + quests[index]["exp"].InnerText;
                
                lblProgressoMissao.Text = Quest.QuestInfo(index, out double CounterProg, out double MaxProg);
                pbMissao.Maximum = (int)MaxProg;
                pbMissao.Value = (int)CounterProg;

                fecharPanels();
                panelMissao.Visible = true;
                Application.DoEvents();

                lstTrabalhos.ClearSelected();
            }
        #endregion

        #region Conclusão das quests
            private void CompleteQuest(int QuestI)
            {
                string name = quests[QuestI]["name"].InnerText;
                double exp = double.Parse(quests[QuestI]["exp"].InnerText);
                lstTrabalhos.Items.Remove(name);
                Quest.Complete(QuestI);

                frmRelatorioQuest relatorio = new frmRelatorioQuest(exp, name);
                relatorio.ShowDialog(); attExperiencia(exp);
            }
            private void StartQuest(int QuestI)
            {
                string name = quests[QuestI]["name"].InnerText;
                string max = quests[QuestI]["objective"]?.InnerText ?? "1";
                int tipo = max.Contains("$")? 1 : 0;
                max = max.Replace("$", "");

                lstTrabalhos.Items.Add(name);
                Quest.Start(new Quest(QuestI, tipo, double.Parse(max)));

                Sound.select(); 
            }
            private void q0complete()
            {
                CompleteQuest(0);
                abreDialogo("dialogs/q0complete.xml");
                //dialogo("dialogs/teste.xml");

                StartQuest(1);
                receitasTool.Visible = true;
                minerarBitcoinMenuItem.Visible = true;
                MyScripts.Add(new Script("js", "zeck_script.js", 3));
            }
            private void q1complete()
            {
                CompleteQuest(1);
                abreDialogo("dialogs/q1complete.xml");
                //dialogo("dialogs/teste.xml");

                StartQuest(2);
                aprenderTool.Visible = true;
                revisarCodigosMenuItem.Visible = true;
            }
            private void q2complete()
            {
                CompleteQuest(2);
                abreDialogo("dialogs/q2complete.xml");
                //dialogo("dialogs/teste.xml");

                StartQuest(3);
                desenvTool.Visible = true;
                scriptMenuItem.Visible = true;
            }
            private void q3complete()
            {
                CompleteQuest(3);
                abreDialogo("dialogs/q3complete.xml");
                //dialogo("dialogs/teste.xml");

                StartQuest(4);
                StartQuest(5);
                StartQuest(6);
            }
            private void q4complete()
            {
                CompleteQuest(4);
            }
            private void q5complete()
            {
                CompleteQuest(5);
                abreDialogo("dialogs/q5complete.xml");
                //dialogo("dialogs/teste.xml");

                StartQuest(7);
                linguagensMenuItem.Visible = true;
            }
            private void q6complete()
            {
                CompleteQuest(6);
            }
		#endregion

		#region Áreas do jogo (Panels)

		    #region Área de serviço VPN
		        private const int tempoBaseVpn = 60;
                private const double custoBaseVpn = 28.70;                
		        private void btnVpn(int tempo, double valor)
                {
                    Sound.click();
                    int horas = tempo / 60;
                    int minutos = tempo % 60;

                    string dialogo = "Deseja pagar $" + valor.ToString("#0.00");
                    dialogo += " para assinar o serviÇo por " + horas + " hora" + (horas != 1 ? "s" : "");
                    if(minutos > 0) dialogo += " e " + minutos + " minuto" + (minutos != 1 ? "s" : "");
                    dialogo += "?";

                    string[,] buttons = new string[4, 2];
                    buttons[0, 0] = "Sim";
                    buttons[1, 0] = "NÃo";
                    buttons[2, 0] = "";
                    buttons[3, 0] = "";
                    
                    if (abreDialogo("S.H.A.R.K", "sharkgreen.png", dialogo, buttons) == DialogResult.OK) {
                        Vpn.sign(tempo);
                        verificarVpn();
                        attDinheiro(-valor);

                        if (Quest.IsCurrent(0))
                            q0complete();
                    }
                }
                private void btnVpn1_Click(object sender, EventArgs e)
                {
                    btnVpn(tempoBaseVpn, custoBaseVpn);
                }
                private void btnVpn2_Click(object sender, EventArgs e)
                {
                    btnVpn((int)(tempoBaseVpn * 2.5), custoBaseVpn * 2.25);
                }
                private void btnVpn3_Click(object sender, EventArgs e)
                {
                    btnVpn((int)(tempoBaseVpn * 5), custoBaseVpn * 4);
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
                    Music.play("# (6).mp3"); frmAtaque.lost = 0;
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
                        double vDinheiro = (script.lines.Count * 25) * returnLanguageLevel(script.language);
                        double vExperiencia = script.lines.Count * 6;
                        //Relatório final da mineração
                        frmRelatorio relatorio = new frmRelatorio
                        ((vDinheiro - frmAtaque.lost), 0, vExperiencia, "MineraÇÃo ConcluÍda!");
                        relatorio.ShowDialog();

                        attDinheiro(vDinheiro - frmAtaque.lost);
                        attExperiencia(vExperiencia);

                        if (Quest.IsCurrent(1))
                            q1complete();

                        if (Quest.IsCurrent(6)) {
                            if(script.lines.Count >= 10)
                                q6complete();
                        }

                        MyScripts.Remove();
                    } else {
                        Music.play("# (5).mp3"); attDinheiro(-frmAtaque.lost);
                        if(frmMineracao.minerado) btnMinerar.Text = "Concluir MineraÇÃo";
                    }
                }
                private int returnLanguageLevel(string languageTarget)
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

                    string user = users[r.Next(users.Count)].InnerText;
                    int erros = r.Next(3, 5 + (nivel / 3));
                    itensRevisao.Add(new object[2] { user, erros });
                    lstCodigos.Items.Add(user + " - " + erros + " erros");
                    Sound.select(); buscaTimer.Interval = r.Next(100, 1001);
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
                    Music.play("# (4).mp3"); frmAtaque.lost = 0;

                    string user = itensRevisao[selectedIndex][0].ToString();
                    int erros = int.Parse(itensRevisao[selectedIndex][1].ToString());
                    frmCodigo frmCodigo = new frmCodigo(user, erros);
                    if (frmCodigo.ShowDialog() == DialogResult.OK)
                    {
                        Music.play("# (5).mp3");

                        //Recompensas
                        double vDinheiro = r.Next(0, 2) == 1 ? 0 : pagamento();
                        double vExperiencia = erros * 10;
                        int vProgramacao = erros * 22;
                        //Relatório final da revisão
                        frmRelatorio relatorio = new frmRelatorio
                        ((vDinheiro - frmAtaque.lost), vProgramacao, vExperiencia, "RevisÃo ConcluÍda!");
                        relatorio.ShowDialog();

                        attProgramacao(vProgramacao);
                        attDinheiro(vDinheiro - frmAtaque.lost);
                        attExperiencia(vExperiencia);

                        if (Quest.IsCurrent(2))
                            q2complete();

                        if (Quest.IsCurrent(4)) {
                            if ((vDinheiro - frmAtaque.lost) > 0)
                                if (Quest.Increment(4, vDinheiro - frmAtaque.lost))
                                    q4complete();
                        }
                    } else { Music.play("# (5).mp3"); attDinheiro(-frmAtaque.lost); } listCodigosRefresh();
                }
                // Método para gerar o pagamento, caso o usuário deseje
                private double pagamento() { return r.Next(2, 6) + r.NextDouble(); }
		    #endregion

		    #region Área de criação de códigos
                private void abrirTelaCriarCodigo()
                {
                    Music.play("# (4).mp3"); frmAtaque.lost = 0;
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
                        (-frmAtaque.lost, 0, vExperiencia, "Script concluÍdo!");
                        relatorio.ShowDialog();

                        attDinheiro(-frmAtaque.lost);
                        attExperiencia(vExperiencia);

                        if (Quest.IsCurrent(5)) {
                            if(frmNovoScript.script.lines.Count >= 2 && frmNovoScript.script.language == "js")
                                if(Quest.Increment(5))
                                    q5complete();
                        }

                        frmNovoScript.concluirScript();

                        if (Quest.IsCurrent(3))
                            q3complete();
                        
                    } else {
                        Music.play("# (5).mp3"); attDinheiro(-frmAtaque.lost);
                        Script script = frmNovoScript.script;
                        lblLinesScript2.Text = script.linesP + "/" + script.lines.Count;
                        if(script.linesP == script.lines.Count) btnContinuarScript.Text = "Terminar";
                    }
                }
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

                    abrirTelaCriarCodigo();
		        }
                private void btnContinuarScript_Click(object sender, EventArgs e)
		        {
                    Sound.click();
                    abrirTelaCriarCodigo();
		        }
		    #endregion

            #region Área de Linguagens (Cursos)
		        private int selectedClass = -1;
		        private void gvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		        {
                    if (e.RowIndex >= 0 && e.ColumnIndex == gvCursos.Columns["clDetalhes"].Index)
                    {
				        Sound.click();
				        selectedClass = (int)gvCursos.Rows[e.RowIndex].Cells["clIndex"].Value;

                        pcbCurso.Image = (Image)gvCursos.Rows[e.RowIndex].Cells["clImage"].Value;
				        lblDescrissaoCurso.Text = classes[selectedClass]["description"].InnerText;
				        lblDuracaoCurso.Text = (string)gvCursos.Rows[e.RowIndex].Cells["clDuracao"].Value;
				        lblValorCurso.Text = (string)gvCursos.Rows[e.RowIndex].Cells["clValor"].Value;
				        lblNomeCurso.Text = (string)gvCursos.Rows[e.RowIndex].Cells["clNome"].Value;

				        panelListaCursos.Dock = DockStyle.None;
				        panelListaCursos.Visible = false;
				        panelCurso.Dock = DockStyle.Top;
				        panelCurso.Visible = true;

				        btnComprarCurso.Visible = !cbCursosComprados.Checked;
				        btnComecarCurso.Visible = cbCursosComprados.Checked;
                        btnComecarCurso.Enabled = true;

				        if (!cbCursosComprados.Checked)
                        {
					        double valor = double.Parse(classes[selectedClass]["cost"].InnerText);
					        btnComprarCurso.Enabled = dinheiro >= valor;
				        }
			        }
		        }
		        private void panelCursos_VisibleChanged(object sender, EventArgs e)
		        {
			        if (panelCursos.Visible)
                    {
				        panelListaCursos.Dock = DockStyle.Top;
				        panelListaCursos.Visible = true;
                    }
		        }
                private void listarCursos(bool comprados)
                {
			        gvCursos.Rows.Clear();
			        for (int i = 0; i < classes.Count; i++)
			        {
				        int language = int.Parse(classes[i]["language"].InnerText);
				        if (languageLevel + 1 == language)
				        {
                            if((comprados && LanguageClass.IsPurchased(i)) || (!comprados && LanguageClass.IsAvaialable(i)))
                            {
						        string name = classes[i]["name"].InnerText;
						        double cost = double.Parse(classes[i]["cost"].InnerText);
						        double duration = double.Parse(classes[i]["duration"].InnerText);

                                if(!comprados)
						            gvCursos.Rows.Add(Properties.Resources.script, i, name, formatTime(duration), "$" + cost.ToString("F2"), "+");
                                else
						            gvCursos.Rows.Add(Properties.Resources.script, i, name, formatTime(duration), "-", ">");
					        }
				        }
			        }
		        }
		        private void panelListaCursos_VisibleChanged(object sender, EventArgs e)
                {
                    if(!panelListaCursos.Visible) { return; }

			        double total = languageLevel / 100;
			        int nivel = Convert.ToInt32(Math.Floor(total));
			        double quebrado = (total - nivel);
			        double porcentagem = quebrado * 100;

			        pbLanguage.Maximum = 100;
                    pbLanguage.Value = Convert.ToInt32(Math.Floor(porcentagem));
			        lblLastLanguage.Text = languages[nivel]["name"].InnerText;
			        lblNextLanguage.Text = languages[nivel + 1]["name"].InnerText;

                    listarCursos(cbCursosComprados.Checked);
		        }
		        private void btnVoltarCurso_Click(object sender, EventArgs e)
		        {
			        Sound.click();
			        panelListaCursos.Dock = DockStyle.Top;
			        panelListaCursos.Visible = true;
			        panelCurso.Dock = DockStyle.None;
			        panelCurso.Visible = false;
		        }
		        private void btnComprarCurso_Click(object sender, EventArgs e)
		        {
			        Sound.click();

			        string dialogo = "Deseja pagar "  + lblValorCurso.Text + " para comprar este curso?";

			        string[,] buttons = new string[4, 2];
			        buttons[0, 0] = "Sim";
			        buttons[1, 0] = "NÃo";
			        buttons[2, 0] = "";
			        buttons[3, 0] = "";

			        if (abreDialogo("S.H.A.R.K", "sharkgreen.png", dialogo, buttons) == DialogResult.OK)
			        {
				        double valor = double.Parse(classes[selectedClass]["cost"].InnerText);
				        attDinheiro(-valor);
				        LanguageClass.Purchase(selectedClass);
						btnComprarCurso.Enabled = false;
			        }
		        }
		        private void btnComecarCurso_Click(object sender, EventArgs e)
		        {
			        Sound.click();

                    //Abrir minigame

                    LanguageClass.Finish(selectedClass);
                    btnComecarCurso.Enabled = false;
		        }
		        private void cbCursosComprados_CheckedChanged(object sender, EventArgs e)
		        {
			        Sound.click();
			        listarCursos(cbCursosComprados.Checked);
		        }
		    #endregion

		#endregion
		
	}
}
