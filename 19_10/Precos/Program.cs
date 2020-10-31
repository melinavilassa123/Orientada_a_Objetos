using System;
using System.Globalization;

namespace Precos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usuario define a quantidade de produtos
            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            //Array, classe Produto com tamanho [n]
            Produto[] vect = new Produto[n];
            //For com variável inicial de i = 0, entra com a informação do usuário, e cria um novo Produto no [i] do array, com o nome e preço digitados
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nNome do produto " + (i + 1) + ": ");
                string name = Console.ReadLine();

                Console.Write("Preço do produto " + (i + 1) + ": ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produto { Name = name, Price = price };
            }
            //variável double somando os valores
            double sum = 0.00;
            //For soma os valores de Price colocados no array e atualiza no sum
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            //Cálculo da média de altura, soma dividida pelo tamanho do array
            Console.WriteLine("\nA média de preço dos produtos é: " + (sum / vect.Length).ToString("F2", CultureInfo.InvariantCulture));
            //Não deixa o programa fechar automaticamente
            Console.ReadKey();
        }
    }
}
