using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exemplos_Fundamentos.View;

namespace Exemplos_Fundamentos.Models
{
    public class Funcionalidades
    {
        public void HelloWorld()
        {

            Console.WriteLine("Hello World");

            //ensinando a fazer
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nO codigo usado:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Console.WriteLine(mensagem entre aspas duplas);\n");
            Console.ResetColor();
        }

        public void UtIfElse()
        {
            double n1, n2, n3, media;
            Console.WriteLine("Vamos ver se você passa por média :)");
            Console.WriteLine("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));
            Console.WriteLine("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));
            Console.WriteLine("Digite a terceira nota: ");
            n3 = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));

            media = (n1 + n2 + n3) / 3;
            string formatado = media.ToString("0.00");

            if (media >= 7)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Você foi aprovado com média {formatado} :)");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Você foi reprovado com média {formatado} :(");
                Console.ResetColor();
            }

            //ensinando a fazer
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nO codigo usado:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("double n1,n2,n3,media;\n" +
                              "Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "n1 = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(Mensagem entre aspas duplas));\n" +
                              "Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "n2 = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(Mensagem entre aspas duplas));\n" +
                              "Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "n3 = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(Mensagem entre aspas duplas));\n" +
                              "media = (n1+n2+n3)/3;\n" +
                              "string formatado =  media.ToString(0.00 -> entre aspas duplas);" +
                              "if(media >= 7){\n" +
                              "     Console.ForegroundColor = ConsoleColor.Green;\n" +
                              "     Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "     Console.ResetColor();\n" +
                              "}else{\n" +
                              "     Console.ForegroundColor = ConsoleColor.Red;\n" +
                              "     Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "     Console.ResetColor();\n" +
                              "}\n");

            Console.ResetColor();

        }

        public void UtFor()
        {

            int quantidade;
            double soma = 0, media = 0;
            Console.WriteLine("Quantas notas deseja digitar para fazer a média ?");
            quantidade = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Diga a {i + 1}ª nota: ");
                soma += double.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));
                media = soma / quantidade;
            }

            string formatado = media.ToString("0.00");

            if (media >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Você foi aprovado com média {formatado} :)");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Você foi reprovado com média {formatado} :(");
                Console.ResetColor();
            }

            //ensinando a fazer
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nO codigo usado:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("int quantidade;\n" +
                              "double soma = 0, media = 0;\n" +
                              "Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "quantidade = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException(mensagem entre aspas duplas));\n" +
                              "for(int i = 0; i<quantidade;i++ ){\n" +
                              "    Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "    soma += double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(Mensagem entre aspas duplas));\n" +
                              "    media = soma/quantidade;\n" +
                              "}\n" +
                              "string formatado =  media.ToString(0.00 -> entre aspas duplas);\n" +
                              "if(media >= 7){\n" +
                              "     Console.ForegroundColor = ConsoleColor.Green;\n" +
                              "     Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "     Console.ResetColor();\n" +
                              "}else{\n" +
                              "     Console.ForegroundColor = ConsoleColor.Red;\n" +
                              "     Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "     Console.ResetColor();\n" +
                              "}\n");

            Console.ResetColor();

        }

        public void UtWhile()
        {
            int quantidade, contador = 1;
            double soma = 0, media = 0;
            Console.WriteLine("Quantas notas deseja digitar para fazer a média ?");
            quantidade = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));

            while (contador <= quantidade)
            {
                Console.WriteLine($"Diga a {contador}ª nota: ");
                soma += double.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));
                media = soma / quantidade;
                contador++;
            }

            string formatado = media.ToString("0.00");

            if (media >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Você foi aprovado com média {formatado} :)");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Você foi reprovado com média {formatado} :(");
                Console.ResetColor();
            }

            //ensinando a fazer
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nO codigo usado:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("int quantidade,contador = 1;\n" +
                              "double soma = 0,media = 0;\n" +
                              "Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "quantidade = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException(mensagem entre aspas duplas));\n" +
                              "while(contador <= quantidade){\n" +
                              "    Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "    soma += double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(Mensagem entre aspas duplas));\n" +
                              "    media = soma/quantidade;\n" +
                              "    contador++\n" +
                              "}\n" +
                              "string formatado =  media.ToString(0.00 -> entre aspas duplas);\n" +
                              "if(media >= 7){\n" +
                              "     Console.ForegroundColor = ConsoleColor.Green;\n" +
                              "     Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "     Console.ResetColor();\n" +
                              "}else{\n" +
                              "     Console.ForegroundColor = ConsoleColor.Red;\n" +
                              "     Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "     Console.ResetColor();\n" +
                              "}\n");

            Console.ResetColor();
        }

        public void UtDoWhile()
        {
            int quantidade, contador = 1;
            double soma = 0, media = 0;
            Console.WriteLine("Quantas notas deseja digitar para fazer a média ?");
            quantidade = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));

            do
            {
                Console.WriteLine($"Diga a {contador}ª nota: ");
                soma += double.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));
                media = soma / quantidade;
                contador++;
            } while (contador <= quantidade);

            string formatado = media.ToString("0.00");

            if (media >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Você foi aprovado com média {formatado} :)");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Você foi reprovado com média {formatado} :(");
                Console.ResetColor();
            }

            //ensinando a fazer
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nO codigo usado:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("int quantidade,contador = 1;\n" +
                              "double soma = 0, media = 0;\n" +
                              "Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "quantidade = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException(mensagem entre aspas duplas));\n" +
                              "do{\n" +
                              "    Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "    soma += double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(Mensagem entre aspas duplas));\n" +
                              "    media = soma/quantidade;\n" +
                              "    contador++\n" +
                              "}while(contador <= quantidade);\n" +
                              "string formatado =  media.ToString(0.00 -> entre aspas duplas);\n" +
                              "if(media >= 7){\n" +
                              "     Console.ForegroundColor = ConsoleColor.Green;\n" +
                              "     Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "     Console.ResetColor();\n" +
                              "}else{\n" +
                              "     Console.ForegroundColor = ConsoleColor.Red;\n" +
                              "     Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "     Console.ResetColor();\n" +
                              "}\n");

            Console.ResetColor();
        }

        public void UtArray()
        {
            int quantidade;
            double soma = 0, media = 0;   
            Console.WriteLine("Quantas notas deseja digitar para fazer a média ?");
            quantidade = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));
            double[] notas = new double[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Diga a {i + 1}ª nota: ");
                notas[i] = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));
                soma += notas[i];
                media = soma / quantidade;
            }

            string formatado = media.ToString("0.00");

            if (media >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Você foi aprovado com média {formatado} :)");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Você foi reprovado com média {formatado} :(");
                Console.ResetColor();
            }

            //ensinando a fazer
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nO codigo usado:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("int quantidade;\n" +
                              "double soma = 0, media = 0;\n" +
                              "Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "quantidade = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException(mensagem entre aspas duplas));\n" +
                              "double[] notas = new double[quantidade];\n" +
                              "for(int i = 0; i<quantidade;i++ ){\n" +
                              "    Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "    notas[i] = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(Mensagem entre aspas duplas));\n" +
                              "    soma += notas[i];\n" +
                              "    media = soma/quantidade;\n" +
                              "}\n" +
                              "string formatado =  media.ToString(0.00 -> entre aspas duplas);\n" +
                              "if(media >= 7){\n" +
                              "     Console.ForegroundColor = ConsoleColor.Green;\n" +
                              "     Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "     Console.ResetColor();\n" +
                              "}else{\n" +
                              "     Console.ForegroundColor = ConsoleColor.Red;\n" +
                              "     Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "     Console.ResetColor();\n" +
                              "}\n");

            Console.ResetColor();

        }

        public void UtList()
        {
            int quantidade;
            double soma = 0, media = 0;   
            Console.WriteLine("Quantas notas deseja digitar para fazer a média ?");
            quantidade = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!"));
            List<double> notas = new List<double>();

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Diga a {i + 1}ª nota: ");
                notas.Add(double.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula!!")));
                soma += notas[i];
                media = soma / quantidade;
            }

            string formatado = media.ToString("0.00");

            if (media >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Você foi aprovado com média {formatado} :)");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Você foi reprovado com média {formatado} :(");
                Console.ResetColor();
            }

            //ensinando a fazer
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nO codigo usado:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("int quantidade;\n" +
                              "double soma = 0, media = 0;\n" +
                              "Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "quantidade = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException(mensagem entre aspas duplas));\n" +
                              "List<double> notas = new List<double>();\n" +
                              "for(int i = 0; i<quantidade;i++ ){\n" +
                              "    Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "    notas.Add(double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(mensagem entre aspas duplas)));\n" +
                              "    soma += notas[i];\n" +
                              "    media = soma/quantidade;\n" +
                              "}\n" +
                              "string formatado =  media.ToString(0.00 -> entre aspas duplas);\n" +
                              "if(media >= 7){\n" +
                              "     Console.ForegroundColor = ConsoleColor.Green;\n" +
                              "     Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "     Console.ResetColor();\n" +
                              "}else{\n" +
                              "     Console.ForegroundColor = ConsoleColor.Red;\n" +
                              "     Console.WriteLine(mensagem entre aspas duplas);\n" +
                              "     Console.ResetColor();\n" +
                              "}\n");

            Console.ResetColor();

        }

        public void Op(string opcao){
            Menu menu = new Menu();
            switch (opcao)
            {

                case "1":
                    HelloWorld();
                    break;

                case "2":
                    UtIfElse();
                    break;
                case "3":
                    UtFor();
                    break;
                case "4":
                    UtWhile();
                    break;
                case "5":
                    UtDoWhile();
                    break;
                case "6":
                    UtArray();
                    break;
                case "7":
                    UtList();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("DIGITE UM OPÇÃO VALIDA");
                    Console.ResetColor();
                    menu.Mensagem();
                    break;
            }
        }
    }
}