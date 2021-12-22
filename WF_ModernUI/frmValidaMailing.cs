using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//blibioteca para mover janela sem a barra titulo padrão do windows
using System.Runtime.InteropServices;
using System.IO;
using WF_ModernUI.Entities;
using System.Threading;

namespace WF_ModernUI
{
    public partial class FormMenu : Form
    {

        public FormMenu()
        {
            InitializeComponent();
            txtArquivo.Focus();
            pnLateral.Width = 170;
            cmbSeparator.SelectedIndex = 0;
        }

        LeitorArquivo leitor = new LeitorArquivo();

        //código para permitir a moveimentação da janela, pois está sem a barra padrão do Windows
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]


        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        

        private void panelCabecario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {

            try
            {
                opnFileDialog = new OpenFileDialog()
                {
                    InitialDirectory = @"C:\",
                    Title = "Busca Arquivos",
                    Filter = "txt files (*.txt)|*.txt| csv files (*.csv)|*.csv| All files (*.*)|*.*",
                    DefaultExt = "txt",

                    RestoreDirectory = true
                };

                


                if (this.opnFileDialog.ShowDialog() == DialogResult.OK)
                {

                    txtArquivo.Text = opnFileDialog.FileName;
                    txtArquivo.Leave += txtArquivo_Leave;
                    //opnFileDialog.RestoreDirectory = true;

                }


            }
            catch (Exception)
            {

                throw;
            }
         
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMax.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMax.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            if (pnLateral.Width == 30)
            {
                pnLateral.Width = 200;
            }
            else
            {
                pnLateral.Width = 30;
            }
        }

      
        private void btnLer_Click(object sender, EventArgs e)
        {
            prbLeitura.Visible = false;
            lblResultado.Text = "";
            lblQtdErros.Text = "";
            lblPorcentagem.Text = "";
            leitor.LinhasErros.Clear();
            prbLeitura.Value = 0;
            
            int i = 1;                      
                btnLer.Enabled = true;
                leitor.LerArquivo(txtArquivo.Text, char.Parse(cmbSeparator.Text));

            prbLeitura.Visible = true;
            if (leitor.LinhasErros.Count > 0)
            {
                prbLeitura.Maximum = leitor.LinhasErros.Count;
                

                foreach (var item in leitor.LinhasErros)
                {

                    prbLeitura.Value = i;
                    int porc = (i / leitor.LinhasErros.Count) * 100;

                    lblPorcentagem.Text = porc.ToString() + "%";


                    lblResultado.Text += "\n" + item + "\n";
                    lblQtdlines.Text = "Erros encontrados : "+i.ToString();
                    
                    //Atualiza o label a cada interação do laço!.
                    lblQtdlines.Refresh();
                    lblPorcentagem.Refresh();
                    lblResultado.Refresh();

                    i++;
                }
                lblTest.Text = "Quantidade de Linhas: " + leitor.QtdLinhas.ToString();
                lblQtdErros.Text = "Quantidades de Linhas com Erros: "+leitor.LinhasErros.Count;
                
                
                //prbLeitura.Maximum = leitor.LinhasErros.Count;
            }
            else
            {

                lblTest.Text = "Quantidade de Linhas: " + leitor.QtdLinhas.ToString();
                lblResultado.Text = "NENHUM ERRO FOI ENCONTRADO!!!!";
                prbLeitura.Visible = false;
            }
           
           

            
        }

        
        private void txtArquivo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArquivo.Text))
            {
                btnLer.Enabled = true;
            }
            else
            {
                btnLer.Enabled = false;
            }
        }

        private void txtArquivo_MouseMove(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArquivo.Text))
            {
                btnLer.Enabled = true;
            }
            else
            {
                btnLer.Enabled = false;
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            LeitorArquivo leitor = new LeitorArquivo();

            //leitor.CarregarLayout("ALIANCA");
        }

        private void tmrAtualiza_Tick(object sender, EventArgs e)
        {

        }
    }
}