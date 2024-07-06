//Faça um programa em C# que permita informar 4 notas e exibir a média delas no final.

using System;

namespace exercícios
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a nota da N1?");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual a nota da N2?");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual a nota da N3?");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual a nota da N4?");
            int n4 = Convert.ToInt32(Console.ReadLine());

            double media = ((n1 + n2 + n3 + n2) / 4);

            if(media > 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
            
        }
    }
}