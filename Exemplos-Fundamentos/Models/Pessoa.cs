using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade, double altura) 
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Altura = altura;

        }
        private string Nome { get; set; }
        private int Idade { get; set; }  
        private double Altura { get; set; }

        public void Apresentar(){
            Console.WriteLine($"Olá meu nome é {Nome}, e minha idade é {Idade} anos." +
            $"Minha altura: {Altura}");
        }
    }
}