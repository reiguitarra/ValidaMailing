using Maling.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maling
{
    public partial class frmMailing : Form
    {
        public frmMailing()
        {
            InitializeComponent();
            cmbSeperador.SelectedIndex = 0;
            btnProcessar.Enabled = false;
            prbPorcent.Visible = false;
        }

        public int qtdLinhas = 0;
        public int qtdErros = 0;
        public int contLinhas = 0;
        private int valorPorcent = 1;
        
        


        LeitorArquivo leitor = new LeitorArquivo();

       

        private void btnAbrir_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = @"C:\";
                open.Title = "Abrir Arquivo Mailing";
                open.Filter = "txt files (*.txt)|*.txt| csv files (*.csv)|*.csv| All files (*.*)|*.*";
                open.DefaultExt = "txt";
                open.RestoreDirectory = true;


                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = open.FileName;

                }
            }
            catch (Exception)
            {

                throw;
            }
            



        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            prbPorcent.Visible = false;
            lblContador.Text = "...";
            lblPorcentagem.Text = "...";
            lblQtdErros.Text = "...";
            prbPorcent.Maximum = 0;
            txtDetalheErros.Clear();

            //valorPorcent = 1;
            qtdErros = 0;
            contLinhas = 0;
            valorPorcent = 1;
            

            List<string> list = Processar();
            List<string> erros = ProcessarErros();
            qtdLinhas = list.Count;



            if (list.Count > 0)
            {
                prbPorcent.Maximum = erros.Count;
                prbPorcent.Visible = true;


               // Thread thread1 = new Thread(new ThreadStart(AtualizaDadosTela));
                Thread thread2 = new Thread(new ThreadStart(AtualizaProgresso));
                Thread thread3 = new Thread(new ThreadStart(AtualizarPorcentagem));
               // thread1.Start();
                thread2.Start();
                thread3.Start();


                if (erros.Count > 0)
                {
                    foreach (var item in erros)
                    {
                        txtDetalheErros.Text += item + " \r\n";
                    }
                }
                else
                {
                    txtDetalheErros.Text = "NENHUM ERRO FOI ENCONTRADO!!!";
                }
               
                lblQtdErros.Text = "Quantidade de erros encontrados: "+erros.Count.ToString();

            }
                     
           

        }


        private List<string> Processar()
        {

            leitor.LerArquivo(txtPath.Text, char.Parse(cmbSeperador.Text));
            return leitor.LinhasList;
        }

        private List<string> ProcessarErros()
        {
            var linha = leitor.LinhasErros;
            return linha;
        }
        public void deleGate(int n1)
        {
            lblContador.Text = "Linhas Arquivo : " + n1;
           
            //lblContador.Refresh();
        }

        public void deleGate2(int n1)
        {
            prbPorcent.Value = n1;
            

        }

        public void deleGate3(int porc)
        {

            lblPorcentagem.Text = porc.ToString() + "%";
            
        }

        private void AtualizaDadosTela()
        {
            while (contLinhas <= leitor.QtdLinhas)
            {

                        if (lblContador.InvokeRequired)
                         {
                            lblContador.Invoke((MethodInvoker)delegate
                            {
                                deleGate(contLinhas);
                            } );
                         }

                contLinhas++;
            }
                        
        }

        private void AtualizaProgresso()
        {
            while (qtdErros <= leitor.LinhasErros.Count)
            {
                if (prbPorcent.InvokeRequired)
                {
                    prbPorcent.Invoke((MethodInvoker)delegate
                    {
                        deleGate2(qtdErros);
                    });
                }

                
                qtdErros++;

            }
        }

        private void AtualizarPorcentagem()
        {
            while (valorPorcent <= leitor.LinhasErros.Count)
            {
                int porc = (valorPorcent / leitor.LinhasErros.Count) * 100;
                if (lblPorcentagem.InvokeRequired)
                {
                    
                    lblPorcentagem.Invoke((MethodInvoker)delegate
                    {
                        deleGate3(porc);
                    });
                }

                valorPorcent++;
            }
        }
        private void frmMailing_MouseMove(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                btnProcessar.Enabled = true;
            }
            else
            {
                btnProcessar.Enabled = false;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            List<string> erros = ProcessarErros();
            leitor.GerarRelatorioDeErros(erros);
        }
    }
}
