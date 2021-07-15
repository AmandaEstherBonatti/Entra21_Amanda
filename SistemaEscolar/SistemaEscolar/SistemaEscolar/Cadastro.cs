using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEscolar
{
    class Cadastro
    {
        public List<Alunos> ListaAlunos { get; set; }

        public Cadastro()
        {
            ListaAlunos = new List<Alunos>();
        }

        public void AdicionarAluno
            (string nomeAluno,
            string dataNascimento,
            string cpfAluno,
            string genero,
            string anoEscolar,
            string nomeResponsavel,
            string cpfResponsavel,
            string nomeResponsavel2,
            string cpfResponsavel2)
        {
            ListaAlunos.Add(new Alunos(nomeAluno, dataNascimento, cpfAluno, genero, anoEscolar, nomeResponsavel, cpfResponsavel, nomeResponsavel2, cpfResponsavel2));
        }

        public void EditarAluno(
            int indice,
            string nomeAluno,
            string dataNascimento,
            string cpfAluno,
            string genero,
            string anoEscolar,
            string nomeResponsavel,
            string cpfResponsavel,
            string nomeResponsavel2,
            string cpfResponsavel2)
        {
            ListaAlunos[indice].NomeAluno = nomeAluno;
            ListaAlunos[indice].DataNascimento = dataNascimento;
            ListaAlunos[indice].CPFAluno = cpfAluno;
            ListaAlunos[indice].Genero = genero;
            ListaAlunos[indice].AnoEscolar = anoEscolar;
            ListaAlunos[indice].NomeResponsavel = nomeResponsavel;
            ListaAlunos[indice].CPFResponsavel = cpfResponsavel;
            ListaAlunos[indice].NomeResponsavel2 = nomeResponsavel2;
            ListaAlunos[indice].CPFResponsavel2 = cpfResponsavel2;
        }

        public void DeletarAluno(int indice)
        {
            ListaAlunos.RemoveAt(indice);
        }
    }
}
