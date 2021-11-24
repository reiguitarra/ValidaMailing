
namespace WF_ModernUI
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelCabecario = new System.Windows.Forms.Panel();
            this.btnMenuLateral = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLateral = new System.Windows.Forms.Panel();
            this.btnLer = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.opnFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblTest = new System.Windows.Forms.Label();
            this.pnResult = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.prbLeitura = new System.Windows.Forms.ProgressBar();
            this.lblQtdErros = new System.Windows.Forms.Label();
            this.cmbSeparator = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtdlines = new System.Windows.Forms.Label();
            this.tmrAtualiza = new System.Windows.Forms.Timer(this.components);
            this.panelCabecario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuLateral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.pnLateral.SuspendLayout();
            this.pnResult.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecario
            // 
            this.panelCabecario.BackColor = System.Drawing.Color.DarkCyan;
            this.panelCabecario.Controls.Add(this.btnMenuLateral);
            this.panelCabecario.Controls.Add(this.btnFechar);
            this.panelCabecario.Controls.Add(this.btnMax);
            this.panelCabecario.Controls.Add(this.btnMin);
            this.panelCabecario.Controls.Add(this.btnRestaurar);
            this.panelCabecario.Controls.Add(this.label1);
            this.panelCabecario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecario.Location = new System.Drawing.Point(0, 0);
            this.panelCabecario.Name = "panelCabecario";
            this.panelCabecario.Size = new System.Drawing.Size(853, 46);
            this.panelCabecario.TabIndex = 0;
            this.panelCabecario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecario_MouseDown);
            // 
            // btnMenuLateral
            // 
            this.btnMenuLateral.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuLateral.Image")));
            this.btnMenuLateral.Location = new System.Drawing.Point(0, 16);
            this.btnMenuLateral.Name = "btnMenuLateral";
            this.btnMenuLateral.Size = new System.Drawing.Size(30, 30);
            this.btnMenuLateral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenuLateral.TabIndex = 5;
            this.btnMenuLateral.TabStop = false;
            this.btnMenuLateral.Click += new System.EventHandler(this.btnMenuLateral_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(811, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 22);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 5;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(783, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(22, 22);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 4;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(752, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(22, 22);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 3;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(784, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(22, 22);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Validar Mailing";
            // 
            // pnLateral
            // 
            this.pnLateral.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnLateral.Controls.Add(this.btnLer);
            this.pnLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLateral.Location = new System.Drawing.Point(0, 46);
            this.pnLateral.Name = "pnLateral";
            this.pnLateral.Size = new System.Drawing.Size(170, 431);
            this.pnLateral.TabIndex = 1;
            // 
            // btnLer
            // 
            this.btnLer.Enabled = false;
            this.btnLer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLer.Location = new System.Drawing.Point(11, 37);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(81, 23);
            this.btnLer.TabIndex = 5;
            this.btnLer.Text = "Processar";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArquivo.Location = new System.Drawing.Point(224, 83);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(380, 23);
            this.txtArquivo.TabIndex = 2;
            this.txtArquivo.Leave += new System.EventHandler(this.txtArquivo_Leave);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(224, 65);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(87, 15);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Buscar Arquivo";
            // 
            // btnAbrir
            // 
            this.btnAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Location = new System.Drawing.Point(610, 83);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(45, 23);
            this.btnAbrir.TabIndex = 4;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // opnFileDialog
            // 
            this.opnFileDialog.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(224, 201);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(16, 15);
            this.lblTest.TabIndex = 5;
            this.lblTest.Text = "...";
            // 
            // pnResult
            // 
            this.pnResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnResult.AutoScroll = true;
            this.pnResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnResult.Controls.Add(this.lblResultado);
            this.pnResult.Location = new System.Drawing.Point(224, 255);
            this.pnResult.Name = "pnResult";
            this.pnResult.Size = new System.Drawing.Size(581, 142);
            this.pnResult.TabIndex = 8;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 11);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(16, 15);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "...";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblPorcentagem);
            this.panel1.Controls.Add(this.prbLeitura);
            this.panel1.Location = new System.Drawing.Point(224, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 45);
            this.panel1.TabIndex = 9;
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Location = new System.Drawing.Point(285, 4);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(16, 15);
            this.lblPorcentagem.TabIndex = 9;
            this.lblPorcentagem.Text = "...";
            // 
            // prbLeitura
            // 
            this.prbLeitura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prbLeitura.Location = new System.Drawing.Point(0, 22);
            this.prbLeitura.Name = "prbLeitura";
            this.prbLeitura.Size = new System.Drawing.Size(581, 23);
            this.prbLeitura.TabIndex = 8;
            this.prbLeitura.Tag = "Analisando";
            this.prbLeitura.Visible = false;
            // 
            // lblQtdErros
            // 
            this.lblQtdErros.AutoSize = true;
            this.lblQtdErros.Location = new System.Drawing.Point(224, 226);
            this.lblQtdErros.Name = "lblQtdErros";
            this.lblQtdErros.Size = new System.Drawing.Size(16, 15);
            this.lblQtdErros.TabIndex = 10;
            this.lblQtdErros.Text = "...";
            // 
            // cmbSeparator
            // 
            this.cmbSeparator.FormattingEnabled = true;
            this.cmbSeparator.Items.AddRange(new object[] {
            "|",
            ";",
            ","});
            this.cmbSeparator.Location = new System.Drawing.Point(224, 128);
            this.cmbSeparator.Name = "cmbSeparator";
            this.cmbSeparator.Size = new System.Drawing.Size(70, 23);
            this.cmbSeparator.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Separador";
            // 
            // lblQtdlines
            // 
            this.lblQtdlines.AutoSize = true;
            this.lblQtdlines.Location = new System.Drawing.Point(224, 453);
            this.lblQtdlines.Name = "lblQtdlines";
            this.lblQtdlines.Size = new System.Drawing.Size(16, 15);
            this.lblQtdlines.TabIndex = 13;
            this.lblQtdlines.Text = "...";
            // 
            // tmrAtualiza
            // 
            this.tmrAtualiza.Interval = 1000;
            this.tmrAtualiza.Tick += new System.EventHandler(this.tmrAtualiza_Tick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 477);
            this.Controls.Add(this.lblQtdlines);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSeparator);
            this.Controls.Add(this.lblQtdErros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnResult);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.pnLateral);
            this.Controls.Add(this.panelCabecario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valida Mailing";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtArquivo_MouseMove);
            this.panelCabecario.ResumeLayout(false);
            this.panelCabecario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuLateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.pnLateral.ResumeLayout(false);
            this.pnResult.ResumeLayout(false);
            this.pnResult.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.Panel pnLateral;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.OpenFileDialog opnFileDialog;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox btnMenuLateral;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Panel pnResult;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar prbLeitura;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Label lblQtdErros;
        private System.Windows.Forms.ComboBox cmbSeparator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQtdlines;
        private System.Windows.Forms.Timer tmrAtualiza;
    }
}

