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

    Console.WriteLine("Escolhe a opção desejada: ");
    
    //Utilizo uma strig em vez de Char para que caso o usuario digite um numero com mais de 1 caractere não acabe quebrando a aplicação
    string operacao = Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula.");      
    Console.Clear();

    switch (operacao){
            
        case "0":
            cont = 0;
            break;
        
        case "1":
               
            Console.WriteLine("Digite o primeiro valor: ");
            x = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));
                
            Console.WriteLine("Digite o segundo valor: ");
            y = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));
                
            calculadora.Somar(x,y);
                
            Console.WriteLine("Digite 0 para encerra e 1 para realizar outra operação: ");
            cont = int.Parse(Console.ReadLine() ?? throw new Exception());

        break;

        case "2":

            Console.WriteLine("Digite o primeiro valor: ");
            x = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));
                
            Console.WriteLine("Digite o segundo valor: ");
            y = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));
                
            calculadora.Subtrair(x,y);

            Console.WriteLine("Digite 0 para encerra e 1 para realizar outra operação: ");
            cont = int.Parse(Console.ReadLine() ?? throw new Exception());

        break;
        
        case "3":

            Console.WriteLine("Digite o primeiro valor: ");
            x = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));
                
            Console.WriteLine("Digite o segundo valor: ");
            y = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));
                
            calculadora.Dividir(x,y);

            Console.WriteLine("Digite 0 para encerra e 1 para realizar outra operação: ");
            cont = int.Parse(Console.ReadLine() ?? throw new Exception());

        break;

        case "4":

            Console.WriteLine("Digite o primeiro valor: ");
            x = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));
                
            Console.WriteLine("Digite o segundo valor: ");
            y = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));

            calculadora.Multiplicar(x,y);            

            Console.WriteLine("Digite 0 para encerra e 1 para realizar outra operação: ");
            cont = int.Parse(Console.ReadLine() ?? throw new Exception());    

        break;

        case "5":

            Console.WriteLine("Digite a base: ");
            x = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));
                
            Console.WriteLine("Digite o expoente: ");
            y = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));

            calculadora.Potencia(x,y);            

            Console.WriteLine("Digite 0 para encerra e 1 para realizar outra operação: ");
            cont = int.Parse(Console.ReadLine() ?? throw new Exception());    

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