using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia
{
    public class Modalidade : ICalculo
    {
        public string NomeModalidade { get; set; }
        public Professor Professor { get; set; }
        public double PrecoHora { get; set; }
        public int VezesSemana { get; set; }

       public Modalidade(string nomeModalidade,
                         Professor professor,
                         double precoHora,
                         int vezesSemana)
        {
            NomeModalidade = nomeModalidade;
            Professor = professor;
            PrecoHora = precoHora;
            VezesSemana = vezesSemana;
        }


        public double CalcularPreco(double precoHora, int vezesSemana)
        {
            return (precoHora * vezesSemana) * 4;
        }

        public override string ToString()
        {
            return $"Modalidade:{NomeModalidade}";
        }


    }
}
