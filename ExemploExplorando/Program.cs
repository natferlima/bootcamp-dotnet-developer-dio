using ExemploExplorando.Models;
using System.Globalization;

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
// uma forma de mudar informações de localização

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


decimal valorMonetario = 1582.40M;
Console.WriteLine($"{valorMonetario:C}"); // :C siginifica que quer formatar para moeda local q o sistema está configurado
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(valorMonetario.ToString("C1")); // C significa q é moeda e o 1 é a quantidade de casas decimais


double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));


// Formatando o tipo DateTime

DateTime data = DateTime.Now;
DateTime data2 = DateTime.Parse("17/04/2022 18:00");
string dataString = "2022-04-17 18:00";

bool sucesso = DateTime.TryParseExact(dataString, 
                                "yyyy-MM-dd HH:mm", 
                                CultureInfo.InvariantCulture, 
                                DateTimeStyles.None, 
                                out data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}

Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());
Console.WriteLine(data2);

