using Conta.Entities;
using System;

namespace ContaH
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaJuridica conta = new ContaJuridica(8010, "Ana", 100, 500);

            Console.WriteLine(conta.Saldo);
        }
    }
}
