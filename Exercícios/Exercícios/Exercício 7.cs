//Faça um programa em C# que informe se um número é divisível por 5.

using System;

namespace exercícios
{
    class Exercicio7
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Qual o número?");
           var n = Convert.ToInt32(Console.ReadLine());

           if((n % 5) == 0)
           {
            Console.WriteLine("Sim, o número é divisível por 5");
           } 
           else
           {
            Console.WriteLine("O número não é divisível por 5");
           }
        }
    }
}