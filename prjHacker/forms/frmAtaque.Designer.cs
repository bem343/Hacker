namespace prjHacker.forms
{
    partial class frmAtaque
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAtaque = new System.Windows.Forms.ProgressBar();
            this.btnContraAtaque = new System.Windows.Forms.Button();
            this.pcbAvatar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbAtaque);
            this.groupBox1.Controls.Add(this.btnContraAtaque);
            this.groupBox1.Controls.Add(this.pcbAvatar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ATAQUE HACKER!";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "K.R.A.H.S";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAtaque
            // 
            this.pbAtaque.ForeColor = System.Drawing.Color.Black;
            this.pbAtaque.Location = new System.Drawing.Point(8, 222);
            this.pbAtaque.Maximum = 30;
            this.pbAtaque.Name = "pbAtaque";
            this.pbAtaque.Size = new System.Drawing.Size(373, 10);
            this.pbAtaque.TabIndex = 6;
            // 
            // btnContraAtaque
            // 
            this.btnContraAtaque.BackColor = System.Drawing.Color.Transparent;
            this.btnContraAtaque.FlatAppearance.BorderSize = 0;
            this.btnContraAtaque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContraAtaque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnContraAtaque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContraAtaque.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContraAtaque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnContraAtaque.Location = new System.Drawing.Point(157, 29);
            this.btnContraAtaque.Name = "btnContraAtaque";
            this.btnContraAtaque.Size = new System.Drawing.Size(225, 183);
            this.btnContraAtaque.TabIndex = 5;
            this.btnContraAtaque.TabStop = false;
            this.btnContraAtaque.Text = "Contra-Ataque";
            this.btnContraAtaque.UseVisualStyleBackColor = false;
            this.btnContraAtaque.Click += new System.EventHandler(this.btnContraAtaque_Click);
            // 
            // pcbAvatar
            // 
            this.pcbAvatar.Image = global::prjHacker.Properties.Resources.sharkred;
            this.pcbAvatar.Location = new System.Drawing.Point(8, 29);
            this.pcbAvatar.Name = "pcbAvatar";
            this.pcbAvatar.Size = new System.Drawing.Size(143, 183);
            this.pcbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAvatar.TabIndex = 4;
            this.pcbAvatar.TabStop = false;
            // 
            // frmAtaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(406, 250);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAtaque";
            this.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmAtaque";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAtaque_FormClosing);
            this.Load += new System.EventHandler(this.frmAtaque_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbAtaque;
        private System.Windows.Forms.Button btnContraAtaque;
        private System.Windows.Forms.PictureBox pcbAvatar;
    }
}