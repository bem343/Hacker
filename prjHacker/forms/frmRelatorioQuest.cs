using prjHacker.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjHacker.forms
{
	public partial class frmRelatorioQuest : prjHacker.forms.frmPadrao
	{

		public frmRelatorioQuest(double exp, string nome) : base("", false)
		{
			DialogResult = DialogResult.Abort;
			InitializeComponent();
			MyFont.applyff(this.Controls);
			lblNomeQuest.Text = nome;
			lblExperienciaQuest.Text = "+ " + exp.ToString("G");
		}
		private void frmRelatorioQuest_Load(object sender, EventArgs e)
		{
			Sound.select();
		}
		private void btnOk_Click(object sender, EventArgs e)
		{
			Sound.click();
			Close();
		}
		
	}
}
