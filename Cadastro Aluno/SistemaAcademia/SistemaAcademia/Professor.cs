using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia
{
    public class Professor : Pessoa
    {
        public string Salario { get; set; }
        public string Turno { get; set; }
        public Professor(
          string nome,
          string telefone,
          string cpf,
          string salario,
          string turno)
        {
            Nome = nome;
            Telefone = telefone;
            CPF = cpf;
            Salario = salario;
            Turno = turno;

        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Turno: {Turno} ";
        }



    }
}
