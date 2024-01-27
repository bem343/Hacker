namespace prjHacker.forms
{
	partial class frmPadrao
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
			this.gbPrincipal = new System.Windows.Forms.GroupBox();
			this.btnSair = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// gbPrincipal
			// 
			this.gbPrincipal.BackColor = System.Drawing.Color.Transparent;
			this.gbPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbPrincipal.Font = new System.Drawing.Font("DS-Digital", 20.25F);
			this.gbPrincipal.ForeColor = System.Drawing.Color.White;
			this.gbPrincipal.Location = new System.Drawing.Point(10, 3);
			this.gbPrincipal.Margin = new System.Windows.Forms.Padding(10);
			this.gbPrincipal.Name = "gbPrincipal";
			this.gbPrincipal.Size = new System.Drawing.Size(884, 523);
			this.gbPrincipal.TabIndex = 17;
			this.gbPrincipal.TabStop = false;
			this.gbPrincipal.Text = "Form";
			// 
			// btnSair
			// 
			this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Ignore;
			this.btnSair.FlatAppearance.BorderSize = 0;
			this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.White;
			this.btnSair.Location = new System.Drawing.Point(875, 4);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(25, 25);
			this.btnSair.TabIndex = 18;
			this.btnSair.TabStop = false;
			this.btnSair.Text = "X";
			this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// frmPadrao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.ClientSize = new System.Drawing.Size(904, 536);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.gbPrincipal);
			this.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "frmPadrao";
			this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmPadrao";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPadrao_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbPrincipal;
		private System.Windows.Forms.Button btnSair;
	}
}