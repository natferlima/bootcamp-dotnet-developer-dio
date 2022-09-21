using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

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


// LEITURA DE ARQUIVO

try {

    string[] linhas = File.ReadAllLines("Arquivos/pasta/arquivo_Leitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }

} 
catch(FileNotFoundException ex) 
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex) 
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch(Exception ex) // exceção genérica
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally // sempre executa dando erro ou não
{
    Console.WriteLine("Chegou até aqui");
}

new ExemploExcecao().Metodo1(); // jogando uma exceção genérica com throw e se não tratar com try catch exibe o stack trace



// FILA

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

foreach(int item in fila)
{
    Console.WriteLine(item);
}



// PILHA

Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

pilha.Push(20);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

// DICTIONARY - as chaves são sempre únicas

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("RJ", "Rio de Janeiro");
estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("RJ"); // remove sempre pela chave
estados["MG"] = "Minas Gerais - valor alterado";

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "SP";
Console.WriteLine($"Verificando o elemento: {chave}");
if(estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}

Console.WriteLine(estados["MG"]); // acessando valores do dicionário



// TUPLAS

(int, string, string, decimal) tupla = (1, "Natália", "Lima", 10.5M); // mais recomendado pela legibilidade do código

// outras formas de criar uma tupla:
// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Natália", "Lima", 1.80M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Natália", "Lima", 1.80M);

Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");


LeituraArquivo arquivo = new LeituraArquivo();
var (sucesso2, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// Coloando _ em uma das posições da tupla está indicando que esse valor não será usado = descarte
// var (sucesso2, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt"); 

if (sucesso2)
{
    Console.WriteLine("Quantidade linhas do arquivo:" + quantidadeLinhas);
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
    
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");

}


// DECONSTRUCT

Pessoa p5 = new Pessoa("Natália", "Lima");
(string nome, string sobrenome) = p5;

Console.WriteLine($"{nome} {sobrenome}");



// IF TERNÁRIO

int numero2 = 15;
bool ehPar = false;

ehPar = numero2 % 2 == 0;

Console.WriteLine($"O número {numero2} é " + (ehPar ? "par" : "ímpar"));



// NUGET, SERIALIZAR E ATRIBUTOS

DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);

// ISO 8601 padroniza a representação de datas entre sistemas


string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach(Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " + $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}