/*Faça um programa em C# que calcule o aumento do salário de um funcionário de acordo com a sua classe:
A = 10%
B = 15%
C = 20%*/

using System;

namespace exercícios
{
    class Exercicio8
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a sua Classe:");
            string classe = Console.ReadLine()!;

            Console.Write("Agora informe o seu salário: ");
            double salario = Convert.ToInt32(Console.ReadLine());

            double nsalario = 0;

            switch(classe)
            {
                case "a":
                    nsalario = salario + ((salario * 10) / 100);
                    break;
                
                case "b":
                    nsalario = salario + ((salario * 15) / 100);
                    break;
                
                case "c":
                    nsalario = salario + ((salario * 20) / 100);
                    break;
                
                default:
                    Console.WriteLine("Classe não existe!");
                    break;
            }
            Console.WriteLine("Novo salário: " + nsalario);
        }
    }
}