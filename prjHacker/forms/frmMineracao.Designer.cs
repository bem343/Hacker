
namespace prjHacker.forms
{
	partial class frmMineracao
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
			this.components = new System.ComponentModel.Container();
			this.btnSair = new System.Windows.Forms.Button();
			this.gbControle = new System.Windows.Forms.GroupBox();
			this.btnConcluir = new System.Windows.Forms.Button();
			this.rtbComandos = new System.Windows.Forms.RichTextBox();
			this.pgProgresso = new System.Windows.Forms.ProgressBar();
			this.pcbBitcoin = new System.Windows.Forms.PictureBox();
			this.lblVpnAtivo = new System.Windows.Forms.Label();
			this.lblVpn = new System.Windows.Forms.Label();
			this.timerVpn = new System.Windows.Forms.Timer(this.components);
			this.timerAtaque = new System.Windows.Forms.Timer(this.components);
			this.timerMineracao = new System.Windows.Forms.Timer(this.components);
			this.timerTexto = new System.Windows.Forms.Timer(this.components);
			this.gbControle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbBitcoin)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSair
			// 
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Ignore;
			this.btnSair.FlatAppearance.BorderSize = 0;
			this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.Transparent;
			this.btnSair.Location = new System.Drawing.Point(731, 4);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(25, 25);
			this.btnSair.TabIndex = 21;
			this.btnSair.TabStop = false;
			this.btnSair.Text = "X";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Visible = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// gbControle
			// 
			this.gbControle.BackColor = System.Drawing.Color.Transparent;
			this.gbControle.Controls.Add(this.btnConcluir);
			this.gbControle.Controls.Add(this.rtbComandos);
			this.gbControle.Controls.Add(this.pgProgresso);
			this.gbControle.Controls.Add(this.pcbBitcoin);
			this.gbControle.Controls.Add(this.lblVpnAtivo);
			this.gbControle.Controls.Add(this.lblVpn);
			this.gbControle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbControle.Font = new System.Drawing.Font("DS-Digital", 21.75F);
			this.gbControle.ForeColor = System.Drawing.Color.White;
			this.gbControle.Location = new System.Drawing.Point(10, 3);
			this.gbControle.Margin = new System.Windows.Forms.Padding(10);
			this.gbControle.Name = "gbControle";
			this.gbControle.Padding = new System.Windows.Forms.Padding(10, 4, 10, 10);
			this.gbControle.Size = new System.Drawing.Size(740, 393);
			this.gbControle.TabIndex = 22;
			this.gbControle.TabStop = false;
			this.gbControle.Text = "MineraÇÃo";
			// 
			// btnConcluir
			// 
			this.btnConcluir.BackColor = System.Drawing.Color.Transparent;
			this.btnConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConcluir.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnConcluir.FlatAppearance.BorderSize = 0;
			this.btnConcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnConcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConcluir.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConcluir.ForeColor = System.Drawing.Color.White;
			this.btnConcluir.Location = new System.Drawing.Point(598, 341);
			this.btnConcluir.Name = "btnConcluir";
			this.btnConcluir.Size = new System.Drawing.Size(129, 39);
			this.btnConcluir.TabIndex = 22;
			this.btnConcluir.TabStop = false;
			this.btnConcluir.Text = "Concluir";
			this.btnConcluir.UseVisualStyleBackColor = false;
			this.btnConcluir.Visible = false;
			this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
			// 
			// rtbComandos
			// 
			this.rtbComandos.BackColor = System.Drawing.Color.Black;
			this.rtbComandos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbComandos.Font = new System.Drawing.Font("DS-Digital", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbComandos.ForeColor = System.Drawing.Color.White;
			this.rtbComandos.Location = new System.Drawing.Point(254, 73);
			this.rtbComandos.Name = "rtbComandos";
			this.rtbComandos.ReadOnly = true;
			this.rtbComandos.Size = new System.Drawing.Size(473, 307);
			this.rtbComandos.TabIndex = 26;
			this.rtbComandos.Text = "";
			// 
			// pgProgresso
			// 
			this.pgProgresso.Location = new System.Drawing.Point(254, 36);
			this.pgProgresso.Name = "pgProgresso";
			this.pgProgresso.Size = new System.Drawing.Size(473, 31);
			this.pgProgresso.TabIndex = 24;
			// 
			// pcbBitcoin
			// 
			this.pcbBitcoin.BackColor = System.Drawing.Color.Transparent;
			this.pcbBitcoin.Image = global::prjHacker.Properties.Resources.Bitcoin_PNG;
			this.pcbBitcoin.Location = new System.Drawing.Point(10, 36);
			this.pcbBitcoin.Name = "pcbBitcoin";
			this.pcbBitcoin.Size = new System.Drawing.Size(238, 344);
			this.pcbBitcoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbBitcoin.TabIndex = 23;
			this.pcbBitcoin.TabStop = false;
			// 
			// lblVpnAtivo
			// 
			this.lblVpnAtivo.AutoSize = true;
			this.lblVpnAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.lblVpnAtivo.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVpnAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.lblVpnAtivo.Location = new System.Drawing.Point(559, 0);
			this.lblVpnAtivo.Name = "lblVpnAtivo";
			this.lblVpnAtivo.Size = new System.Drawing.Size(61, 29);
			this.lblVpnAtivo.TabIndex = 17;
			this.lblVpnAtivo.Text = "VPN:";
			this.lblVpnAtivo.Visible = false;
			// 
			// lblVpn
			// 
			this.lblVpn.AutoSize = true;
			this.lblVpn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.lblVpn.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVpn.Location = new System.Drawing.Point(620, 0);
			this.lblVpn.Name = "lblVpn";
			this.lblVpn.Size = new System.Drawing.Size(75, 29);
			this.lblVpn.TabIndex = 16;
			this.lblVpn.Text = "00:00";
			this.lblVpn.Visible = false;
			// 
			// timerVpn
			// 
			this.timerVpn.Interval = 1000;
			this.timerVpn.Tick += new System.EventHandler(this.timerVpn_Tick);
			// 
			// timerAtaque
			// 
			this.timerAtaque.Interval = 1000;
			this.timerAtaque.Tick += new System.EventHandler(this.timerAtaque_Tick);
			// 
			// timerMineracao
			// 
			this.timerMineracao.Interval = 1000;
			this.timerMineracao.Tick += new System.EventHandler(this.timerMineracao_Tick);
			// 
			// timerTexto
			// 
			this.timerTexto.Interval = 200;
			this.timerTexto.Tick += new System.EventHandler(this.timerTexto_Tick);
			// 
			// frmMineracao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(760, 406);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.gbControle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmMineracao";
			this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmMineracao";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMineracao_FormClosing);
			this.Load += new System.EventHandler(this.frmMineracao_Load);
			this.gbControle.ResumeLayout(false);
			this.gbControle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbBitcoin)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.GroupBox gbControle;
		private System.Windows.Forms.Button btnConcluir;
		private System.Windows.Forms.Label lblVpnAtivo;
		private System.Windows.Forms.Label lblVpn;
		private System.Windows.Forms.Timer timerVpn;
		private System.Windows.Forms.Timer timerAtaque;
		private System.Windows.Forms.ProgressBar pgProgresso;
		private System.Windows.Forms.PictureBox pcbBitcoin;
		private System.Windows.Forms.RichTextBox rtbComandos;
		private System.Windows.Forms.Timer timerMineracao;
		private System.Windows.Forms.Timer timerTexto;
	}
}