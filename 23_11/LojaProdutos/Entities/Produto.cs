using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LojaProdutos.Entities
{
    class Produto
    {
        
        public string Nome { get; private set; }
        public double Preco { get; private set; }

        
        public Produto() { }

        
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        
        public virtual string PrecoTag()
        {
            return Nome + " - R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
