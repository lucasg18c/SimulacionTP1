namespace SimulacionTP1.Servicios
{
    public class GeneradorMultiplicativo : GeneradorBase
    {
        protected override int Calcular(int x, int a, int c)
        {
            return a * x;
        }

        protected override void ValidarC(int c)
        {
            
        }
    }
}
