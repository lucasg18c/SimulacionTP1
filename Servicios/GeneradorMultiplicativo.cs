namespace SimulacionTP1.Servicios
{
    public class GeneradorMultiplicativo : GeneradorBase
    {
        protected override ulong Calcular(ulong x, ulong a, ulong c)
        {
            return a * x;
        }

        public override string CalcularA(ulong k)
        {
            return (3 + 8 * k).ToString();
        }

        protected override void ValidarC(ulong c)
        {
            
        }
    }
}
