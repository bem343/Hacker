using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjHacker.classes;

namespace prjHacker.forms
{
    public partial class frmRelatorio : Form
    {

        int skill = 0;
        double dinheiro = 0;
        double experiencia = 0;
        string imagem = "sharkgreen.png";
        string titulo = "";

        public frmRelatorio(double dinheiro, int skill, double experiencia, string titulo)
        {
            this.experiencia = experiencia;
            this.dinheiro = dinheiro;
            this.skill = skill;
            this.titulo = titulo;
            DialogResult = DialogResult.Abort;
            InitializeComponent();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            play.congrats();
            if (dinheiro >= 0) { lblDinheiro.Text = "+ $" + dinheiro.ToString("#0.00"); }
            else {
                lblDinheiro.Text = "- $" + (dinheiro * -1).ToString("#0.00");
                lblDinheiro.BackColor = Color.Red;
            }
            if (experiencia >= 0) { lblExperiencia.Text = "+ " + experiencia.ToString("#0.##"); }
            else {
                lblExperiencia.Text = "- " + experiencia.ToString("#0.##");
                lblExperiencia.BackColor = Color.Red;
            }
            if (skill >= 0) { lblSkill.Text = "+ " + skill; lblTitulo.Text = titulo; }
            else {
                lblSkill.Text = "- " + skill; lblTitulo.Text = titulo;
                lblSkill.BackColor = Color.Red;
            }
            pcbAvatar.Image = Image.FromFile("images/" + imagem);
            lblNome.Text = "S.H.A.R.K";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            play.click();
            Close();
        }

    }
}
