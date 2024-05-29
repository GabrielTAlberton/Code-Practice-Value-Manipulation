using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classesMetodosPropriedaeds.models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;
        public string Nome 
        { 
            get => _nome.ToUpper();
            
            set
            {
                if (value == "")

                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            } 
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome.ToUpper()}";
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade nao pode ser menor que 0");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Me chamo {NomeCompleto} e tenho {Idade} anos de idade.");
        }
    }
}