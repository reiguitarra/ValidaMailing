using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Maling.Enum;
using System.Windows.Forms;

namespace Maling.Entities
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

            long num = 0;
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

                if (!long.TryParse(linha[0].ToString(), out num))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[0]} linha: {nLinha + 1} - Telefone01");
                    break;
                }

                if (!long.TryParse(linha[1].ToString(), out num) && !string.IsNullOrEmpty(linha[1]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[1]} linha: {nLinha + 1} - Telefone{linha[0]} - Telefone02");
                    break;
                }


                if (!long.TryParse(linha[2].ToString(), out num) && !string.IsNullOrEmpty(linha[2]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[2]} linha: {nLinha + 1} - Telefone03");
                    break;
                }


                if (!long.TryParse(linha[3].ToString(), out num) && !string.IsNullOrEmpty(linha[3]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[3]} linha: {nLinha + 1} - Telefone04");
                    break;
                }

                if (!long.TryParse(linha[4].ToString(), out num) && !string.IsNullOrEmpty(linha[4]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[4]} linha: {nLinha + 1} - Telefone05");
                    break;
                }

                if (!long.TryParse(linha[5].ToString(), out num) && !string.IsNullOrEmpty(linha[5]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[5]} linha: {nLinha + 1} - Telefone06");
                    break;
                }

                if (!long.TryParse(linha[6].ToString(), out num) && !string.IsNullOrEmpty(linha[6]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[6]} linha: {nLinha + 1} - Telefone07");
                    break;
                }


                if (!long.TryParse(linha[7].ToString(), out num) && !string.IsNullOrEmpty(linha[7]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[7]} linha: {nLinha + 1} - Telefone08");
                    break;
                }

                if (!long.TryParse(linha[8].ToString(), out num) && !string.IsNullOrEmpty(linha[8]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[8]} linha: {nLinha + 1} - Telefone09");
                    break;
                }

                if (!long.TryParse(linha[9].ToString(), out num) && !string.IsNullOrEmpty(linha[9]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[9]} linha: {nLinha + 1} - Telefone10");
                    break;
                }


                if (!long.TryParse(linha[10].ToString(), out num) && !string.IsNullOrEmpty(linha[10]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[10]} linha: {nLinha + 1} - Telefone11");
                    break;
                }

                if (!long.TryParse(linha[11].ToString(), out num) && !string.IsNullOrEmpty(linha[11]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[11]} linha: {nLinha + 1} - Telefone12");
                    break;
                }


                if (!long.TryParse(linha[12].ToString(), out num) && !string.IsNullOrEmpty(linha[12]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[12]} linha: {nLinha + 1} - Telefone13");
                    break;
                }


                if (!long.TryParse(linha[13].ToString(), out num) && !string.IsNullOrEmpty(linha[13]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[13]} linha: {nLinha + 1} - Telefone14");
                    break;
                }

                
                if (!long.TryParse(linha[14].ToString(), out num) && !string.IsNullOrEmpty(linha[14]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[14]} linha: {nLinha + 1} - Telefone15");
                    break;
                }

                if (!long.TryParse(linha[15].ToString(), out num) && !string.IsNullOrEmpty(linha[15]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[15]} linha: {nLinha + 1} - Telefone16");
                    break;
                }

                if (!long.TryParse(linha[16].ToString(), out num) && !string.IsNullOrEmpty(linha[16]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[16]} linha: {nLinha + 1} - Telefone17");
                    break;
                }

                if (!long.TryParse(linha[17].ToString(), out num) && !string.IsNullOrEmpty(linha[17]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[17]} linha: {nLinha + 1} - Telefone18");
                    break;
                }

                if (!long.TryParse(linha[18].ToString(), out num) && !string.IsNullOrEmpty(linha[18]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[18]} linha: {nLinha + 1} - Telefone19");
                    break;
                }

                if (!long.TryParse(linha[19].ToString(), out num) && !string.IsNullOrEmpty(linha[19]))
                {
                    LinhasErros.Add($"Possui caractere inválido. {linha[19]} linha: {nLinha + 1} - Telefone20");
                    break;
                }

                //Validação de ta
                //manho de linha, temporário
                if (linha.Length != 100)
                {
                    LinhasErros.Add($"A linha {nLinha + 1} tem tamanho : {linha.Length} deveria ter tamanho 100! - Verifique Colunas inválidas");
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

                if (i == 29 && linha[i].Length > 50)
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


                System.Windows.Forms.MessageBox.Show("Não foi possível ler o arquivo!" + e.Message);
            }





        }

        public void GerarRelatorioDeErros(List<string> erros)
        {

            string nomeArquivo;
            DialogResult retry = DialogResult.Retry;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Exportar CSV";

            nomeArquivo = "Export_Erros" + DateTime.Now.ToString("yyyy-mm-dd-HHmm");

            saveFileDialog.FileName = nomeArquivo;
            if (erros.Count > 0)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        using (StreamWriter sw = File.AppendText(saveFileDialog.FileName))
                        {
                            if (erros.Count > 0)
                            {
                                foreach (var item in erros)
                                {
                                    sw.WriteLine(item);
                                }

                                System.Windows.Forms.MessageBox.Show("Arquivo exportado com sucesso!");
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("Não há erros a serem exportados!", "Exprotar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            }

                        }


                    }
                    catch (IOException e)
                    {

                        System.Windows.Forms.MessageBox.Show("Não há erros a serem exportados! " + e.Message, "Exportação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Não há erros a serem exportados!");
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
