using System;
namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe as medidas do triângulo x:");
            Double A = double.Parse(Console.ReadLine());
            Double B = double.Parse(Console.ReadLine());
            Double C = double.Parse(Console.ReadLine());

            Triangulo x = new(A, B, C);

            Console.WriteLine("Informe as medidas do triângulo y:");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            Triangulo y = new(A, B, C);

            Console.WriteLine("Área de x: " + x.calculaArea().ToString("F4"));
            Console.WriteLine("Área de y: " + y.calculaArea().ToString("F4"));

            if (x.calculaArea() > y.calculaArea()) {
                Console.WriteLine("Maior área: x");
            }
            else { 
                Console.WriteLine("Maior área: y");
            }

        }
    }
}
