using Formas_MetodosAbstratos.Entities;
using Formas_MetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Formas_MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {           
            List<Forma> list = new List<Forma>();          
            Console.Write("Número de formas: ");
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= n; i++)
            {               
                Console.WriteLine($"\nForma #{i}: ");
                Console.Write("Retângulo ou Círculo (R/C)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor (Preto/Azul/Vermelho): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
               
                if (ch == 'R')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                    
                    list.Add(new Retangulo(largura, altura, color));
                }               
                else if (ch == 'C')
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                   
                    list.Add(new Circulo(raio, color));
                }
            }           
            Console.WriteLine();
            Console.WriteLine("Área de cada forma: ");
            
            foreach(Forma forma in list)
            {
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
