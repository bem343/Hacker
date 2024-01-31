namespace prjHacker.forms
{
	partial class frmRelatorioQuest
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
			this.label5 = new System.Windows.Forms.Label();
			this.lblNomeQuest = new System.Windows.Forms.Label();
			this.lblExperienciaQuest = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.label5.Location = new System.Drawing.Point(160, 133);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 27);
			this.label5.TabIndex = 36;
			this.label5.Text = "EXP";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNomeQuest
			// 
			this.lblNomeQuest.BackColor = System.Drawing.Color.Transparent;
			this.lblNomeQuest.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeQuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.lblNomeQuest.Location = new System.Drawing.Point(11, 69);
			this.lblNomeQuest.Name = "lblNomeQuest";
			this.lblNomeQuest.Size = new System.Drawing.Size(417, 31);
			this.lblNomeQuest.TabIndex = 34;
			this.lblNomeQuest.Text = "Mascarar IP";
			this.lblNomeQuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblExperienciaQuest
			// 
			this.lblExperienciaQuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblExperienciaQuest.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExperienciaQuest.ForeColor = System.Drawing.Color.White;
			this.lblExperienciaQuest.Location = new System.Drawing.Point(14, 133);
			this.lblExperienciaQuest.Name = "lblExperienciaQuest";
			this.lblExperienciaQuest.Size = new System.Drawing.Size(151, 27);
			this.lblExperienciaQuest.TabIndex = 32;
			this.lblExperienciaQuest.Text = "+ 10.000";
			this.lblExperienciaQuest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(11, 33);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(417, 31);
			this.lblTitulo.TabIndex = 29;
			this.lblTitulo.Text = "Quest ConcluÍda!";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.BackColor = System.Drawing.Color.Transparent;
			this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatAppearance.BorderSize = 0;
			this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.ForeColor = System.Drawing.Color.White;
			this.btnOk.Location = new System.Drawing.Point(290, 128);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(129, 38);
			this.btnOk.TabIndex = 28;
			this.btnOk.TabStop = false;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// frmRelatorioQuest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(439, 186);
			this.Controls.Add(this.lblExperienciaQuest);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblNomeQuest);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.btnOk);
			this.Name = "frmRelatorioQuest";
			this.Padding = new System.Windows.Forms.Padding(8, 3, 8, 8);
			this.Load += new System.EventHandler(this.frmRelatorioQuest_Load);
			this.Controls.SetChildIndex(this.btnOk, 0);
			this.Controls.SetChildIndex(this.lblTitulo, 0);
			this.Controls.SetChildIndex(this.lblNomeQuest, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.lblExperienciaQuest, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblNomeQuest;
		private System.Windows.Forms.Label lblExperienciaQuest;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Button btnOk;
	}
}
