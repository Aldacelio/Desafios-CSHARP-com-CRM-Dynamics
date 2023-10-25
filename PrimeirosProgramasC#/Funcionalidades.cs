public class Funcionalidades
{

    //imprimir o Hello Word 
    public int op1()
    {
        Console.Clear();
        Console.WriteLine("Hello Word");
        return 0;
    }

    //Teste de aprovação
    public int op2()
    {
        Console.Clear();
        Console.Write("Qual a nota : ");
        var nota = Int32.Parse(Console.ReadLine());

        if (nota >= 7)
        {
            Console.WriteLine("APROVADO!!!");
        }
        else if (nota >= 4)
        {
            Console.WriteLine("RECUPERAÇÃO!!!");
        }
        else
        {
            Console.WriteLine("REPROVADO!!!");
        }

        return 0;
    }

    //sequencia de numeros

    public int op3()
    {

        Console.Clear();

        Console.WriteLine("Digite uma sequencia de numeros com um espaço: ");

        var numerosTexto = Console.ReadLine();

        var numeros = numerosTexto.Split(' ');

        Console.WriteLine("Numeros: ");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }

        return 0;
    }

    public int op4()
    {

        Console.Clear();

        Console.WriteLine("Digite uma sequencia de numeros com um espaço: ");

        var numerosTexto = Console.ReadLine();

        var numeros = numerosTexto.Split(' ');

        Console.WriteLine("Numeros: ");

        int cont = 0;

        while (cont < numeros.Length)
        {
            Console.WriteLine(numeros[cont]);
            cont++;
        }
        return 0;
    }

    public int op5()
    {

        Console.Clear();

        Console.WriteLine("Digite uma sequencia de numeros com um espaço: ");

        var numerosTexto = Console.ReadLine();

        var numeros = numerosTexto.Split(' ');

        Console.WriteLine("Numeros: ");

        foreach (string numero in numeros)
        {
            Console.WriteLine(numero);
        }
        return 0;
    }
}