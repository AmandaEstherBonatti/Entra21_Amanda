using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEscolar
{
    class Alunos
    {
        public string NomeAluno { get; set; }
        public string DataNascimento { get; set; }
        public string CPFAluno { get; set; }
        public string Genero { get; set; }
        public string AnoEscolar { get; set; }
        public string NomeResponsavel { get; set; }
        public string CPFResponsavel { get; set; }
        public string NomeResponsavel2 { get; set; }
        public string CPFResponsavel2 { get; set; }

        public Alunos(
            string nomeAluno,
            string  dataNascimento,
            string cpfAluno,
            string genero,
            string anoEscolar,
            string nomeResponsavel,
            string cpfResponsavel,
            string nomeResponsavel2,
            string cpfResponsavel2)
        {
            NomeAluno = nomeAluno;
            DataNascimento = dataNascimento;
            CPFAluno = cpfAluno;
            Genero = genero;
            AnoEscolar = anoEscolar;
            NomeResponsavel = nomeResponsavel;
            CPFResponsavel = cpfResponsavel;
            NomeResponsavel2 = nomeResponsavel2;
            CPFResponsavel2 = cpfResponsavel2;
        }

        public override string ToString()
        {
            return $"{NomeAluno}, {Genero}, {AnoEscolar}";
        }
    }
}
