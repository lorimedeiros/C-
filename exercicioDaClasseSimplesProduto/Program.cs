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

            // Podemos ler as propriedades
            Console.WriteLine(p.Nome); // Produto Exemplo
            Console.WriteLine(p.Preco); // 123.45
            Console.WriteLine(p.Quantidade); // 10

            // Não podemos modificar as propriedades diretamente fora da classe
            // p.Nome = "Outro Produto"; // Isso resultará em um erro de compilação
            
            // Por outro lado, se eu for lá no atributo e retirar a palavra "private" de antes do set, eu posso sim alterar o valor dela

        }
    }
}
