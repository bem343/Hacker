using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjHacker.forms
{
    public partial class frmSplash : Form
    {

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
                pbCarregamento.Maximum = 3;
                timer.Start();
            }
        #endregion

        #region Tick do Timer
            private void timer_Tick(object sender, EventArgs e)
            {
                tempo++;
                if (tempo > 3)
                {
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();
                    timer.Stop();
                    Hide();
                }
                else { pbCarregamento.Value++; }
            }
        #endregion

    }
}
