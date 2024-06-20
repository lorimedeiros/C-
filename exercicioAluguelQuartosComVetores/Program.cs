using System;
using System.Globalization;
using System.Numerics;
namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Quarto[] vect = new Quarto[9];

            Console.WriteLine("Quantos quartos serão alugados?");
            int nAlugados = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            for (int i = 0; i < nAlugados; i++)
            {
                Console.WriteLine("Aluguel do quarto #" + (i + 1) + ":");
                Console.WriteLine("Nome:");
                String nome = Console.ReadLine();
                Console.WriteLine("Email:");
                String email = Console.ReadLine();
                Console.WriteLine("Quarto:");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vect[numero] = new Quarto { Numero = numero, NomeAlugador = nome, EmailAlugador = email };
            }


            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < vect.Length;i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i].ToString());
                }
            }

        }
    }
}
