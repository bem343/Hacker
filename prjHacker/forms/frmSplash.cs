using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using prjHacker.classes;
using System.Xml;

namespace prjHacker.forms
{
    public partial class frmSplash : Form
    {
        
        private XmlDocument arquivo = null;
        private int tempo = 0;

        #region Construtores
            public frmSplash()
            {
                InitializeComponent();
            }
        #endregion

        #region Page Load
            private void frmSplash_Load(object sender, EventArgs e)
            {
                //Carrega as fontes
                MyFont.load(Properties.Resources.DS_DIGI);
                MyFont.applyff(this.Controls);

                //Carrega as quests do xml
                arquivo = new XmlDocument();
                arquivo.Load("quests.xml");
                frmPrincipal.quests = arquivo.GetElementsByTagName("quest");

                //Carrega os users do xml
                arquivo = new XmlDocument();
                arquivo.Load("users.xml");
                frmPrincipal.users = arquivo.GetElementsByTagName("user");

                //Começa um loading fake
                pbCarregamento.Maximum = 30;
                timer.Start();
            }
        #endregion

        #region Tick do Timer
            private void timer_Tick(object sender, EventArgs e)
            {
                tempo++;
                if (tempo > pbCarregamento.Maximum)
                {
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();
                    timer.Stop();
                    this.Hide();
                } else { pbCarregamento.Value++; }
            }
        #endregion

    }
}
