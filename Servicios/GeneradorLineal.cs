using System;

namespace SimulacionTP1.Servicios
{
    public class GeneradorLineal : GeneradorBase
    {
        protected override ulong Calcular(ulong x, ulong a, ulong c)
        {
            return a * x + c;
        }

        public override string CalcularA(ulong k)
        {
            return (1 + 4 * k).ToString();
        }


        protected override void ValidarC(ulong c)
        {
            if (c <= 0) throw new ApplicationException("Valor de constante aditiva inválido");
        }
    }
}
