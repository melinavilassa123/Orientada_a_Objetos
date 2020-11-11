using System;
using System.Collections.Generic;

namespace ExemploListas
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<string> list = new List<string>();
            
            list.Add("Fábio"); 
            list.Add("Wilson"); 
            list.Add("Angelina"); 
            list.Add("Eliney"); 
            list.Add("Andre");
            
            list.Insert(2, "Lucas");
            
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("Quantidade de elementos na lista: " + list.Count);
            
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);
            
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último elemento que começa com a letra A: " + s2);
            
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição de A: " + pos1);
            
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Última posição de A: " + pos2);
            
            List<string> list2 = list.FindAll(x => x.Length == 5);
            
            Console.WriteLine("----------------------------");
            
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            
            list.Remove("Andre");
            
            Console.WriteLine("=============================");
            
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            
            list.RemoveAll(x => x[0] == 'W');
            
            Console.WriteLine("+++++++++++++++++++++++++++");
            
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            
            list.RemoveAt(3);
            
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxx");
            
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            
            list.RemoveRange(1, 2);
            
            Console.WriteLine(".......................");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
