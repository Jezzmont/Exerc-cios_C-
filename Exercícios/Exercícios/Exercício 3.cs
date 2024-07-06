/*Faça um programa em C# que simule um caixa eletrônico. O usuário terá um saldo de R$ 1000,00 
e poderá ter saques autorizados caso o valor solicitado esteja dentro do limite de saldo.*/

using System;

namespace exercícios
{
    class Exercicio3
    {
        static void Main(string[] args)
        {
            double saldo = 1000;
            Console.WriteLine("Qual o valor que você deseja sacar?");
            double saque = Convert.ToInt32(Console.ReadLine());

            if(saque <= saldo)
            {
                double nsaldo = saldo - saque;
                Console.WriteLine("Saque autorizado. " + "Saldo atualizado:R$ " + nsaldo);
            }
            else
            {
                Console.WriteLine("Saque não autorizado. Saldo insuficiente");
            }    
        }
    }
}