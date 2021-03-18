using System;

namespace SimulacionTP1.Servicios
{
    public class GeneradorLineal : GeneradorBase
    {
        protected override int Calcular(int x, int a, int c)
        {
            return a * x + c;
        }

        protected override void ValidarC(int c)
        {
            if (c <= 0) throw new ApplicationException("Valor de constante aditiva inválido");
        }
    }
}
