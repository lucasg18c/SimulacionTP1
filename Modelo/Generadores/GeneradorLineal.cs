using System;

namespace SimulacionTP1.Servicios
{
    public class GeneradorLineal : GeneradorBase
    {
        protected override int Calcular(int x, int a, int c)
        {
            return a * x + c;
        }

        public override int CalcularA(int k)
        {
            return 1 + 4 * k;
        }

        public override bool NecesitaC()
        {
            return true;
        }

        public override bool UsaSemillaImpar()
        {
            return false;
        }
    }
}
