using CalculadoraSimples.Models;
using CalculadoraSimples.View;


//chamada de menu
Menu e = new Menu();
e.MensagemMenu();

//auxilar para manter o programa rodando mais de 1 interação
int cont = 1;

// enquanto onde roda todas as funcionalidades 
while (cont == 1){

    int x,y;
    string alerta = string.Empty;
    Calculadora calculadora = new Calculadora();
    Acoes acoes = new Acoes();

    Console.WriteLine("Escolhe a opção desejada: ");
    
    //Utilizo uma string em vez de Char para que caso o usuario digite um numero com mais de 1 caractere não acabe quebrando a aplicação
    string operacao = Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula.");      
    Console.Clear();

    switch (operacao){
            
        case "0":
            cont = 0;
            break;
        
        case "1":
               
            Console.WriteLine("Digite o primeiro valor: ");
            x = acoes.X();
                
            Console.WriteLine("Digite o segundo valor: ");
            y = acoes.Y();
                
            calculadora.Somar(x,y);
                
            cont = acoes.Decidir();

        break;

        case "2":

            Console.WriteLine("Digite o primeiro valor: ");
            x = acoes.X();

            Console.WriteLine("Digite o segundo valor: ");
            y = acoes.Y();
                
            calculadora.Subtrair(x,y);

            cont = acoes.Decidir();

        break;
        
        case "3":

            Console.WriteLine("Digite o primeiro valor: ");
            x = acoes.X();

            Console.WriteLine("Digite o segundo valor: ");
            y = acoes.Y();
                
            calculadora.Dividir(x,y);

            cont = acoes.Decidir();

        break;

        case "4":

            Console.WriteLine("Digite o primeiro valor: ");
            x = acoes.X();

            Console.WriteLine("Digite o segundo valor: ");
            y = acoes.Y();

            calculadora.Multiplicar(x,y);            

            cont = acoes.Decidir();  

        break;

        case "5":

            Console.WriteLine("Digite a base: ");
            x = acoes.X();

            Console.WriteLine("Digite o expoente: ");
            y = acoes.Y();

            calculadora.Potencia(x,y);            

            cont = acoes.Decidir();

        break;

        case "6":

            Console.WriteLine("Digite o grau: ");
            x = acoes.X();

            calculadora.Seno(x);            

            cont = acoes.Decidir(); 

        break;

        case "7":

            Console.WriteLine("Digite o grau: ");
            x = acoes.X();

            calculadora.Cosseno(x);            

            cont = acoes.Decidir();  

        break;

        case "8":

            Console.WriteLine("Digite o grau: ");
            x = acoes.X();

            calculadora.Tangente(x);            

            cont = acoes.Decidir();  

        break;

        default:
            
            alerta = "Digite uma opção válida por favor !!";

        break;
    }

    if(cont == 0){
        Console.Clear();
    }else{
        Console.Clear();
        
        e.MensagemMenu();

        if(alerta != string.Empty){
            
            //define a cor de texto para vermelho
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(alerta);
        
            // Restaura a cor original
            Console.ResetColor();
        
        }

    }


}