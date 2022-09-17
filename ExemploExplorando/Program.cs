using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Natália";
p1.Sobrenome = "Lima";
p1.Idade = 20;
p1.Apresentar();

Pessoa p2 = new Pessoa("Ana", "Lima");

Curso cursoDeInlges = new Curso();
cursoDeInlges.Nome = "Inglês";
cursoDeInlges.Alunos = new List<Pessoa>();
cursoDeInlges.AdicionarAluno(p1);
cursoDeInlges.AdicionarAluno(p2);
cursoDeInlges.ListarAlunos();