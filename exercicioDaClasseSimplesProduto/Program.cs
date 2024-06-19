using System;
using System.Globalization;
using System.Numerics;
namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe os dados do produto: ");
            Console.WriteLine("Nome:");
            String nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            Double preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque:");
            BigInteger qt = BigInteger.Parse(Console.ReadLine());

            Produto p = new(nome, preco, qt);
            Console.WriteLine(p);

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque:");
            p.AdicionaAoEstoque(int.Parse(Console.ReadLine()));

            Console.WriteLine(p);

            Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
            p.RemoveDoEstoque(int.Parse(Console.ReadLine()));

            Console.WriteLine(p);

        }
    }
}
