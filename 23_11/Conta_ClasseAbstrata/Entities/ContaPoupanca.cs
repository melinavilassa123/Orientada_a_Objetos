using System;
using System.Collections.Generic;
using System.Text;

namespace Conta_ClasseAbstrata.Entities
{
    
    class ContaPoupanca : Conta
    {
        
        public double TaxaJuros { get; set; }

        
        public ContaPoupanca() { }

        
        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros)
            : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        
        public void AtualizacaoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }

        
        public sealed override void Saque(double saldoTotal)
        {
            
            base.Saque(saldoTotal);
            Saldo -= 2;
        }
    }
}
