//Faça um programa em C# que compare dois números inteiros e informe qual o maior entre eles.

using System;

namespace exercícios
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if(n1 > n2)
            {
                Console.WriteLine("O primeiro é maior");
            }
            else
            {
                Console.WriteLine("O segundo é maior");
            }

        }
    }
}