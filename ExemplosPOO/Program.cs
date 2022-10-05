using ExemplosPOO.Models;
using ExemplosPOO.Interfaces;

Pessoa p1 = new Pessoa("Natália");
p1.Idade = 25;

p1.Apresentar();


ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.saldo = 5 não é possivel acessar pois é privado

c1.ExibirSaldo();
c1.Sacar(5000);
c1.ExibirSaldo();


Aluno a1 = new Aluno("Natália");
a1.Idade = 25;
a1.Nota = 10;
a1.Apresentar();


Professor prof1 = new Professor("Ana");
prof1.Idade = 25;
prof1.Salario = 1000;
prof1.Apresentar();



Corrente c  = new Corrente();
c.Creditar(500);
c.ExibirSaldo();


Computador comp = new Computador();
Console.WriteLine(comp.ToString()); // método sobrescrito da classe Object que é a mae de todas as classes no .NET


ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3,3));



