namespace SimulacionTP1.Servicios
{
    public class GeneradorMultiplicativo : GeneradorBase
    {
        protected override int Calcular(int x, int a, int c)
        {
            return a * x;
        }

        public override string CalcularA(int k)
        {
            return (3 + 8 * k).ToString();
        }

        protected override void ValidarC(int c)
        {
            
        }
    }
}
