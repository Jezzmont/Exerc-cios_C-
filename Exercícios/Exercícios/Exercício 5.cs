//Faça um programa em C# que compare 3 números inteiros e informe qual o menor entre eles.

using System;

namespace exercícios
{
    class Exercicio5
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o primeiro número?");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual o segundo número?");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual o terceiro número?");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if(n1 < n2 && n1 < n3)
            {
                Console.WriteLine("O primeiro número é menor");
            }
            else
            {
                if(n2 < n1 && n2 < n3)
                {
                    Console.WriteLine("O segundo número é menor");
                }
                else
                {
                    if(n3 < n1 && n3 < n2)
                    {
                        Console.WriteLine("O terceiro número é menor");
                    }
                }
            }
        }
    }
}