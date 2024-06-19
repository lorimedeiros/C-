namespace PrimeiroProjeto
{
    internal class Triangulo
    {
        private Double A;
        private Double B;
        private Double C;

        public Triangulo() { }

        public Triangulo(Double A, Double B, Double C) {
            this.A = A; 
            this.B = B; 
            this.C = C;
        }

        public void setA(Double A) 
        {
            this.A = A;
        }

        public void setB(Double B)
        {
            this.B = B;
        }

        public void setC(Double C)
        {
            this.C = C;
        }

        public Double calculaArea() 
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
