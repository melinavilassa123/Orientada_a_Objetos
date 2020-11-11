using System;
using System.Globalization;

namespace ContaBancaria
{
    class ContaBancaria
    {
        
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
       
        public ContaBancaria()
        {
        }       
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }       
        public void RealizarDeposito(double valor)
        {
            Saldo += valor;
        }
        public void RealizarSaque(double valor)
        {
            Saldo -= valor + 5;
        }
        public override string ToString()
        {
            return  "\nConta   - " + Numero.ToString(CultureInfo.InvariantCulture)
                    + "\nTitular - " + Titular
                    + "\nSaldo   - R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
