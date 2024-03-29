﻿using prjHacker.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace prjHacker.forms
{
	public partial class frmPadrao : Form
	{

		#region Contrutores
			public frmPadrao()
			{
				DialogResult = DialogResult.Abort;
				InitializeComponent();
			}
			public frmPadrao(string Titulo)
			{
				DialogResult = DialogResult.Abort;
				InitializeComponent();
				gbPrincipal.Text = Titulo;
			}
			public frmPadrao(string Titulo, bool AllowClose)
			{
				DialogResult = DialogResult.Abort;
				InitializeComponent();
				gbPrincipal.Text = Titulo;
				btnSair.Visible = AllowClose;
			}
		#endregion

		private void btnSair_Click(object sender, EventArgs e)
		{
			Sound.click();
			Close();
		}

		private void frmPadrao_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Impede que a janela seja fechada no ALT-F4
			if (e.CloseReason == CloseReason.UserClosing && this.DialogResult == DialogResult.Cancel)
			{
				e.Cancel = true;
				return;
			}
		}
	}
}
