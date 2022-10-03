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