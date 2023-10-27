using Exemplos_Fundamentos.View;
using Exemplos_Fundamentos.Models;

int cont = 1;
while(cont == 1)
{

    //chamando o MENU pela primeira vez
    Menu menu = new Menu();
    cont = menu.Mensagem();
    Console.Clear();
    

}



































// string nome;
// int idade;
// double altura;

// Console.WriteLine("Digite o seu nome por favor: ");
// nome = Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula.");

// Console.WriteLine("Digite a sua idade por favor: ");
// idade = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));

// Console.WriteLine("Digite a sua altura por favor: ");
// altura = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));

// Pessoa pessoa = new Pessoa(nome, idade, altura);

// pessoa.Apresentar();

// // trabalhando com arrays

// Console.WriteLine("Quantas posições você deseja que seu array contenha ? ");
// int posições = int.Parse(Console.ReadLine() ?? throw new ArgumentException("A entrada não pode ser nula."));

// int[] vet = new int[posições];

// Console.WriteLine("Preencha seu vetor");

// for(int i = 0; i< vet.Length;i++){
//     Console.WriteLine($"Digite a {i+1}ª posição: ");
//     vet[i] = int.Parse(Console.ReadLine() ?? throw new ArgumentException("A entrada não pode ser nula."));
// }

// //percorrendo vetor com foreach
// int j = 1;
// foreach(int valor in vet){
    
//     Console.WriteLine($"O valor da {j}ª posição é: {valor}");
//     j++;
    
// }

// int[] copiaVet = new int[vet.Length*2];

// Array.Copy(vet, copiaVet, vet.Length);

// for(int i = vet.Length; i< copiaVet.Length;i++){
//     Console.WriteLine($"Digite a {i+1}ª posição: ");
//     copiaVet[i] = int.Parse(Console.ReadLine() ?? throw new ArgumentException("A entrada não pode ser nula."));
// }

// //percorrendo vetor com foreach
// j = 1;
// foreach(int valor in copiaVet){
    
//     Console.WriteLine($"O valor da {j}ª posição é: {valor}");
//     j++;
    
// }