using System;
using System.Globalization;
namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String produto1 = "Computador";
            String produto2 = "Mesa de escritório";

            byte idade = 20;
            int codigo = 0000; //atenção no uso do ":D4" na ln25, pois os 0 a esquerda são cortados, o print seria apenas 0, mas com esse detalhe consigo todos os 0's
            char pfOrpj = 'F';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"Produtos:\n{produto1}, cujo preço é $ {preco1:F2}\n{produto2}, cujo preço é $ {preco2:F2}");

            Console.WriteLine();

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo:D4} e pessoa: {pfOrpj}");

            Console.WriteLine();

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}\nArredondado (três casas decimais): {medida:F3}\nSeparador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
