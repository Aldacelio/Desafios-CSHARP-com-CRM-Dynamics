using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos_Fundamentos.View
{
    public class Menu
    {
        public string Mensagem(){
            string mensagem = "---------------------------------\n"+
                              "|Olá, escolha a opção que deseja|\n"+
                              "---------------------------------\n"+
                              "| 1 | Imprimir um HELLO WORLD!! |\n"+
                              "---------------------------------\n"+
                              "| 2 |    Veja o uso de um IF    |\n"+
                              "---------------------------------\n"+
                              "| 3 |   Veja o uso de um FOR    |\n"+
                              "---------------------------------\n"+
                              "| 4 |  Veja o uso de um WHILE   |\n"+
                              "---------------------------------\n"+
                              "| 5 | Veja o uso de um DO WHILE |\n"+
                              "---------------------------------\n"+
                              "| 6 | Veja o uso de um FOREACH  |\n"+
                              "---------------------------------\n"+
                              "| 7 |  Veja o uso de um ARRAY   |\n"+
                              "---------------------------------\n"+
                              "| 8 |   Veja o uso de um LIST   |\n"+
                              "---------------------------------\n"+
                              "| 0 |     Caso queira sair      |\n"+
                              "---------------------------------";
            Console.WriteLine(mensagem);
            Console.WriteLine("Digite a opção que deseja: ");
            string opcao = Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!");
            return opcao;
        }

    }
}