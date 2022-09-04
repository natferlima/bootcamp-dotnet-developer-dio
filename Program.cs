using bootcamp_dotnet_developer_dio.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Natália";
pessoa1.Idade = 25;
pessoa1.Apresentar();

string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.80; // não é usado para representar casas decimais
decimal preco = 1.80M; 
// sempre representar valores monetários com decimal

DateTime dataAtual = DateTime.Now; // sempre pega a data atual da máquina que está executando


Console.WriteLine(apresentacao);
Console.WriteLine(quantidade);
Console.WriteLine(altura);
Console.WriteLine(altura.ToString("0.00")); // para mostrar as duas casas decimais
Console.WriteLine(preco);
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(DateTime.Now.AddDays(5));


