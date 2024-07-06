/*Faça um programa em C# que leia dois números e uma operação (+, -, *, / ), em seguida o programa deverá 
fazer o cálculo com base na operação informada.*/

using System;

namespace exercícios
{
    class Exercicio9
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o primeiro número: ");
            double n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            double n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual a operação que deseja fazer? ");
            var op = Console.ReadLine();

            double resultado = 0;

            switch(op)
            {
                case "+":
                    resultado = n1 + n2;
                    break;
                
                case "-":
                    resultado = n1 - n2;
                    break;
                
                case "*":
                    resultado = n1 * n2;
                    break;
                
                case "/":
                    resultado = n1 / n2;
                    break;
            }
            Console.WriteLine("O resultado é: " + resultado);    
        }
    }
}