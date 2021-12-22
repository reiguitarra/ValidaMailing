
using System;
using System.Collections.Generic;
using System.Text;
using Maling.Enum;

namespace Maling.Entities
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