using PropriedadesMetodosConstrutores.Models;

Pessoa p1 = new Pessoa("Antonio Aldacélio",24);
Pessoa p2 = new Pessoa("Najla Bernardo",26);

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();






