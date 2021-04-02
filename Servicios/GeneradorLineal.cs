using System;

namespace SimulacionTP1.Servicios
{
    public class GeneradorLineal : GeneradorBase
    {
        protected override int Calcular(int x, int a, int c)
        {
            return a * x + c;
        }

        public override string CalcularA(int k)
        {
            return (1 + 4 * k).ToString();
        }


        protected override void ValidarC(int c)
        {
            if (c <= 0) throw new ApplicationException("Valor de constante aditiva inválido");
        }
    }
}
