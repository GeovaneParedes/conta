using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito incial?(s/n) ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp  == 'S')
            {
                Console.Write("Qual valor será depositado: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Qual o valor de deposito? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados!");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Qual valor do saque? ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados!");
            Console.WriteLine(conta);

        }

    }
}