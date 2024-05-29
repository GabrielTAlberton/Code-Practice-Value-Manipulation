using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classesMetodosPropriedaeds.models
{
    public class Curso
    {

        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionaAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        
        public void ListarAlunosMatriculados()
        {

            for (int cont = 0; cont < Alunos.Count; cont++)
            {
                // utilizando concatenacao de string em vez de utilizar interpolacao $"{}"
                string texto = "Nº " + (cont + 1) + " - " + Alunos[cont].NomeCompleto;
                Console.WriteLine(texto);
            }
        } 
    }
}