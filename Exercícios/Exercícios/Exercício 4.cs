/*Faça um programa em C# que informe se um aluno está aprovado, reprovado ou em recuperação com base 
na média das notas de duas provas.
Aprovado = Média igual ou maior que 7
Recuperação = Média igual ou maior que 4 e igual ou menor que 6
Reprovado = Nota menor que 4*/

using System;

namespace exercícios
{
    class Exercicio4
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a nota da N1?");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual a nota da N2?");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Double media = (n1 + n2) / 2;

            if(media >= 7)
            {
                Console.WriteLine("Aprovado! Sua média foi: " + media);
            }
            else
            {
                if(media < 4)
                {
                    Console.WriteLine("Reprovado! Sua média foi: " + media);
                }
                else
                {
                    Console.WriteLine("Você está de recuperação! Sua média foi: " + media);
                }
            }
        }
    }
}