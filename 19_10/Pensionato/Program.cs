using System;

namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quantidade de quartos utlizados
            Console.Write("Quantos quartos estão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Quarto[] vect = new Quarto[10];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nHóspede #" + (i+1) + ";");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int q = int.Parse(Console.ReadLine());
                vect[q] = new Quarto { Nome = nome, Email = email };
            }
            //Quartos que estão ocupados
            Console.WriteLine("\nOcupados");
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine((i) + ": " + vect[i].Nome + ", " + vect[i].Email);
                }
            }
        }
    }
}
