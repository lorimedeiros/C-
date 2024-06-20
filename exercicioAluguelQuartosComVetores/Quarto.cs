using System.Numerics;

namespace PrimeiroProjeto
{
    internal class Quarto
    {
        public BigInteger Numero { get; set; }
        public String NomeAlugador { get; set;}
        public String EmailAlugador { get; set;}

        public override string ToString()
        {
            return Numero + ": " + NomeAlugador + ", " + EmailAlugador;
        }
    }
}
