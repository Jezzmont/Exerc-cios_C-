//Faça um programa em C# que leia notas de um aluno e informe com base na média qual o resultado deste aluno.

using System;

namespace exercícios
{
    class Exercicio10
    {
        static void Main(string[] args)
        {
            Console.Write("Infome a primeira nota: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a terceira nota: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a quarta nota: ");
            int n4 = Convert.ToInt32(Console.ReadLine());

            int media = (n1 + n2 + n3 + n4) / 4;

            switch(media)
            {
                case 0:
                    Console.WriteLine("Reprovado, muito abaixo do esperado");
                    break;
                
                case 1:
                    Console.WriteLine("Reprovado, abaixo do esperado");
                    break;
                
                case 2:
                    Console.WriteLine("Reprovado, estude mais");
                    break;
                
                case 3:
                    Console.WriteLine("Reprovado, faltou 1 ponto");
                    break;
                
                case 4:
                    Console.WriteLine("Recuperação, precisa de média 8");
                    break;
                
                case 5:
                    Console.WriteLine("Recuperação, precisa de média 7");
                    break;
                
                case 6:
                    Console.WriteLine("Recuperação precisa de media 6");
                    break;
                
                case 7:
                    Console.WriteLine("Aprovado! tome cuidado na próxima");
                    break;
                
                case 8:
                    Console.WriteLine("Aprovado!");
                    break;
                
                case 9:
                    Console.WriteLine("Aprovado, parabéns!");
                    break;
                
                case 10:
                    Console.WriteLine("Aprovado com louvor!!!");
                    break;
            }
        }
    }

}