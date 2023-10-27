using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exemplos_Fundamentos.Models;
using Exemplos_Fundamentos.View;

namespace Exemplos_Fundamentos.View
{
    public class MaisUma
    {
        public int Novamente(string opcaoPrincipal)
        {
            
            int cont = 1;
            
            while(cont == 1)
            {

                Console.WriteLine("---------------------------------\n"+
                                  "|       O QUE DESEJA AGORA      |\n"+
                                  "---------------------------------\n"+
                                  "| 1 | Realizar a mesma opção    |\n"+
                                  "---------------------------------\n"+
                                  "| 2 | Selecionar uma nova opção |\n"+
                                  "---------------------------------\n"+
                                  "| 0 | Sair do programa          |\n"+
                                  "---------------------------------");
            
                Console.WriteLine("Digite a opção que deseja: ");
                int opcao = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));
                Console.Clear();
                
                cont = testes(opcao,opcaoPrincipal);
                
            }
            
            if(cont == 2){
                return 1;
            }

            return 0;
        }

        public int testes(int opcao,string opcaoPrincipal){
            
            if(opcao == 1)
            {
                Funcionalidades funcionalidades = new Funcionalidades();
                switch(opcaoPrincipal){
                    case "1":
                        funcionalidades.HelloWorld();
                        break;
                    case "2":
                        funcionalidades.UtIfElse();
                        break;
                }
                return 1;
            }
            else if(opcao == 2)
            {
                Console.Clear();
                return 2;
            }
            else{
                return 0;
            }
            
        }
    }
}