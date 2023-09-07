
namespace prjHacker.forms
{
	partial class frmNovoScript
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovoScript));
			this.btnSair = new System.Windows.Forms.Button();
			this.gbControle = new System.Windows.Forms.GroupBox();
			this.nLines = new System.Windows.Forms.NumericUpDown();
			this.lblSkill = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbLinguagem = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCriar = new System.Windows.Forms.Button();
			this.pcbScript = new System.Windows.Forms.PictureBox();
			this.gbControle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nLines)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbScript)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.FlatAppearance.BorderSize = 0;
			this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.Transparent;
			this.btnSair.Location = new System.Drawing.Point(523, 2);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(25, 25);
			this.btnSair.TabIndex = 14;
			this.btnSair.TabStop = false;
			this.btnSair.Text = "X";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// gbControle
			// 
			this.gbControle.BackColor = System.Drawing.Color.Transparent;
			this.gbControle.Controls.Add(this.nLines);
			this.gbControle.Controls.Add(this.lblSkill);
			this.gbControle.Controls.Add(this.label3);
			this.gbControle.Controls.Add(this.cbLinguagem);
			this.gbControle.Controls.Add(this.label4);
			this.gbControle.Controls.Add(this.label2);
			this.gbControle.Controls.Add(this.txtNome);
			this.gbControle.Controls.Add(this.label1);
			this.gbControle.Controls.Add(this.btnCriar);
			this.gbControle.Controls.Add(this.pcbScript);
			this.gbControle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbControle.Font = new System.Drawing.Font("DS-Digital", 21.75F);
			this.gbControle.ForeColor = System.Drawing.Color.White;
			this.gbControle.Location = new System.Drawing.Point(10, 3);
			this.gbControle.Margin = new System.Windows.Forms.Padding(10);
			this.gbControle.Name = "gbControle";
			this.gbControle.Padding = new System.Windows.Forms.Padding(10, 4, 10, 10);
			this.gbControle.Size = new System.Drawing.Size(529, 308);
			this.gbControle.TabIndex = 15;
			this.gbControle.TabStop = false;
			this.gbControle.Text = "Novo script";
			// 
			// nLines
			// 
			this.nLines.BackColor = System.Drawing.Color.Black;
			this.nLines.ForeColor = System.Drawing.Color.White;
			this.nLines.Location = new System.Drawing.Point(17, 216);
			this.nLines.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nLines.Name = "nLines";
			this.nLines.Size = new System.Drawing.Size(292, 36);
			this.nLines.TabIndex = 9;
			this.nLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nLines.ValueChanged += new System.EventHandler(this.nLines_ValueChanged);
			this.nLines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nLines_KeyPress);
			// 
			// lblSkill
			// 
			this.lblSkill.AutoSize = true;
			this.lblSkill.BackColor = System.Drawing.Color.Transparent;
			this.lblSkill.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSkill.ForeColor = System.Drawing.Color.White;
			this.lblSkill.Location = new System.Drawing.Point(439, 190);
			this.lblSkill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSkill.Name = "lblSkill";
			this.lblSkill.Size = new System.Drawing.Size(25, 27);
			this.lblSkill.TabIndex = 8;
			this.lblSkill.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(358, 190);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 27);
			this.label3.TabIndex = 6;
			this.label3.Text = "Skill:";
			// 
			// cbLinguagem
			// 
			this.cbLinguagem.BackColor = System.Drawing.Color.Black;
			this.cbLinguagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbLinguagem.ForeColor = System.Drawing.Color.White;
			this.cbLinguagem.FormattingEnabled = true;
			this.cbLinguagem.Location = new System.Drawing.Point(17, 138);
			this.cbLinguagem.Name = "cbLinguagem";
			this.cbLinguagem.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbLinguagem.Size = new System.Drawing.Size(292, 37);
			this.cbLinguagem.TabIndex = 5;
			this.cbLinguagem.SelectedIndexChanged += new System.EventHandler(this.cbLinguagem_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.label4.Location = new System.Drawing.Point(12, 186);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 27);
			this.label4.TabIndex = 3;
			this.label4.Text = "Linhas";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(12, 108);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 27);
			this.label2.TabIndex = 3;
			this.label2.Text = "Linguaguem";
			// 
			// txtNome
			// 
			this.txtNome.BackColor = System.Drawing.Color.Black;
			this.txtNome.ForeColor = System.Drawing.Color.White;
			this.txtNome.Location = new System.Drawing.Point(17, 63);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(292, 36);
			this.txtNome.TabIndex = 4;
			this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(12, 33);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 27);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nome";
			// 
			// btnCriar
			// 
			this.btnCriar.BackColor = System.Drawing.Color.Transparent;
			this.btnCriar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCriar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnCriar.Enabled = false;
			this.btnCriar.FlatAppearance.BorderSize = 0;
			this.btnCriar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnCriar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCriar.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCriar.Location = new System.Drawing.Point(363, 229);
			this.btnCriar.Name = "btnCriar";
			this.btnCriar.Size = new System.Drawing.Size(153, 36);
			this.btnCriar.TabIndex = 2;
			this.btnCriar.Text = "Criar";
			this.btnCriar.UseVisualStyleBackColor = false;
			this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
			// 
			// pcbScript
			// 
			this.pcbScript.Image = ((System.Drawing.Image)(resources.GetObject("pcbScript.Image")));
			this.pcbScript.Location = new System.Drawing.Point(363, 33);
			this.pcbScript.Name = "pcbScript";
			this.pcbScript.Size = new System.Drawing.Size(153, 154);
			this.pcbScript.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbScript.TabIndex = 1;
			this.pcbScript.TabStop = false;
			// 
			// frmNovoScript
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.ClientSize = new System.Drawing.Size(549, 321);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.gbControle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmNovoScript";
			this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmNovoScript";
			this.Load += new System.EventHandler(this.frmNovoScript_Load);
			this.gbControle.ResumeLayout(false);
			this.gbControle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nLines)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbScript)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.GroupBox gbControle;
		private System.Windows.Forms.Button btnCriar;
		private System.Windows.Forms.PictureBox pcbScript;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbLinguagem;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblSkill;
		private System.Windows.Forms.NumericUpDown nLines;
		private System.Windows.Forms.Label label4;
	}
}