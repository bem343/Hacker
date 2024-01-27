namespace prjHacker.forms
{
    partial class frmConfiguracoes
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblVolume = new System.Windows.Forms.Label();
			this.btnMaisVol = new System.Windows.Forms.Button();
			this.btnMenosVol = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSom = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSair = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblVolume);
			this.groupBox1.Controls.Add(this.btnMaisVol);
			this.groupBox1.Controls.Add(this.btnMenosVol);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnSom);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(10, 3);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(348, 420);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ConfiguraÇÕes";
			// 
			// lblVolume
			// 
			this.lblVolume.BackColor = System.Drawing.Color.Transparent;
			this.lblVolume.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVolume.ForeColor = System.Drawing.Color.White;
			this.lblVolume.Location = new System.Drawing.Point(208, 119);
			this.lblVolume.Name = "lblVolume";
			this.lblVolume.Size = new System.Drawing.Size(57, 36);
			this.lblVolume.TabIndex = 5;
			this.lblVolume.Text = "5";
			this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnMaisVol
			// 
			this.btnMaisVol.BackColor = System.Drawing.Color.Transparent;
			this.btnMaisVol.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMaisVol.FlatAppearance.BorderSize = 0;
			this.btnMaisVol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.btnMaisVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMaisVol.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMaisVol.Location = new System.Drawing.Point(271, 119);
			this.btnMaisVol.Name = "btnMaisVol";
			this.btnMaisVol.Size = new System.Drawing.Size(42, 36);
			this.btnMaisVol.TabIndex = 4;
			this.btnMaisVol.Text = ">";
			this.btnMaisVol.UseVisualStyleBackColor = false;
			this.btnMaisVol.Click += new System.EventHandler(this.btnMaisVol_Click);
			// 
			// btnMenosVol
			// 
			this.btnMenosVol.BackColor = System.Drawing.Color.Transparent;
			this.btnMenosVol.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMenosVol.FlatAppearance.BorderSize = 0;
			this.btnMenosVol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.btnMenosVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenosVol.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenosVol.Location = new System.Drawing.Point(160, 119);
			this.btnMenosVol.Name = "btnMenosVol";
			this.btnMenosVol.Size = new System.Drawing.Size(42, 36);
			this.btnMenosVol.TabIndex = 3;
			this.btnMenosVol.Text = "<";
			this.btnMenosVol.UseVisualStyleBackColor = false;
			this.btnMenosVol.Click += new System.EventHandler(this.btnMenosVol_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(25, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 27);
			this.label2.TabIndex = 2;
			this.label2.Text = "Volume";
			// 
			// btnSom
			// 
			this.btnSom.BackColor = System.Drawing.Color.Transparent;
			this.btnSom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSom.FlatAppearance.BorderSize = 0;
			this.btnSom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.btnSom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSom.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSom.Location = new System.Drawing.Point(160, 66);
			this.btnSom.Name = "btnSom";
			this.btnSom.Size = new System.Drawing.Size(153, 36);
			this.btnSom.TabIndex = 1;
			this.btnSom.Text = "true";
			this.btnSom.UseVisualStyleBackColor = false;
			this.btnSom.Click += new System.EventHandler(this.btnSom_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(25, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Som";
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
			this.btnSair.Location = new System.Drawing.Point(339, 4);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(25, 25);
			this.btnSair.TabIndex = 12;
			this.btnSair.TabStop = false;
			this.btnSair.Text = "X";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// frmConfiguracoes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.ClientSize = new System.Drawing.Size(368, 433);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.groupBox1);
			this.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmConfiguracoes";
			this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Configurações";
			this.Load += new System.EventHandler(this.frmConfiguracoes_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMaisVol;
        private System.Windows.Forms.Button btnMenosVol;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnSair;
    }
}