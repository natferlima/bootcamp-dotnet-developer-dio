using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2) // métodos que tem um corpo na interface são opcionais para implementação nas classes
        {
            return num1 / num2;
        }
    }
}