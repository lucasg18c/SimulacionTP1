using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTP1.Modelo
{
    public class ConteoFrecuencia
    {
        private double intervalo;
        private int conteo;

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
