using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia
{
    public class Academia
    {
        public List<Aluno> ListaAlunos { get; set; }
        public List<Professor> ListaProfessor { get; set; }
        public List<Modalidade> ListaModalidade { get; set; } 
        public Academia()
        {
            ListaAlunos = new List<Aluno>();
            ListaProfessor = new List<Professor>();
            ListaModalidade = new List<Modalidade>();
        }

       
        public void AdicionarAluno(
            string nome, 
            Modalidade modalidade,
            string telefone,
            string cpf)
        {
            ListaAlunos.Add(new Aluno(nome, modalidade.Professor.Turno, telefone, cpf));


        }

        public void EditarAluno(
            int indice,
            string nome,
            Modalidade modalidade,
            string telefone,
            string cpf)
        {
            ListaAlunos[indice].Nome = nome;
            ListaAlunos[indice].Modalidade = modalidade.Professor.Turno;
            ListaAlunos[indice].Telefone = telefone;
            ListaAlunos[indice].CPF = cpf;
        }

        public void DeletarAluno(int indice)
        {    
                ListaAlunos.RemoveAt(indice); 
        }
        public void AdicionarProfessor(
            string nome,
            string telefone,
            string cpf,
            string salario,
            string turno)
        {
            ListaProfessor.Add(new Professor(nome, telefone, cpf, salario, turno));
        }
        public void EditarProfessor(
                     int indice,
                     string nome,
                     string telefone,
                     string cpf,
                     string salario,
                     string turno)
        {
            ListaProfessor[indice].Nome = nome;
            ListaProfessor[indice].Telefone = telefone;
            ListaProfessor[indice].CPF = cpf;
            ListaProfessor[indice].Salario = salario;
            ListaProfessor[indice].Turno = turno;
        }

        public void DeletarProfessor(int indice)
        {
            ListaProfessor.RemoveAt(indice);
        }

        public void AdicionarModalidade(
          string nomeModalidade,
          Professor professor,
          double precoHora,
          int vezesSemana)
        {
            ListaModalidade.Add(new Modalidade(nomeModalidade, professor, precoHora, vezesSemana));
        }
        public void EditarModalidade( int indice,
                                    string nomeModalidade,
                                    Professor professor,
                                    double precoHora,
                                    int vezesSemana)
        {
            ListaModalidade[indice].NomeModalidade = nomeModalidade;
            ListaModalidade[indice].Professor = professor;
            ListaModalidade[indice].PrecoHora = precoHora;
            ListaModalidade[indice].VezesSemana = vezesSemana;
            
        }
        public void DeletarModalidade(int indice)
        {
            ListaModalidade.RemoveAt(indice);
        }



    }
}
