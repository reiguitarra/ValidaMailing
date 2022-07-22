
namespace Maling
{
    partial class frmMailing
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.grpFuncoes = new System.Windows.Forms.GroupBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.cmbSeperador = new System.Windows.Forms.ComboBox();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.prbPorcent = new System.Windows.Forms.ProgressBar();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.txtDetalheErros = new System.Windows.Forms.TextBox();
            this.lblQtdErros = new System.Windows.Forms.Label();
            this.lblTotaldeLinhasArquivo = new System.Windows.Forms.Label();
            this.grpFuncoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(169, 43);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(414, 23);
            this.txtPath.TabIndex = 0;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(589, 43);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // grpFuncoes
            // 
            this.grpFuncoes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpFuncoes.Controls.Add(this.btnExportar);
            this.grpFuncoes.Controls.Add(this.btnProcessar);
            this.grpFuncoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpFuncoes.Location = new System.Drawing.Point(0, 0);
            this.grpFuncoes.Name = "grpFuncoes";
            this.grpFuncoes.Size = new System.Drawing.Size(123, 450);
            this.grpFuncoes.TabIndex = 2;
            this.grpFuncoes.TabStop = false;
            this.grpFuncoes.Text = "Funções";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(21, 73);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(21, 43);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(75, 23);
            this.btnProcessar.TabIndex = 0;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // cmbSeperador
            // 
            this.cmbSeperador.FormattingEnabled = true;
            this.cmbSeperador.Items.AddRange(new object[] {
            "|",
            ";",
            ","});
            this.cmbSeperador.Location = new System.Drawing.Point(169, 90);
            this.cmbSeperador.Name = "cmbSeperador";
            this.cmbSeperador.Size = new System.Drawing.Size(60, 23);
            this.cmbSeperador.TabIndex = 3;
            // 
            // lblSeparador
            // 
            this.lblSeparador.AutoSize = true;
            this.lblSeparador.Location = new System.Drawing.Point(167, 73);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(60, 15);
            this.lblSeparador.TabIndex = 4;
            this.lblSeparador.Text = "Separador";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(169, 410);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(16, 15);
            this.lblContador.TabIndex = 5;
            this.lblContador.Text = "...";
            // 
            // prbPorcent
            // 
            this.prbPorcent.ForeColor = System.Drawing.Color.YellowGreen;
            this.prbPorcent.Location = new System.Drawing.Point(167, 384);
            this.prbPorcent.Name = "prbPorcent";
            this.prbPorcent.Size = new System.Drawing.Size(497, 23);
            this.prbPorcent.TabIndex = 6;
            this.prbPorcent.Tag = "";
            this.prbPorcent.Visible = false;
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Location = new System.Drawing.Point(167, 366);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(16, 15);
            this.lblPorcentagem.TabIndex = 7;
            this.lblPorcentagem.Text = "...";
            // 
            // txtDetalheErros
            // 
            this.txtDetalheErros.Location = new System.Drawing.Point(167, 165);
            this.txtDetalheErros.Multiline = true;
            this.txtDetalheErros.Name = "txtDetalheErros";
            this.txtDetalheErros.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDetalheErros.Size = new System.Drawing.Size(609, 175);
            this.txtDetalheErros.TabIndex = 8;
            // 
            // lblQtdErros
            // 
            this.lblQtdErros.AutoSize = true;
            this.lblQtdErros.Location = new System.Drawing.Point(435, 147);
            this.lblQtdErros.Name = "lblQtdErros";
            this.lblQtdErros.Size = new System.Drawing.Size(16, 15);
            this.lblQtdErros.TabIndex = 9;
            this.lblQtdErros.Text = "...";
            // 
            // lblTotaldeLinhasArquivo
            // 
            this.lblTotaldeLinhasArquivo.AutoSize = true;
            this.lblTotaldeLinhasArquivo.Location = new System.Drawing.Point(169, 147);
            this.lblTotaldeLinhasArquivo.Name = "lblTotaldeLinhasArquivo";
            this.lblTotaldeLinhasArquivo.Size = new System.Drawing.Size(16, 15);
            this.lblTotaldeLinhasArquivo.TabIndex = 10;
            this.lblTotaldeLinhasArquivo.Text = "...";
            // 
            // frmMailing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotaldeLinhasArquivo);
            this.Controls.Add(this.lblQtdErros);
            this.Controls.Add(this.txtDetalheErros);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.prbPorcent);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblSeparador);
            this.Controls.Add(this.cmbSeperador);
            this.Controls.Add(this.grpFuncoes);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.txtPath);
            this.Name = "frmMailing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mailing";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMailing_MouseMove);
            this.grpFuncoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.GroupBox grpFuncoes;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.ComboBox cmbSeperador;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.ProgressBar prbPorcent;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.TextBox txtDetalheErros;
        private System.Windows.Forms.Label lblQtdErros;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblTotaldeLinhasArquivo;
    }
}

