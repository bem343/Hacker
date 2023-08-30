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
	public partial class frmNovoScript : Form
	{

		public static Script script = null;
		public static int skill = 0;

		public frmNovoScript()
		{
			InitializeComponent();
			MyFont.applyff(this.Controls);
		}

		public static void concluirScript()
		{
			My.scriptsAdd(frmNovoScript.script);
			script = null;
			skill = 0;
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			Play.click();
			Close();
		}

		private string extension(string arquivo)
		{
			List<string> extensions = new List<string>()
			{ ".js", ".c", ".cs", ".c++" };
			return arquivo + extensions[cbLinguagem.SelectedIndex];
		}
		private void btnCriar_Click(object sender, EventArgs e)
		{
			Play.click();
			string language = cbLinguagem.SelectedItem.ToString();
			string name = extension(txtNome.Text);
			int lines = (int)nLines.Value;
			script = new Script(language, name, lines);

			Close();
		}

		private void frmNovoScript_Load(object sender, EventArgs e)
		{
			cbLinguagem.Items.Clear();		
			cbLinguagem.Items.Add("js");
			cbLinguagem.Items.Add("c");
			cbLinguagem.Items.Add("c#");
			cbLinguagem.Items.Add("c++");
			cbLinguagem.SelectedIndex = 0;
		}

		#region Verificação dos campos para Liberar o botão de criar
			private void verificaCriar()
			{
				int languageValue = cbLinguagem.SelectedIndex + 1;
				skill = (int)nLines.Value * (languageValue * 100);
				lblSkill.Text = skill.ToString();

				if(skill > frmPrincipal.skill) {
					lblSkill.ForeColor = Color.FromArgb(200, 0, 0);
					btnCriar.Enabled = false;
					return;
				} else { lblSkill.ForeColor = Color.White; }

				//Verifica os campos
				if(nLines.Value > 0) {
					if(txtNome.TextLength > 0) {
						if(cbLinguagem.SelectedIndex > -1) {
							btnCriar.Enabled = true;
							return;
						}
					}
				}
				btnCriar.Enabled = false;
			}
			private void txtNome_TextChanged(object sender, EventArgs e)
			{
				Play.key();
				verificaCriar();
			}
			private void cbLinguagem_SelectedIndexChanged(object sender, EventArgs e)
			{
				Play.select();
				verificaCriar();
			}
			private void nLines_ValueChanged(object sender, EventArgs e)
			{
				Play.select();
				verificaCriar();
			}
			private void nLines_KeyPress(object sender, KeyPressEventArgs e)
			{
				Play.key();
			}
		#endregion

	}
}
