using ExemplosFundamentos.Common.Models;

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


// Conversões - Cast - Casting

int a = Convert.ToInt32("5"); // converte null para 0
int b = int.Parse("5"); // não aceita nulo, dá erro se receber null

int c = 5;
string d = c.ToString(); // todas as classes do c# herdam da classe object e essa classe object tem o método ToString()

// Cast Implícito
int e = 5;
double f = e; // um inteiro cabe no double, por isso ele faz uma conversão direta

int g = 5;
long h = g; // tbm faz cast inplícito pq um inteiro cabe no long

// Conversão segura

string i = "15-";
int j = 0;
int.TryParse(i, out j); // tenta converter i e se não der retorna j;
int.TryParse(i, out int k); // coloca o valor padrao 0 para k

// Switch
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch(letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}

// Operadores Aritméticos em C#

Calculadora calc = new Calculadora();

calc.Somar(10, 40);
calc.Subtrair(100, 50);
calc.Multiplicar(10, 5);
calc.Dividir(100, 4);
calc.Potencia(3, 3);
calc.Seno(30); // não mostra os zeros mesmo pedindo 4 casas decimais
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);

// Arrays

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

// alterando o tamanho do array
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Copiando array
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"\n Posição nº {contador} - {arrayInteiros[contador]} \n");
}

Console.WriteLine("Percorrenco Array com foreach");
int contador2 = 0;
foreach(int valor in arrayInteiros) {
    Console.WriteLine($"\n Posição nº {contador2} - {valor} \n");
    contador2++;
}


// Listas

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for(int contador = 0; contador < listaString.Count; contador ++) {
    Console.WriteLine($"Posição nº {contador} - {listaString[contador]}");
}

foreach(string item in listaString) {
    Console.WriteLine($"{item}");
}


Console.WriteLine(apresentacao);
Console.WriteLine(quantidade);
Console.WriteLine(altura);
Console.WriteLine(altura.ToString("0.00")); // para mostrar as duas casas decimais
Console.WriteLine(preco);
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(DateTime.Now.AddDays(5));
Console.WriteLine(a);
Console.WriteLine(d);


