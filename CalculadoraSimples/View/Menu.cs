using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CalculadoraSimples.Models;

namespace CalculadoraSimples.View
{
    public class Menu
    {
        public void MensagemMenu()
        {
            var mensagem = "-------------------------------\n" +
                           "|      Escolha uma opção      |\n" +
                           "-------------------------------\n" +
                           "| 1 |          Soma           | \n" +
                           "|---|-------------------------|\n" +
                           "| 2 |        Subtração        |\n" +
                           "|---|-------------------------|\n" +
                           "| 3 |         Divisão         |\n" +
                           "|---|-------------------------|\n" +
                           "| 4 |      Multiplicação      |\n" +
                           "|---|-------------------------|\n" +
                           "| 5 |        Potência         |\n" +
                           "|---|-------------------------|\n" +
                           "| 6 |          Seno           |\n" +
                           "|---|-------------------------|\n" +
                           "| 7 |        Cosseno          |\n" +
                           "|---|-------------------------|\n" +
                           "| 8 |        Tangente         |\n" +
                           "|---|-------------------------|\n" +
                           "| 0 |          Sair           |\n" +
                           "-------------------------------";

            Console.WriteLine(mensagem);

        }
    }
}