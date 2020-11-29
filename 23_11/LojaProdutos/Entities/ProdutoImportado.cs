using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LojaProdutos.Entities
{
    class ProdutoImportado : Produto
    {
        
        public double Taxa { get; private set; }

        
        public ProdutoImportado() { }

        
        public ProdutoImportado(string nome, double preco, double taxa) : base(nome, preco)
        {
            Taxa = taxa;
        }

        
        public double PrecoTotal()
        {
            return Preco + Taxa;
        }

        
        public override string PrecoTag()
        {
            return Nome + " - R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " (Taxa: R$" + Taxa + ")";
        }
    }
}
