using System;
using System.Globalization; //isso é pra usar na linha 62

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool afirmacao = true;
            char verdadeOuNem = 'V';
            char letraEmUnicode = '\u0041'; //isso aqui é um A em código unicode
            byte limiteDeUmByte = 255;
            long olhaComoQueFazComLong = 51484L; //sim, tem que botal o L no fim
            float f = 4.50f; //sim, tem que bota um f no fim
            double d = 4.50; //e sim, o 0 no fim vai ser "comido" nos prints de ambos os casos
            String nome = "Takokalo Nopé";

            Console.WriteLine(afirmacao);
            Console.WriteLine(verdadeOuNem);
            Console.WriteLine(letraEmUnicode);
            Console.WriteLine(limiteDeUmByte);
            Console.WriteLine(olhaComoQueFazComLong);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(nome);

            //vamo se divertir testando coisa de String
            Console.WriteLine();

            Console.WriteLine(nome.Length); //conta começando do 1

            Console.WriteLine(nome.First()); //pega o primeiro char

            Console.WriteLine(nome.Last()); //pega o ultimo char

            Console.WriteLine(nome.Contains('A'));
            Console.WriteLine(nome.Contains('a'));

            Console.WriteLine();

            String x = "Hello";
            String y = "mizera";

            String z = x + " " + y; //concatenação

            Console.WriteLine(z);

            Console.WriteLine();

            int maxInt = int.MaxValue; //função para mostrar valor maximo da propia classe
            int minInt = int.MinValue;
            Console.WriteLine(maxInt);
            Console.WriteLine(minInt);

            //controlando casas decimais de um double
            Console.WriteLine();
            double doubls = 5.24589;

            Console.WriteLine(doubls.ToString("F2")); //duas casas decimais após vírgula
            Console.WriteLine(doubls.ToString("F1")); //uma casa após a vírgula e ainda vai arredondar o valor
            Console.WriteLine(doubls.ToString("F4", CultureInfo.InvariantCulture)); //essa gambiarra é pra imprimir ponto ao invés de vírgula como separador decimal

            //regra básica: 0-4 não arredonda, 5-9 arredonda

            Console.WriteLine();

            Console.Write("Lança a braba ai: ");
            int numero = Convert.ToInt32(Console.ReadLine()); //sim, tem que converter, tentei botar no seco e o numero 3 virou um 58

            Console.WriteLine("braba lançada é " + numero);

            //PlaceHolder 
            Console.WriteLine("{0} tem {1} brabas e R${2:F2} na nubank", nome, numero, doubls);

            //Interpolação
            Console.WriteLine($"{nome} tem {numero} brabas e R${doubls:F2} na nubank");

            //concatenação
            Console.WriteLine(nome + " tem " + numero + " brabas e R$" + doubls.ToString("F2") + " na nubamk");
        }
    }
}
