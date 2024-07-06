/*Faça um programa em C# que leia o valor do salário bruto de um funcionário e aplique um aumento de 10% 
caso o salário informado seja igual ou menor que R$ 500,00.*/

using System;

namespace exercícios
{
    class Exercício6
    {
        static void Main(string[] args)
        {
             Console.Write("Qual o salário?");
             var salario = Convert.ToInt32(Console.ReadLine());

             if(salario <= 500)
             {
                var aumento = (salario + ((salario * 10) / 100));
                Console.WriteLine("O seu novo salário é: " + aumento);
             }
             else
             {
                Console.WriteLine("Não haverá aumento!");
             }
        }
    }
}