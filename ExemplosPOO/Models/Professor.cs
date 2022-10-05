using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Models
{
    public sealed class Professor : Pessoa
    {
        // sealed indica que a classe Professor não pode ter classes filhas, ninguem pode herdar de Professor
        // a clasee Pessoa tem como obrigatorio o atributo nome entao tenho q fazer a classe filha exigir o nome e passar esse nome para a classe pai através no base(nome)
        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario}");
        }
    }
}