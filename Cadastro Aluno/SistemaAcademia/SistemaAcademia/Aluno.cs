using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia
{
    class Aluno : Pessoa
    {
        public string Modalidade { get; set; }

        public Aluno(
            string nome,
            string modalidade,
            string telefone,
            string cpf)
        {
            Nome = nome;
            Modalidade = modalidade;
            Telefone = telefone;
            CPF = cpf;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Telefone: {Telefone}";
        }
    }
}
