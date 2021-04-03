namespace SimulacionTP1.Modelo
{
    public class ConteoFrecuencia
    {
        private readonly double intervalo;
        private readonly int conteo;

        public ConteoFrecuencia(double intervalo, int conteo)
        {
            this.intervalo = intervalo;
            this.conteo = conteo;
        }

        public double GetIntervalo()
        {
            return intervalo;
        }

        public int GetConteo()
        {
            return conteo;
        }
    }
}
