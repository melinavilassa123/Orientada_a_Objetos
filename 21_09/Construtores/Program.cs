using System;
using System.Globalization;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados do usuario que serão guardados nas variaveis privadas
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());
            //Instância de objeto p da classe Produto já utilizando as variáveis privadas como parâmetros
            Produto p = new Produto(nome, preco, quantidade);
            //Informações do objeto, ToString
            Console.WriteLine("\nDados do produto \n" + p + "\n\n");
            //Adicionar produtos utilizado
            Console.Write("Digite o valor em estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            //Informações do objeto, ToString
            Console.WriteLine($"\nDados do produto \n" + p + "\n\n");
            //Remover produtos utilizado
            Console.Write("Digite o valor a ser removido: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            //Informações do objeto, ToString
            Console.WriteLine($"\nDados atualizados \n" + p + "\n\n");
            Console.ReadKey();
        }
    }
}