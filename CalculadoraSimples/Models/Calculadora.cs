using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraSimples.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine("--------\n" +
                               "| Soma | -> " + $"| {x} + {y} = {x + y} |\n" +
                               "--------");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine("-------------\n" +
                               "| Subtração | -> " + $"| {x} - {y} = {x - y} |\n" +
                               "-------------");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine("-----------------\n" +
                               "| Multiplicação | -> " + $"| {x} x {y} = {x * y} |\n" +
                               "-----------------");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine("-----------\n" +
                               "| Divisão | -> " + $"| {x} / {y} = {x / y} |\n" +
                               "-----------");
        }

        public void Potencia(int x, int y)
        {
            Console.WriteLine("-----------\n" +
                               "| Potência | -> " + $"| {x} ^ {y} = {Math.Pow(x, y)} |\n" +
                               "-----------");
        }
        public void Seno(double angulo)
        {
            Console.WriteLine("-----------------\n" +
                               "| Seno | de " + $"| {angulo}° = {Math.Round(Math.Sin(angulo * Math.PI / 180), 4)} |\n" +
                               "-----------------");
        }

        public void Cosseno(double angulo)
        {
            Console.WriteLine("-----------\n" +
                               "| Cosseno | de " + $"| {angulo}° = {Math.Round(Math.Cos(angulo * Math.PI / 180)),4} |\n" +
                               "-----------");
        }

        public void Tangente(double angulo)
        {
            Console.WriteLine("------------\n" +
                               "| Tangente | de " + $"| {angulo}° = {Math.Round(Math.Tan(angulo * Math.PI / 180), 4)} |\n" +
                               "-----------");
        }

        public void RaizQuadrada(int x)
        {
            double raiz = Math.Sqrt(x);
            if (raiz % 1 == 0)
            {
                Console.WriteLine("-----------------\n" +
                               "| Raiz Quadrada | de " + $"| {x} = {raiz} |\n" +
                               "-----------------");
            }
            else
            {
                Console.WriteLine("-----------------\n" +
                               "| Raiz Quadrada | de " + $"| {x} = Não existe |\n" +
                               "-----------------");
            }

        }
    }
}