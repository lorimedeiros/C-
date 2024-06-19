using System;
using System.Globalization;
using System.Numerics;

public class Produto
{
    public string Nome { get; private set; }
    public double Preco { get; private set; }
    public BigInteger Quantidade { get; private set; }

    public Produto(string nome, double preco, BigInteger quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public void AdicionaAoEstoque(int quantidade)
    {
        Quantidade += quantidade;
    }

    public void RemoveDoEstoque(int quantidade)
    {
        if (quantidade > Quantidade)
        {
            throw new ArgumentException("Quantidade a remover é maior que a quantidade em estoque");
        }
        Quantidade -= quantidade;
    }

    public Double ValorTotalEmEstoque() {
        return Preco * (Double)Quantidade;
    }

    public override string ToString()
    {
        return $"Dados do produto: {Nome}, " +
            $"$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
            $"{Quantidade} unidades, Total: $ " + 
            ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}
