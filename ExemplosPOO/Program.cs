using ExemplosPOO.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Natália";
p1.Idade = 25;

p1.Apresentar();


ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.saldo = 5 não é possivel acessar pois é privado

c1.ExibirSaldo();
c1.Sacar(5000);
c1.ExibirSaldo();


Aluno a1 = new Aluno();
a1.Nome = "Natália";
a1.Idade = 25;
a1.Nota = 10;
a1.Apresentar();


Professor prof1 = new Professor();
prof1.Nome = "Ana";
prof1.Idade = 25;
prof1.Salario = 1000;
prof1.Apresentar();
