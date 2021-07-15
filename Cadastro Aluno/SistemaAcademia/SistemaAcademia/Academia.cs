using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia
{
    class Academia
    {
        public List<Aluno> ListaAlunos { get; set; }

        public Academia()
        {
            ListaAlunos = new List<Aluno>();
        }

        public void AdicionarAluno(
            string nome, 
            string modalidade,
            string telefone,
            string cpf)
        {
            ListaAlunos.Add(new Aluno(nome, modalidade, telefone, cpf));
        }

        public void EditarAluno(
            int indice,
            string nome,
            string modalidade,
            string telefone,
            string cpf)
        {
            ListaAlunos[indice].Nome = nome;
            ListaAlunos[indice].Modalidade = modalidade;
            ListaAlunos[indice].Telefone = telefone;
            ListaAlunos[indice].CPF = cpf;
        }

        public void DeletarAluno(int indice)
        {
            ListaAlunos.RemoveAt(indice);
        }

    }
}
