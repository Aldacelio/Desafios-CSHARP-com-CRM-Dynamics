using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraSimples.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine( "--------\n"+
                               "| Soma | -> "+ $"| {x} + {y} = {x+y} |\n"+
                               "--------");
        }

        public void Subtrair(int x, int y){
            Console.WriteLine( "-------------\n"+
                               "| Subtração | -> "+ $"| {x} - {y} = {x-y} |\n"+
                               "-------------");
        }

        public void Multiplicar(int x, int y){
            Console.WriteLine( "-----------------\n"+
                               "| Multiplicação | -> "+ $"| {x} x {y} = {x*y} |\n"+
                               "-----------------");
        }

        public void Dividir(int x, int y){
            Console.WriteLine( "-----------\n"+
                               "| Divisão | -> "+ $"| {x} / {y} = {x/y} |\n"+
                               "-----------");
        }

        public void Potencia(int x, int y){
            Console.WriteLine( "-----------\n"+
                               "| Potência | -> "+ $"| {x} ^ {y} = {Math.Pow(x,y)} |\n"+
                               "-----------");
        }

    }
}