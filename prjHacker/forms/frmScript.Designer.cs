namespace prjHacker.forms
{
    partial class frmScript
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScript));
            this.btnSair = new System.Windows.Forms.Button();
            this.gbControle = new System.Windows.Forms.GroupBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.pcbScript = new System.Windows.Forms.PictureBox();
            this.lstScripts = new System.Windows.Forms.ListBox();
            this.gbControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbScript)).BeginInit();
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
            this.btnSair.Location = new System.Drawing.Point(523, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(25, 25);
            this.btnSair.TabIndex = 12;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbControle
            // 
            this.gbControle.BackColor = System.Drawing.Color.Transparent;
            this.gbControle.Controls.Add(this.btnCarregar);
            this.gbControle.Controls.Add(this.pcbScript);
            this.gbControle.Controls.Add(this.lstScripts);
            this.gbControle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbControle.Font = new System.Drawing.Font("DS-Digital", 21.75F);
            this.gbControle.ForeColor = System.Drawing.Color.White;
            this.gbControle.Location = new System.Drawing.Point(10, 22);
            this.gbControle.Margin = new System.Windows.Forms.Padding(10);
            this.gbControle.Name = "gbControle";
            this.gbControle.Padding = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.gbControle.Size = new System.Drawing.Size(529, 385);
            this.gbControle.TabIndex = 13;
            this.gbControle.TabStop = false;
            this.gbControle.Text = "Selecione o Script";
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.Color.Transparent;
            this.btnCarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCarregar.FlatAppearance.BorderSize = 0;
            this.btnCarregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(363, 203);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(153, 36);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
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
            // lstScripts
            // 
            this.lstScripts.BackColor = System.Drawing.Color.Black;
            this.lstScripts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstScripts.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstScripts.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic);
            this.lstScripts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.lstScripts.FormattingEnabled = true;
            this.lstScripts.ItemHeight = 27;
            this.lstScripts.Location = new System.Drawing.Point(10, 33);
            this.lstScripts.Name = "lstScripts";
            this.lstScripts.Size = new System.Drawing.Size(338, 342);
            this.lstScripts.TabIndex = 0;
            this.lstScripts.SelectedIndexChanged += new System.EventHandler(this.lstScripts_SelectedIndexChanged);
            // 
            // frmScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(549, 417);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gbControle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmScript";
            this.Padding = new System.Windows.Forms.Padding(10, 22, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Script";
            this.Load += new System.EventHandler(this.frmScript_Load);
            this.gbControle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbScript)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gbControle;
        private System.Windows.Forms.ListBox lstScripts;
        private System.Windows.Forms.PictureBox pcbScript;
        private System.Windows.Forms.Button btnCarregar;
    }
}