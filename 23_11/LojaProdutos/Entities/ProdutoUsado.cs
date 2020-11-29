using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LojaProdutos.Entities
{
    class ProdutoUsado : Produto
    {
        
        public DateTime Fabricacao { get; private set; }

        
        public ProdutoUsado() { }

        
        public ProdutoUsado(string nome, double preco, DateTime fabricacao) : base(nome, preco)
        {
            Fabricacao = fabricacao;
        }

        
        public override string PrecoTag()
        {
            return Nome + " (usado) - R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " (Fabricado: " + Fabricacao.ToString("dd/MM/yy") + ")";
        }
    }
}
