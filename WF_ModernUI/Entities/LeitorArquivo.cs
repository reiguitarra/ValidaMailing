using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using WF_ModernUI.Enum;

namespace WF_ModernUI.Entities
{
    public class LeitorArquivo
    {
        public string Linha { get; set; }
        public int QtdLinhas { get; set; }
        public string[] CamposLinhas { get; set; }
        public List<string> LinhasList { get; set; }

        public List<string> LinhasErros = new List<string>();

        public List<Layout> ListaLayout = new List<Layout>();


       
        
        public void ProcessarArquivo(List<string> dados, string[] linha, int nLinha)
        {

           int num = 0;
            bool teste = false;
           /* var lista = CarregarLayout("ALIANCA");

            if (lista.Count == linha.Length)
            {

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("O layout não corresponde Ao arquivo verificado.");
            }
            for (int i = 0; i < lista.Count; i++)
            {
                //if (lista[i].Indice == )
                //{

                //}

            }*/

            for (int i = 0; i < linha.Length; i++)
            {
                if (string.IsNullOrEmpty(linha[0]))
                {
                    LinhasErros.Add($"O telefone está nulo {linha[0]} linha: {nLinha + 1}");
                    break;
                }

                long longo;

                if (!long.TryParse(linha[0].ToString(), out longo))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[0]} linha: {nLinha + 1}");
                    break;
                }



                //teste = Linha[1].ToString();
                string number = linha[1];

                
                if (!long.TryParse(number, out longo))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[1]} linha: {nLinha + 1}");
                    break;
                }

                //Validação de tamanho de linha, temporário
                if (linha.Length != 100)
                {
                    LinhasErros.Add($"A linha {nLinha + 1} tem tamanho : {linha.Length} deveria ter tamanho 100!");
                    break;
                }

                // if (!int.TryParse(linha[0], out teste))
                if (linha[0].ToString() != "0")
                {
                    if (linha[0].Length > 11 || linha[0].Length < 9)
                    {
                        LinhasErros.Add($"O Telefone não é válido {linha[0]} linha: {nLinha + 1}");
                        break;
                    }
                }


                if (i > 19 && linha[i].Length > 100)
                {
                    LinhasErros.Add($"O campo do índice {i} fora do padrão.\nConteúdo: {linha[i]} \nlinha: {nLinha + 1} tamanho: {linha[i].Length}");
                    break;
                }

                if (i == 29 && linha[i].Length > 50 )
                {
                    LinhasErros.Add($"O campo do índice {i} fora do padrão.\nConteúdo: {linha[i]} \nlinha: {nLinha + 1} tamanho: {linha[i].Length}");
                    break;
                }
            }


        }

        public void LerArquivo(string path, char separator)
        {
            LinhasList = new List<string>();
            LinhasList.Clear();
            QtdLinhas = 0;
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        
                        //quebra o texto em várias colunas.
                        while (!sr.EndOfStream)
                        {
                            Linha = sr.ReadLine();
                            CamposLinhas = Linha.Split(separator);
                        
                            LinhasList.Add(Linha);
                            ProcessarArquivo(LinhasList, CamposLinhas, QtdLinhas);
                            QtdLinhas++;
                        }
                    }
                }
                else
                {
                    
                }
                
            }
            catch (IOException e)
            {


                System.Windows.Forms.MessageBox.Show("Não foi possível ler o arquivo!" +e.Message);
            }
           



            
        }

        public List<Layout> CarregarLayout(string nome)
        {
            string path = @"C:\Users\reinaldo.almeida.HMB\source\repos\WF_ModernUI\layout.txt";
            string[] listaLay;
            string[] campos;
            Layout lay = new Layout();

            try
            {

                if (!string.IsNullOrEmpty(path))
                {
                    using (StreamReader sr = File.OpenText(path))
                    {


                        while (!sr.EndOfStream)
                        {
                            Linha = sr.ReadLine();
                            listaLay = Linha.Split('|');
                            

                            if (nome == listaLay[0])
                            {
                                
                                for (int i = 1; i < listaLay.Length; i++)
                                {
                                    campos = listaLay[i].Split(';');
                                    for (int j = 0; j < campos.Length; j++)
                                    {
                                        int indice = i;
                                        int tamanho = int.Parse(campos[j + 1]);
                                        Tipos tipo;
                                        if (int.Parse(campos[j + 2]) == 0)
                                        {
                                            tipo = Tipos.Texto;
                                        }
                                        else
                                        {
                                            tipo = Tipos.Numero;
                                        }

                                        ListaLayout.Add(new Layout(nome, indice, tamanho, tipo));
                                        break;
                                    }
                                }
                            }
                           
                        }
                    }

                    return ListaLayout;
                }
                else
                {
                    
                }

   
            }
            catch (IOException e)
            {


                System.Windows.Forms.MessageBox.Show("Não foi possível ler o arquivo!" + e.Message);
            }

            return null;

        }

        public override string ToString()
        {
            return $"Linhas no arquivo {QtdLinhas}";
        }

        //private void AnalisaLinhas(string[] campo, string linha)
        //{
        //    for (int i = 0; i < campo.Length; i++)
        //    {
        //        if (campo[i])
        //        {

        //        }
        //    }

        //}
    }
}