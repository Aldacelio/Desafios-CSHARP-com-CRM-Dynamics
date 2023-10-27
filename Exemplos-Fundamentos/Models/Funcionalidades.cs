using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos_Fundamentos.Models
{
    public class Funcionalidades
    {
        public void HelloWorld(){

            Console.WriteLine("Hello World");

            //ensinando a fazer
            Console.WriteLine("O codigo usado:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Console.WriteLine(mensagem entre aspas duplas);\n");
            Console.ResetColor();
        }

        public void UtIfElse(){
            int n1,n2,n3,media;
            Console.WriteLine("Vamos ver se você passa por média :)");
            Console.WriteLine("Digite a primeira nota: ");
            n1 = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));
            Console.WriteLine("Digite a segunda nota: ");
            n2 = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));
            Console.WriteLine("Digite a terceira nota: ");
            n3 = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));


            media = (n1+n2+n3)/3;

            if(media >= 7){
                Console.WriteLine("Você foi aprovado :)");
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você foi reprovado :(");
                Console.ResetColor();
            }

            //ensinando a fazer
            Console.WriteLine("\nO codigo usado:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("int n1,n2,n3,media;\n"+
                              "Console.WriteLine(mensagem entre aspas duplas);\n"+
                              "Console.WriteLine(mensagem entre aspas duplas);\n"+
                              "n1 = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException(Mensagem entre aspas duplas));\n"+
                              "Console.WriteLine(mensagem entre aspas duplas);\n"+
                              "n2 = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException(Mensagem entre aspas duplas));\n"+
                              "Console.WriteLine(mensagem entre aspas duplas);\n"+
                              "n3 = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException(Mensagem entre aspas duplas));\n"+
                              "media = (n1+n2+n3)/3;\n"+
                              "if(media >= 7){\n"+
                              "     Console.WriteLine(mensagem entre aspas duplas);\n"+
                              "}else{\n"+
                              "     Console.ForegroundColor = ConsoleColor.Red;\n"+
                              "     Console.WriteLine(mensagem entre aspas duplas);\n"+
                              "     Console.ResetColor();\n"+
                              "}\n");

            Console.ResetColor();
        
        }
    }
}