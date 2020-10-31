using System;
using System.Globalization;

namespace Altura
{
    class Program
    {
        static void Main(string[] args)
        {
            //O Usuario define o numero e pessoas
            Console.Write("Digite um número de pessoas: ");
            int n = int.Parse(Console.ReadLine());
            //Array double, tamanho [n]
            double[] vect = new double[n];
            //For com variável inicial de i = 0, entra com a informação do usuário, e coloca no [i]
            for (int i = 0; i < n; i++)
            {
                Console.Write("Altura (" + (i + 1) + "): ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            //Soamr os valores
            double sum = 0.00;
            //For soma os valores colocados no array e atualiza no sum
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }
            //Cálculo da média de altura, soma dividida pelo tamanho do array
            Console.WriteLine("A média de altura das pessoas é = " + (sum / vect.Length).ToString("F2", CultureInfo.InvariantCulture));
            //Não deixa o programa fechar automaticamente
            Console.ReadKey();
        }
    }
}
