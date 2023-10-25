using ExemplosFundamentos.Models;

string nome;
int idade;
double altura;

Console.WriteLine("Digite o seu nome por favor: ");
nome = Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula.");

Console.WriteLine("Digite a sua idade por favor: ");
idade = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));

Console.WriteLine("Digite a sua altura por favor: ");
altura = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));

Pessoa pessoa = new Pessoa(nome, idade, altura);

pessoa.Apresentar();