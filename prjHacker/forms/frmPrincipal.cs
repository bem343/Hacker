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

namespace prjHacker.forms
{
    public partial class frmPrincipal : Form
    {

        #region Variáveis
            private int X = 0;
            private int Y = 0;
            private int exitTime = 0;
            private Timer janela = null;
            public static double dinheiro = 0;
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
                janela = new Timer();
                janela.Interval = 1;
                janela.Tick += janela_Tick;
            }
            private void janela_Tick(object sender, EventArgs e)
            {
                this.Location = new Point(Cursor.Position.X - X, Cursor.Position.Y - Y);
            }
        #endregion

        #region Abrir uma caixa de Diálogos
            private DialogResult dialogo(string xml)
            {
                frmDialogo frmDialog = new frmDialogo(xml);
                return frmDialog.ShowDialog();
            }
        #endregion

        #region Abrir configurações
            private void configuracoesTool_Click(object sender, EventArgs e)
            {
                play.click(); new frmConfiguracoes().ShowDialog();
            }
        #endregion

        #region Clicks do stripMenu
            private void novoTool_Click(object sender, EventArgs e)
            {
                play.click();
            }

            private void abrirTool_Click(object sender, EventArgs e)
            {
                play.click(); dialogo("dialogs/welcome.xml");
            }

            private void editarTool_Click(object sender, EventArgs e)
            {
                play.click();
            }
        #endregion
         
        #region Click da lista de trabalhos
            private void lstTrabalhos_Click(object sender, EventArgs e)
            {
                play.click();
            }
        #endregion

        #region Botão Sair personalizado
            private void btnSair_Click(object sender, EventArgs e)
            {
                play.click();
                Timer exitTimer = new Timer();
                exitTimer.Interval = 400;
                exitTimer.Tick += exitTimer_Tick;
                exitTimer.Start();
                Close();
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

    }
}
