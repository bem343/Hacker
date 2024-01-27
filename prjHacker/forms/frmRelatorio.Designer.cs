namespace prjHacker.forms
{
    partial class frmRelatorio
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
			this.btnOk = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.pcbAvatar = new System.Windows.Forms.PictureBox();
			this.lblExperiencia = new System.Windows.Forms.Label();
			this.lblSkill = new System.Windows.Forms.Label();
			this.lblDinheiro = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.Transparent;
			this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatAppearance.BorderSize = 0;
			this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.ForeColor = System.Drawing.Color.White;
			this.btnOk.Location = new System.Drawing.Point(282, 462);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(129, 38);
			this.btnOk.TabIndex = 15;
			this.btnOk.TabStop = false;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.lblNome);
			this.groupBox1.Controls.Add(this.pcbAvatar);
			this.groupBox1.Controls.Add(this.lblExperiencia);
			this.groupBox1.Controls.Add(this.lblSkill);
			this.groupBox1.Controls.Add(this.lblDinheiro);
			this.groupBox1.Controls.Add(this.lblTitulo);
			this.groupBox1.Controls.Add(this.btnOk);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Font = new System.Drawing.Font("DS-Digital", 20.25F);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(8, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(423, 512);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "RelatÓrio";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.label4.Location = new System.Drawing.Point(53, 333);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 27);
			this.label4.TabIndex = 27;
			this.label4.Text = "P. Skill:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.label5.Location = new System.Drawing.Point(53, 360);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 27);
			this.label5.TabIndex = 26;
			this.label5.Text = "EXP:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.label6.Location = new System.Drawing.Point(53, 306);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 27);
			this.label6.TabIndex = 25;
			this.label6.Text = "Dinheiro:";
			// 
			// lblNome
			// 
			this.lblNome.BackColor = System.Drawing.Color.Transparent;
			this.lblNome.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.lblNome.Location = new System.Drawing.Point(150, 196);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(122, 26);
			this.lblNome.TabIndex = 21;
			this.lblNome.Text = "NAME";
			this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pcbAvatar
			// 
			this.pcbAvatar.BackColor = System.Drawing.Color.Transparent;
			this.pcbAvatar.Location = new System.Drawing.Point(150, 47);
			this.pcbAvatar.Name = "pcbAvatar";
			this.pcbAvatar.Size = new System.Drawing.Size(122, 175);
			this.pcbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbAvatar.TabIndex = 20;
			this.pcbAvatar.TabStop = false;
			// 
			// lblExperiencia
			// 
			this.lblExperiencia.AutoSize = true;
			this.lblExperiencia.ForeColor = System.Drawing.Color.White;
			this.lblExperiencia.Location = new System.Drawing.Point(168, 360);
			this.lblExperiencia.Name = "lblExperiencia";
			this.lblExperiencia.Size = new System.Drawing.Size(81, 27);
			this.lblExperiencia.TabIndex = 19;
			this.lblExperiencia.Text = "+ E 150";
			// 
			// lblSkill
			// 
			this.lblSkill.AutoSize = true;
			this.lblSkill.ForeColor = System.Drawing.Color.White;
			this.lblSkill.Location = new System.Drawing.Point(168, 333);
			this.lblSkill.Name = "lblSkill";
			this.lblSkill.Size = new System.Drawing.Size(81, 27);
			this.lblSkill.TabIndex = 18;
			this.lblSkill.Text = "+ S 130";
			// 
			// lblDinheiro
			// 
			this.lblDinheiro.AutoSize = true;
			this.lblDinheiro.ForeColor = System.Drawing.Color.White;
			this.lblDinheiro.Location = new System.Drawing.Point(168, 306);
			this.lblDinheiro.Name = "lblDinheiro";
			this.lblDinheiro.Size = new System.Drawing.Size(105, 27);
			this.lblDinheiro.TabIndex = 17;
			this.lblDinheiro.Text = "+ $ 50.00";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(0, 225);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(423, 31);
			this.lblTitulo.TabIndex = 16;
			this.lblTitulo.Text = "RevisÃo ConcluÍda!";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmRelatorio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.ClientSize = new System.Drawing.Size(439, 523);
			this.Controls.Add(this.groupBox1);
			this.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "frmRelatorio";
			this.Padding = new System.Windows.Forms.Padding(8, 3, 8, 8);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Relatorio";
			this.Load += new System.EventHandler(this.frmRelatorio_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.Label lblExperiencia;
        private System.Windows.Forms.PictureBox pcbAvatar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}