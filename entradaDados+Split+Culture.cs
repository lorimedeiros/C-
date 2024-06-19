using System;
using System.Globalization; //essa belezura é para poder fazer conversão da , para o .
namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe seu nome e sobrenome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe seu último nome, idade e altura (mesma linha):");
            string[] vect = Console.ReadLine().Split(' ');
            
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.WriteLine(vect[0]);
            Console.WriteLine(vect[1]);
            double altura = double.Parse(vect[2], CultureInfo.InvariantCulture);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
}
