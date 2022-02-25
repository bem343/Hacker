namespace prjHacker.forms
{
    partial class frmDialogo
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
            this.lblNome = new System.Windows.Forms.Label();
            this.pcbAvatar = new System.Windows.Forms.PictureBox();
            this.btnResponse4 = new System.Windows.Forms.Button();
            this.btnResponse3 = new System.Windows.Forms.Button();
            this.btnResponse2 = new System.Windows.Forms.Button();
            this.btnResponse1 = new System.Windows.Forms.Button();
            this.lblDialogo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.pcbAvatar);
            this.groupBox1.Controls.Add(this.btnResponse4);
            this.groupBox1.Controls.Add(this.btnResponse3);
            this.groupBox1.Controls.Add(this.btnResponse2);
            this.groupBox1.Controls.Add(this.btnResponse1);
            this.groupBox1.Controls.Add(this.lblDialogo);
            this.groupBox1.Font = new System.Drawing.Font("DS-Digital", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(1, -4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(689, 208);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(14, 168);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(122, 26);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "NAME";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbAvatar
            // 
            this.pcbAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pcbAvatar.Location = new System.Drawing.Point(14, 19);
            this.pcbAvatar.Name = "pcbAvatar";
            this.pcbAvatar.Size = new System.Drawing.Size(122, 175);
            this.pcbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAvatar.TabIndex = 7;
            this.pcbAvatar.TabStop = false;
            // 
            // btnResponse4
            // 
            this.btnResponse4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResponse4.FlatAppearance.BorderSize = 0;
            this.btnResponse4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnResponse4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResponse4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponse4.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponse4.ForeColor = System.Drawing.Color.White;
            this.btnResponse4.Location = new System.Drawing.Point(142, 156);
            this.btnResponse4.Name = "btnResponse4";
            this.btnResponse4.Size = new System.Drawing.Size(129, 38);
            this.btnResponse4.TabIndex = 13;
            this.btnResponse4.TabStop = false;
            this.btnResponse4.Text = "Ok";
            this.btnResponse4.Visible = false;
            this.btnResponse4.Click += new System.EventHandler(this.ClickPadrao);
            // 
            // btnResponse3
            // 
            this.btnResponse3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResponse3.FlatAppearance.BorderSize = 0;
            this.btnResponse3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnResponse3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResponse3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponse3.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponse3.ForeColor = System.Drawing.Color.White;
            this.btnResponse3.Location = new System.Drawing.Point(277, 156);
            this.btnResponse3.Name = "btnResponse3";
            this.btnResponse3.Size = new System.Drawing.Size(129, 38);
            this.btnResponse3.TabIndex = 12;
            this.btnResponse3.TabStop = false;
            this.btnResponse3.Text = "Ok";
            this.btnResponse3.Visible = false;
            this.btnResponse3.Click += new System.EventHandler(this.ClickPadrao);
            // 
            // btnResponse2
            // 
            this.btnResponse2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResponse2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnResponse2.FlatAppearance.BorderSize = 0;
            this.btnResponse2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnResponse2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResponse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponse2.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponse2.ForeColor = System.Drawing.Color.White;
            this.btnResponse2.Location = new System.Drawing.Point(412, 156);
            this.btnResponse2.Name = "btnResponse2";
            this.btnResponse2.Size = new System.Drawing.Size(129, 38);
            this.btnResponse2.TabIndex = 11;
            this.btnResponse2.TabStop = false;
            this.btnResponse2.Text = "Ok";
            this.btnResponse2.Visible = false;
            this.btnResponse2.Click += new System.EventHandler(this.ClickPadrao);
            // 
            // btnResponse1
            // 
            this.btnResponse1.BackColor = System.Drawing.Color.Transparent;
            this.btnResponse1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResponse1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnResponse1.FlatAppearance.BorderSize = 0;
            this.btnResponse1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnResponse1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResponse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponse1.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponse1.ForeColor = System.Drawing.Color.White;
            this.btnResponse1.Location = new System.Drawing.Point(547, 156);
            this.btnResponse1.Name = "btnResponse1";
            this.btnResponse1.Size = new System.Drawing.Size(129, 38);
            this.btnResponse1.TabIndex = 10;
            this.btnResponse1.TabStop = false;
            this.btnResponse1.Text = "Ok";
            this.btnResponse1.UseVisualStyleBackColor = false;
            this.btnResponse1.Visible = false;
            this.btnResponse1.Click += new System.EventHandler(this.ClickPadrao);
            // 
            // lblDialogo
            // 
            this.lblDialogo.BackColor = System.Drawing.Color.Transparent;
            this.lblDialogo.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Italic);
            this.lblDialogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.lblDialogo.Location = new System.Drawing.Point(142, 19);
            this.lblDialogo.Name = "lblDialogo";
            this.lblDialogo.Size = new System.Drawing.Size(534, 134);
            this.lblDialogo.TabIndex = 14;
            // 
            // frmDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(691, 204);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDialogo";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDialogo";
            this.Load += new System.EventHandler(this.frmDialogo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDialogo_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResponse4;
        private System.Windows.Forms.Button btnResponse3;
        private System.Windows.Forms.Button btnResponse2;
        private System.Windows.Forms.Button btnResponse1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbAvatar;
        private System.Windows.Forms.Label lblDialogo;

    }
}