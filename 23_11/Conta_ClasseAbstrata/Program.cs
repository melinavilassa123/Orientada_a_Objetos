using Conta_ClasseAbstrata.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Conta_ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Conta> list = new List<Conta>();

            
            list.Add(new ContaPoupanca(1001, "Terry", 500, 0.01));
            list.Add(new ContaJuridica(1002, "Andy", 500, 400));
            list.Add(new ContaPoupanca(1003, "Joe", 500, 0.01));
            list.Add(new ContaJuridica(1004, "Mae", 500, 400));

            
            double soma = 0;

            
            foreach(Conta acc in list)
            {
                soma += acc.Saldo;
            }

            
            Console.WriteLine("Total do saldo de todas as contas: " + soma.ToString("F2", CultureInfo.InvariantCulture));

            
            foreach (Conta acc in list)
            {
                acc.Saque(10);
            }

            
            foreach (Conta acc in list)
            {
                Console.WriteLine("Atualização do saldo da conta " + acc.Numero + ": " + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
