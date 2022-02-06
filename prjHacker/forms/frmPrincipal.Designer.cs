namespace prjHacker.forms
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 14D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProgramacao = new System.Windows.Forms.Label();
            this.lblExperiencia = new System.Windows.Forms.Label();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTrabalhos = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.servicosTool = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracoesTool = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAreaDeTrabalho = new System.Windows.Forms.GroupBox();
            this.panelVpn = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelMissao = new System.Windows.Forms.Panel();
            this.lblMissao = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rtbTeste = new System.Windows.Forms.RichTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.pcbFundo = new System.Windows.Forms.PictureBox();
            this.btnResponse1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.gbAreaDeTrabalho.SuspendLayout();
            this.panelVpn.SuspendLayout();
            this.panelMissao.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblProgramacao);
            this.groupBox1.Controls.Add(this.lblExperiencia);
            this.groupBox1.Controls.Add(this.lblDinheiro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Size = new System.Drawing.Size(286, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Joao Marcus";
            // 
            // lblProgramacao
            // 
            this.lblProgramacao.AutoSize = true;
            this.lblProgramacao.BackColor = System.Drawing.Color.Transparent;
            this.lblProgramacao.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramacao.ForeColor = System.Drawing.Color.White;
            this.lblProgramacao.Location = new System.Drawing.Point(197, 77);
            this.lblProgramacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgramacao.Name = "lblProgramacao";
            this.lblProgramacao.Size = new System.Drawing.Size(25, 27);
            this.lblProgramacao.TabIndex = 7;
            this.lblProgramacao.Text = "0";
            // 
            // lblExperiencia
            // 
            this.lblExperiencia.AutoSize = true;
            this.lblExperiencia.BackColor = System.Drawing.Color.Transparent;
            this.lblExperiencia.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperiencia.ForeColor = System.Drawing.Color.White;
            this.lblExperiencia.Location = new System.Drawing.Point(197, 54);
            this.lblExperiencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExperiencia.Name = "lblExperiencia";
            this.lblExperiencia.Size = new System.Drawing.Size(25, 27);
            this.lblExperiencia.TabIndex = 6;
            this.lblExperiencia.Text = "0";
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.BackColor = System.Drawing.Color.Transparent;
            this.lblDinheiro.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiro.ForeColor = System.Drawing.Color.White;
            this.lblDinheiro.Location = new System.Drawing.Point(197, 32);
            this.lblDinheiro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(76, 27);
            this.lblDinheiro.TabIndex = 5;
            this.lblDinheiro.Text = "$10,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "P. ProgramaÇÃo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "ExperiÊncia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dinheiro: ";
            // 
            // lstTrabalhos
            // 
            this.lstTrabalhos.BackColor = System.Drawing.Color.Black;
            this.lstTrabalhos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstTrabalhos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstTrabalhos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTrabalhos.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTrabalhos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.lstTrabalhos.FormattingEnabled = true;
            this.lstTrabalhos.ItemHeight = 27;
            this.lstTrabalhos.Location = new System.Drawing.Point(10, 33);
            this.lstTrabalhos.Margin = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.lstTrabalhos.Name = "lstTrabalhos";
            this.lstTrabalhos.Size = new System.Drawing.Size(266, 318);
            this.lstTrabalhos.TabIndex = 8;
            this.lstTrabalhos.TabStop = false;
            this.lstTrabalhos.SelectedIndexChanged += new System.EventHandler(this.lstTrabalhos_SelectedIndexChanged);
            this.lstTrabalhos.MouseLeave += new System.EventHandler(this.lstTrabalhos_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lstTrabalhos);
            this.groupBox2.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.groupBox2.Size = new System.Drawing.Size(286, 361);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MissÕes";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Font = new System.Drawing.Font("DS-Digital", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicosTool,
            this.configuracoesTool});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(798, 29);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseDown);
            this.menuStrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseUp);
            // 
            // servicosTool
            // 
            this.servicosTool.BackColor = System.Drawing.Color.Transparent;
            this.servicosTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.servicosTool.Name = "servicosTool";
            this.servicosTool.Size = new System.Drawing.Size(98, 25);
            this.servicosTool.Text = "ServiÇos";
            this.servicosTool.Click += new System.EventHandler(this.servicos_Click);
            // 
            // configuracoesTool
            // 
            this.configuracoesTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.configuracoesTool.Name = "configuracoesTool";
            this.configuracoesTool.Size = new System.Drawing.Size(150, 25);
            this.configuracoesTool.Text = "ConfiguraÇÕes";
            this.configuracoesTool.Click += new System.EventHandler(this.configuracoesTool_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.Black;
            this.contextMenuStrip.Font = new System.Drawing.Font("DS-Digital", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1,
            this.abrirToolStripMenuItem1,
            this.editarToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.ShowImageMargin = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(111, 82);
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(110, 26);
            this.novoToolStripMenuItem1.Text = "Novo";
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(110, 26);
            this.abrirToolStripMenuItem1.Text = "Abrir";
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(110, 26);
            this.editarToolStripMenuItem1.Text = "Editar";
            // 
            // gbAreaDeTrabalho
            // 
            this.gbAreaDeTrabalho.BackColor = System.Drawing.Color.Transparent;
            this.gbAreaDeTrabalho.Controls.Add(this.panelVpn);
            this.gbAreaDeTrabalho.Controls.Add(this.panelMissao);
            this.gbAreaDeTrabalho.Controls.Add(this.panelPrincipal);
            this.gbAreaDeTrabalho.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAreaDeTrabalho.ForeColor = System.Drawing.Color.White;
            this.gbAreaDeTrabalho.Location = new System.Drawing.Point(312, 36);
            this.gbAreaDeTrabalho.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbAreaDeTrabalho.Name = "gbAreaDeTrabalho";
            this.gbAreaDeTrabalho.Padding = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.gbAreaDeTrabalho.Size = new System.Drawing.Size(475, 490);
            this.gbAreaDeTrabalho.TabIndex = 9;
            this.gbAreaDeTrabalho.TabStop = false;
            this.gbAreaDeTrabalho.Text = "Área de trabalho";
            // 
            // panelVpn
            // 
            this.panelVpn.Controls.Add(this.button2);
            this.panelVpn.Controls.Add(this.button1);
            this.panelVpn.Controls.Add(this.btnResponse1);
            this.panelVpn.Controls.Add(this.label8);
            this.panelVpn.Controls.Add(this.label7);
            this.panelVpn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVpn.Location = new System.Drawing.Point(10, 33);
            this.panelVpn.Name = "panelVpn";
            this.panelVpn.Size = new System.Drawing.Size(455, 447);
            this.panelVpn.TabIndex = 2;
            this.panelVpn.Visible = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(0, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(455, 147);
            this.label8.TabIndex = 1;
            this.label8.Text = "Este serviÇo muda o IP da sua mÁquina, alÉm disso É o melhor VPN do mercado, com " +
                "ele vocÊ pode atÉ comprar maconha na deepweb, sem nenhum problema.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "ServiÇo VPN - $5,00/h";
            // 
            // panelMissao
            // 
            this.panelMissao.Controls.Add(this.lblMissao);
            this.panelMissao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.panelMissao.Location = new System.Drawing.Point(10, 33);
            this.panelMissao.Name = "panelMissao";
            this.panelMissao.Size = new System.Drawing.Size(455, 447);
            this.panelMissao.TabIndex = 1;
            this.panelMissao.Visible = false;
            // 
            // lblMissao
            // 
            this.lblMissao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMissao.Location = new System.Drawing.Point(0, 0);
            this.lblMissao.Name = "lblMissao";
            this.lblMissao.Size = new System.Drawing.Size(455, 116);
            this.lblMissao.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.panelPrincipal.Controls.Add(this.chart);
            this.panelPrincipal.Controls.Add(this.rtbTeste);
            this.panelPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.panelPrincipal.Location = new System.Drawing.Point(10, 520);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(455, 447);
            this.panelPrincipal.TabIndex = 0;
            this.panelPrincipal.Visible = false;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            this.chart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.DarkGray;
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackSecondaryColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.DimGray;
            legend1.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            legend1.InterlacedRowsColor = System.Drawing.Color.Transparent;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend";
            legend1.Title = "Legenda";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            legend1.TitleFont = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.GradientLine;
            legend1.TitleSeparatorColor = System.Drawing.Color.DimGray;
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))))};
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend";
            series1.Name = "Execuções";
            dataPoint1.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint1.IsValueShownAsLabel = true;
            dataPoint1.Label = "Cassino";
            dataPoint1.LabelBackColor = System.Drawing.Color.Transparent;
            dataPoint1.LabelBorderColor = System.Drawing.Color.Transparent;
            dataPoint1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            dataPoint2.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint2.IsValueShownAsLabel = true;
            dataPoint2.Label = "Banco";
            dataPoint2.LabelBackColor = System.Drawing.Color.Transparent;
            dataPoint2.LabelBorderColor = System.Drawing.Color.Transparent;
            dataPoint2.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            dataPoint3.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint3.IsValueShownAsLabel = true;
            dataPoint3.Label = "Lojinha...";
            dataPoint3.LabelBackColor = System.Drawing.Color.Transparent;
            dataPoint3.LabelBorderColor = System.Drawing.Color.Transparent;
            dataPoint3.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(455, 206);
            this.chart.TabIndex = 2;
            this.chart.TabStop = false;
            this.chart.Text = "CHART";
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.BackSecondaryColor = System.Drawing.Color.Transparent;
            title1.DockingOffset = 5;
            title1.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "Ultimos golpes";
            this.chart.Titles.Add(title1);
            // 
            // rtbTeste
            // 
            this.rtbTeste.BackColor = System.Drawing.Color.Black;
            this.rtbTeste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTeste.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.rtbTeste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbTeste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.rtbTeste.Location = new System.Drawing.Point(0, 212);
            this.rtbTeste.Name = "rtbTeste";
            this.rtbTeste.Size = new System.Drawing.Size(455, 235);
            this.rtbTeste.TabIndex = 1;
            this.rtbTeste.Text = "";
            this.rtbTeste.TextChanged += new System.EventHandler(this.rtbTeste_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(771, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(25, 25);
            this.btnSair.TabIndex = 11;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pcbFundo
            // 
            this.pcbFundo.BackColor = System.Drawing.Color.Transparent;
            this.pcbFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbFundo.Image = global::prjHacker.Properties.Resources.matrix1;
            this.pcbFundo.Location = new System.Drawing.Point(0, 0);
            this.pcbFundo.Name = "pcbFundo";
            this.pcbFundo.Size = new System.Drawing.Size(798, 536);
            this.pcbFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFundo.TabIndex = 12;
            this.pcbFundo.TabStop = false;
            // 
            // btnResponse1
            // 
            this.btnResponse1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResponse1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnResponse1.FlatAppearance.BorderSize = 0;
            this.btnResponse1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnResponse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponse1.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponse1.ForeColor = System.Drawing.Color.White;
            this.btnResponse1.Location = new System.Drawing.Point(0, 231);
            this.btnResponse1.Name = "btnResponse1";
            this.btnResponse1.Size = new System.Drawing.Size(455, 38);
            this.btnResponse1.TabIndex = 11;
            this.btnResponse1.TabStop = false;
            this.btnResponse1.Text = "Assinar serviÇo por 1 Hora";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(455, 38);
            this.button1.TabIndex = 12;
            this.button1.TabStop = false;
            this.button1.Text = "Assinar serviÇo por 3 Horas";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(455, 38);
            this.button2.TabIndex = 13;
            this.button2.TabStop = false;
            this.button2.Text = "Assinar serviÇo por 5 Horas";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(798, 536);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gbAreaDeTrabalho);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcbFundo);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Shown += new System.EventHandler(this.frmPrincipal_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.gbAreaDeTrabalho.ResumeLayout(false);
            this.panelVpn.ResumeLayout(false);
            this.panelVpn.PerformLayout();
            this.panelMissao.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProgramacao;
        private System.Windows.Forms.Label lblExperiencia;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.ListBox lstTrabalhos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem servicosTool;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.GroupBox gbAreaDeTrabalho;
        private System.Windows.Forms.ToolStripMenuItem configuracoesTool;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.RichTextBox rtbTeste;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.PictureBox pcbFundo;
        private System.Windows.Forms.Panel panelMissao;
        private System.Windows.Forms.Label lblMissao;
        private System.Windows.Forms.Panel panelVpn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnResponse1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}