using CalculadoraSimples.Models;
using CalculadoraSimples.View;


//chamada de menu
Menu e = new Menu();
e.MensagemMenu();

//auxilar para manter o programa rodando mais de 1 interação
int cont = 1;

// enquanto onde roda todas as funcionalidades 
while (cont == 1)
{
    //Declarações necessarias
    int x, y;
    string alerta = string.Empty;
    Calculadora calculadora = new Calculadora();
    Acoes acoes = new Acoes();

    Console.WriteLine("Escolhe a opção desejada: ");
    //Utilizo uma string em vez de Char para que caso o usuario digite um numero com mais de 1 caractere não acabe quebrando a aplicação
    string operacao = Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula.");
    Console.Clear();

    //Decisões possiveis
    switch (operacao)
    {

        case "0":
            //Gerando a parada do While
            cont = 0;
            break;
        case "1":
            //Recebendo os números que se quer somar
            Console.WriteLine("Digite o primeiro valor: ");
            x = acoes.X();
            Console.WriteLine("Digite o segundo valor: ");
            y = acoes.Y();

            //Executando a soma
            calculadora.Somar(x, y);
            //Decisão de o que fazer após receber o resultado
            cont = acoes.Decidir();
            break;
        case "2":
            //Recebendo os números que se quer subtrair
            Console.WriteLine("Digite o primeiro valor: ");
            x = acoes.X();
            Console.WriteLine("Digite o segundo valor: ");
            y = acoes.Y();

            //Executando a subtração
            calculadora.Subtrair(x, y);
            //Decisão de o que fazer após receber o resultado
            cont = acoes.Decidir();
            break;
        case "3":
            //Recebendo os números que se quer Dividir
            Console.WriteLine("Digite o primeiro valor: ");
            x = acoes.X();
            Console.WriteLine("Digite o segundo valor: ");
            y = acoes.Y();

            //Executando a divisão
            calculadora.Dividir(x, y);
            //Decisão de o que fazer após receber o resultado
            cont = acoes.Decidir();
            break;
        case "4":
            //Recebendo os números que se quer Multiplicar
            Console.WriteLine("Digite o primeiro valor: ");
            x = acoes.X();
            Console.WriteLine("Digite o segundo valor: ");
            y = acoes.Y();

            //Executando a multiplicação
            calculadora.Multiplicar(x, y);
            //Decisão de o que fazer após receber o resultado
            cont = acoes.Decidir();
            break;
        case "5":
            //Recebendo os números que se quer ter a Potência
            Console.WriteLine("Digite a base: ");
            x = acoes.X();
            Console.WriteLine("Digite o expoente: ");
            y = acoes.Y();

            //Executando a potenciação
            calculadora.Potencia(x, y);
            //Decisão de o que fazer após receber o resultado
            cont = acoes.Decidir();
            break;
        case "6":
            //Recebendo o grau que se quer ter o Seno
            Console.WriteLine("Digite o grau: ");
            x = acoes.X();

            //Executando o Seno
            calculadora.Seno(x);
            //Decisão de o que fazer após receber o resultado
            cont = acoes.Decidir();
            break;
        case "7":
            //Recebendo o grau que se quer ter o Cosseno
            Console.WriteLine("Digite o grau: ");
            x = acoes.X();

            //Executando o Cosseno
            calculadora.Cosseno(x);
            //Decisão de o que fazer após receber o resultado
            cont = acoes.Decidir();
            break;
        case "8":
            //Recebendo o grau que se quer ter a Tangente
            Console.WriteLine("Digite o grau: ");
            x = acoes.X();

            //Executando a Tangente
            calculadora.Tangente(x);
            //Decisão de o que fazer após receber o resultado
            cont = acoes.Decidir();
            break;
        case "9":
            //Recebendo o grau que se quer ter a Tangente
            Console.WriteLine("Digite o número que quer saber a Raiz quadrada: ");
            x = acoes.X();

            //Executando a Tangente
            calculadora.RaizQuadrada(x);
            //Decisão de o que fazer após receber o resultado
            cont = acoes.Decidir();
            break;
        default:
            alerta = "Digite uma opção válida por favor !!";
            break;
    }

    if (cont == 0)
    {
        //Limpando antes de sair
        Console.Clear();
    }
    else
    {
        //mantendo o console sempre limpo a cada execução
        Console.Clear();
        //Chamada de menu
        e.MensagemMenu();

        if (alerta != string.Empty)
        {
            //define a cor de texto para vermelho
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(alerta);
            // Restaura a cor original
            Console.ResetColor();

        }

    }


}