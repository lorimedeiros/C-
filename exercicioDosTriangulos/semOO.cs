using System;
namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double xA, xB, xC, yA, yB, yC;
            
            Console.WriteLine("Informe as medidas do triângulo x:");
            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe as medidas do triângulo y:");
            yA = double.Parse(Console.ReadLine());
            yB = double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());

            double p = (xA + xB + xC) / 2.0;
            double areax = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areay = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de x: " + areax.ToString("F4"));
            Console.WriteLine("Área de y: " + areay.ToString("F4"));

            if (areax > areay) {
                Console.WriteLine("Maior área: x");
            }
            else { 
                Console.WriteLine("Maior área: y");
            }

        }
    }
}
