namespace prjHacker.forms
{
    partial class frmCodigo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.rtbFinal = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErros = new System.Windows.Forms.Label();
            this.lblVpnAtivo = new System.Windows.Forms.Label();
            this.lblVpn = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.timerVpn = new System.Windows.Forms.Timer(this.components);
            this.timerAtaque = new System.Windows.Forms.Timer(this.components);
            this.btnConcluir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnConcluir);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblErros);
            this.groupBox1.Controls.Add(this.lblVpnAtivo);
            this.groupBox1.Controls.Add(this.lblVpn);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblOriginal);
            this.groupBox1.Controls.Add(this.rtbFinal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.groupBox1.Size = new System.Drawing.Size(884, 523);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RevisÃo de CÓdigo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(471, 40);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(311, 29);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Script de: xX_Gamer_Xx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Script Original";
            // 
            // lblOriginal
            // 
            this.lblOriginal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblOriginal.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginal.Location = new System.Drawing.Point(10, 69);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(455, 444);
            this.lblOriginal.TabIndex = 1;
            // 
            // rtbFinal
            // 
            this.rtbFinal.BackColor = System.Drawing.Color.Black;
            this.rtbFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFinal.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbFinal.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.rtbFinal.Location = new System.Drawing.Point(476, 69);
            this.rtbFinal.Name = "rtbFinal";
            this.rtbFinal.Size = new System.Drawing.Size(398, 444);
            this.rtbFinal.TabIndex = 0;
            this.rtbFinal.Text = "";
            this.rtbFinal.TextChanged += new System.EventHandler(this.rtbFinal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label3.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(253, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Erros corrigidos:";
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblErros.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErros.Location = new System.Drawing.Point(477, 0);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(82, 29);
            this.lblErros.TabIndex = 24;
            this.lblErros.Text = "20/20";
            // 
            // lblVpnAtivo
            // 
            this.lblVpnAtivo.AutoSize = true;
            this.lblVpnAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblVpnAtivo.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVpnAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.lblVpnAtivo.Location = new System.Drawing.Point(577, 0);
            this.lblVpnAtivo.Name = "lblVpnAtivo";
            this.lblVpnAtivo.Size = new System.Drawing.Size(181, 29);
            this.lblVpnAtivo.TabIndex = 23;
            this.lblVpnAtivo.Text = "VPN ativo por:";
            this.lblVpnAtivo.Visible = false;
            // 
            // lblVpn
            // 
            this.lblVpn.AutoSize = true;
            this.lblVpn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblVpn.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVpn.Location = new System.Drawing.Point(757, 0);
            this.lblVpn.Name = "lblVpn";
            this.lblVpn.Size = new System.Drawing.Size(75, 29);
            this.lblVpn.TabIndex = 22;
            this.lblVpn.Text = "00:00";
            this.lblVpn.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(867, -1);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(25, 25);
            this.btnSair.TabIndex = 15;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Visible = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            this.btnConcluir.Location = new System.Drawing.Point(745, 474);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(129, 39);
            this.btnConcluir.TabIndex = 26;
            this.btnConcluir.TabStop = false;
            this.btnConcluir.Text = "Finalizar";
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Visible = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // frmCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(904, 536);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCodigo";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCodigo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCodigo_FormClosing);
            this.Load += new System.EventHandler(this.frmCodigo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbFinal;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.Label lblVpnAtivo;
        private System.Windows.Forms.Label lblVpn;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Timer timerVpn;
        private System.Windows.Forms.Timer timerAtaque;
        private System.Windows.Forms.Button btnConcluir;
    }
}