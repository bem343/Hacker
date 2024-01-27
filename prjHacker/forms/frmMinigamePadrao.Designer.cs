namespace prjHacker.forms
{
	partial class frmMinigamePadrao
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
			this.timerVpn = new System.Windows.Forms.Timer(this.components);
			this.timerAtaque = new System.Windows.Forms.Timer(this.components);
			this.timerAntiVirus = new System.Windows.Forms.Timer(this.components);
			this.lblAntiVirusAtivo = new System.Windows.Forms.Label();
			this.lblAntiVirus = new System.Windows.Forms.Label();
			this.lblVpnAtivo = new System.Windows.Forms.Label();
			this.lblVpn = new System.Windows.Forms.Label();
			this.SuspendLayout();
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
			// timerAntiVirus
			// 
			this.timerAntiVirus.Interval = 1000;
			// 
			// lblAntiVirusAtivo
			// 
			this.lblAntiVirusAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblAntiVirusAtivo.AutoSize = true;
			this.lblAntiVirusAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.lblAntiVirusAtivo.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAntiVirusAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.lblAntiVirusAtivo.Location = new System.Drawing.Point(467, 0);
			this.lblAntiVirusAtivo.Name = "lblAntiVirusAtivo";
			this.lblAntiVirusAtivo.Size = new System.Drawing.Size(145, 29);
			this.lblAntiVirusAtivo.TabIndex = 20;
			this.lblAntiVirusAtivo.Text = "Anti-Virus:";
			this.lblAntiVirusAtivo.Visible = false;
			// 
			// lblAntiVirus
			// 
			this.lblAntiVirus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblAntiVirus.AutoSize = true;
			this.lblAntiVirus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.lblAntiVirus.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAntiVirus.ForeColor = System.Drawing.Color.White;
			this.lblAntiVirus.Location = new System.Drawing.Point(612, 0);
			this.lblAntiVirus.Name = "lblAntiVirus";
			this.lblAntiVirus.Size = new System.Drawing.Size(75, 29);
			this.lblAntiVirus.TabIndex = 19;
			this.lblAntiVirus.Text = "00:00";
			this.lblAntiVirus.Visible = false;
			// 
			// lblVpnAtivo
			// 
			this.lblVpnAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblVpnAtivo.AutoSize = true;
			this.lblVpnAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.lblVpnAtivo.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVpnAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.lblVpnAtivo.Location = new System.Drawing.Point(713, 0);
			this.lblVpnAtivo.Name = "lblVpnAtivo";
			this.lblVpnAtivo.Size = new System.Drawing.Size(61, 29);
			this.lblVpnAtivo.TabIndex = 22;
			this.lblVpnAtivo.Text = "VPN:";
			this.lblVpnAtivo.Visible = false;
			// 
			// lblVpn
			// 
			this.lblVpn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblVpn.AutoSize = true;
			this.lblVpn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.lblVpn.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVpn.ForeColor = System.Drawing.Color.White;
			this.lblVpn.Location = new System.Drawing.Point(774, 0);
			this.lblVpn.Name = "lblVpn";
			this.lblVpn.Size = new System.Drawing.Size(75, 29);
			this.lblVpn.TabIndex = 21;
			this.lblVpn.Text = "00:00";
			this.lblVpn.Visible = false;
			// 
			// frmMinigamePadrao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(904, 536);
			this.Controls.Add(this.lblVpnAtivo);
			this.Controls.Add(this.lblVpn);
			this.Controls.Add(this.lblAntiVirusAtivo);
			this.Controls.Add(this.lblAntiVirus);
			this.Name = "frmMinigamePadrao";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMinigamePadrao_FormClosing);
			this.Load += new System.EventHandler(this.frmMinigamePadrao_Load);
			this.Controls.SetChildIndex(this.lblAntiVirus, 0);
			this.Controls.SetChildIndex(this.lblAntiVirusAtivo, 0);
			this.Controls.SetChildIndex(this.lblVpn, 0);
			this.Controls.SetChildIndex(this.lblVpnAtivo, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timerVpn;
		private System.Windows.Forms.Timer timerAtaque;
		private System.Windows.Forms.Timer timerAntiVirus;
		private System.Windows.Forms.Label lblAntiVirusAtivo;
		private System.Windows.Forms.Label lblAntiVirus;
		private System.Windows.Forms.Label lblVpnAtivo;
		private System.Windows.Forms.Label lblVpn;
	}
}
