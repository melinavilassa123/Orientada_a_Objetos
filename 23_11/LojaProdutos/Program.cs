using LojaProdutos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace LojaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Número de produtos: ");
            int n = int.Parse(Console.ReadLine());           
            List<Produto> lista = new List<Produto>();
           
            for (int i = 0; i < n; i++)
            {               
                Console.WriteLine("\nPRODUTO #" + (i + 1));
                Console.Write("Comum, Usado ou Importado (C/U/I)? ");
                string tipoProduto = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               
                switch (tipoProduto)
                {                   
                    case "C":
                        lista.Insert(i, new Produto(nome, preco));
                        break;
                   
                    case "U":
                        Console.Write("Fabricado (DD/MM/AA): ");
                        DateTime fabricacao = DateTime.Parse(Console.ReadLine());

                        lista.Insert(i, new ProdutoUsado(nome, preco, fabricacao));
                        break;
                   
                    case "I":
                        Console.Write("Taxa: ");
                        double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        lista.Insert(i, new ProdutoImportado(nome, preco, taxa));
                        break;
                }
            }           
            Console.WriteLine("\nEtiquetas: ");
            foreach(Produto prod in lista)
            {
                Console.WriteLine(prod.PrecoTag());
            }
            Console.ReadKey();
        }
    }
}
