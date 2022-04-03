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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLinhas = new System.Windows.Forms.Label();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.lblLinha = new System.Windows.Forms.Label();
            this.lblVpnAtivo = new System.Windows.Forms.Label();
            this.lblVpn = new System.Windows.Forms.Label();
            this.pbLinha = new System.Windows.Forms.ProgressBar();
            this.timerVpn = new System.Windows.Forms.Timer(this.components);
            this.timerAtaque = new System.Windows.Forms.Timer(this.components);
            this.gbControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(734, 1);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(25, 25);
            this.btnSair.TabIndex = 14;
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
            this.gbControle.Controls.Add(this.label1);
            this.gbControle.Controls.Add(this.lblLinhas);
            this.gbControle.Controls.Add(this.txtLinha);
            this.gbControle.Controls.Add(this.lblLinha);
            this.gbControle.Controls.Add(this.lblVpnAtivo);
            this.gbControle.Controls.Add(this.lblVpn);
            this.gbControle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbControle.Font = new System.Drawing.Font("DS-Digital", 21.75F);
            this.gbControle.ForeColor = System.Drawing.Color.White;
            this.gbControle.Location = new System.Drawing.Point(10, 3);
            this.gbControle.Margin = new System.Windows.Forms.Padding(10);
            this.gbControle.Name = "gbControle";
            this.gbControle.Padding = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.gbControle.Size = new System.Drawing.Size(740, 183);
            this.gbControle.TabIndex = 15;
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
            this.btnConcluir.Location = new System.Drawing.Point(309, 73);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(129, 39);
            this.btnConcluir.TabIndex = 22;
            this.btnConcluir.TabStop = false;
            this.btnConcluir.Text = "Finalizar";
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Visible = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(156, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Linhas:";
            // 
            // lblLinhas
            // 
            this.lblLinhas.AutoSize = true;
            this.lblLinhas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblLinhas.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinhas.Location = new System.Drawing.Point(249, 0);
            this.lblLinhas.Name = "lblLinhas";
            this.lblLinhas.Size = new System.Drawing.Size(48, 29);
            this.lblLinhas.TabIndex = 20;
            this.lblLinhas.Text = "1/3";
            // 
            // txtLinha
            // 
            this.txtLinha.BackColor = System.Drawing.Color.Black;
            this.txtLinha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLinha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLinha.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.txtLinha.Location = new System.Drawing.Point(10, 114);
            this.txtLinha.Multiline = true;
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(720, 59);
            this.txtLinha.TabIndex = 19;
            this.txtLinha.TextChanged += new System.EventHandler(this.txtLinha_TextChanged);
            this.txtLinha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLinha_KeyDown);
            // 
            // lblLinha
            // 
            this.lblLinha.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLinha.ForeColor = System.Drawing.Color.White;
            this.lblLinha.Location = new System.Drawing.Point(10, 33);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(720, 59);
            this.lblLinha.TabIndex = 18;
            this.lblLinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVpnAtivo
            // 
            this.lblVpnAtivo.AutoSize = true;
            this.lblVpnAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblVpnAtivo.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVpnAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.lblVpnAtivo.Location = new System.Drawing.Point(312, 0);
            this.lblVpnAtivo.Name = "lblVpnAtivo";
            this.lblVpnAtivo.Size = new System.Drawing.Size(181, 29);
            this.lblVpnAtivo.TabIndex = 17;
            this.lblVpnAtivo.Text = "VPN ativo por:";
            this.lblVpnAtivo.Visible = false;
            // 
            // lblVpn
            // 
            this.lblVpn.AutoSize = true;
            this.lblVpn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblVpn.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVpn.Location = new System.Drawing.Point(492, 0);
            this.lblVpn.Name = "lblVpn";
            this.lblVpn.Size = new System.Drawing.Size(75, 29);
            this.lblVpn.TabIndex = 16;
            this.lblVpn.Text = "00:00";
            this.lblVpn.Visible = false;
            // 
            // pbLinha
            // 
            this.pbLinha.Location = new System.Drawing.Point(10, 191);
            this.pbLinha.Name = "pbLinha";
            this.pbLinha.Size = new System.Drawing.Size(740, 10);
            this.pbLinha.TabIndex = 20;
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
            // frmMineracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(760, 208);
            this.Controls.Add(this.pbLinha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gbControle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMineracao";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 22);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mineração de Bitcoins";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMineracao_FormClosing);
            this.Load += new System.EventHandler(this.frmMineracao_Load);
            this.gbControle.ResumeLayout(false);
            this.gbControle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gbControle;
        private System.Windows.Forms.Label lblVpnAtivo;
        private System.Windows.Forms.Label lblVpn;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.ProgressBar pbLinha;
        private System.Windows.Forms.Timer timerVpn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLinhas;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Timer timerAtaque;
    }
}