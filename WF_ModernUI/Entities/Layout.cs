using System;
using System.Collections.Generic;
using System.Text;
using WF_ModernUI.Enum;

namespace WF_ModernUI.Entities
{
    public class Layout
    {
        public int Indice { get; set; }
        public int Tamanho { get; set; }
        public Tipos Tipo { get; set; }
        public string NomeLayout { get; set; }
        public Layout()
        {

        }

        public Layout(string nomeLayout, int indice, int tamanho, Tipos tipo)
        {
            NomeLayout = nomeLayout;
            Indice = indice;
            Tamanho = tamanho;
            Tipo = tipo;
           
        }
    }
}
