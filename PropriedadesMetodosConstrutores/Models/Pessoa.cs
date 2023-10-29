using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesMetodosConstrutores.Models
{
    public class Pessoa
    {
        public Pessoa(){

        }

        public Pessoa(String nome, int idade)
        {

            Nome = nome;

        }

        private string _nome;
        private int _idade;

        public string Nome
        { 
            get => _nome.ToUpper();
            set{
                
                if(value == ""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }else{
                    _nome = value;
                }

            } 
        }
        public int Idade
        { 
            get => _idade;
            set{
                
                if(value < 0 ){
                    throw new ArgumentException("A altura não pode ser menor que 0");
                }else{
                    _idade = value;
                }

            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, e minha idade é {Idade} anos.");
        }
    }
}