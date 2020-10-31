using System;
using System.Globalization;

namespace Produto
{
	public class Produto
	{
		public string Nome;
		public double Preco;
		public int Quantidade;
		public Produto (string nome, double preco, int quantidade)
		{
			Nome = nome;
			Preco = preco;
			Quantidade = quantidade;
		}
		//Calcular o valor total
		public double ValorTotalEstoque()
		{
			double total = Quantidade * Preco;
			return total;
		}
		//Modificar a quantidade de produtos
		public void AdicionarProdutos(int qnt)
		{
			Quantidade += qnt;
		}
		public void RemoverProdutos(int qnt)
		{
			Quantidade -= qnt;
		}
		//Método ToString pra ter uma formatação melhor quando precisar mostrar a informação do produto
		public override string ToString()
		{
			return "Nome: " + Nome + "\n"
				+ "Preço: R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + "\n"
				+ Quantidade + " Em estoque\n"
				+ "Valor total: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}