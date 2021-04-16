using System;

namespace SimulacionTP1.Modelo.PruebasBondad
{
    public class PruebaChiCuadrado : PruebaBondad
    {
        private static readonly double[] valoresCriticos = { 
            3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 19.7, 
            21.0, 22.4, 23.7 , 25.0, 26.3, 27.6, 28.9, 30.1, 31.4, 32.7, 33.9, 
            35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8
        };

        private static readonly double[] valoresCriticosGrandes = {
            0, 0, 0, 43.8, 55.8, 67.5, 79.1, 90.5, 101.9, 113.1, 124.3
        };

        protected override double[] CalcularFila(int iteracion, double[] previa)
        {
            double[] fila = new double[6];
            double frecuenciaEsperada, frecuenciaObservada, acumulada;

            if (previa != null)
            {
                fila[0] = previa[1];
                frecuenciaEsperada = previa[3];
                acumulada = previa[5];
            }
            else
            {
                fila[0] = 0;
                frecuenciaEsperada = GetFrecuenciaEsperada();
                acumulada = 0;
            }

            frecuenciaObservada = GetConteo()[iteracion];

            fila[1] = fila[0] + GetTamanioIntervalo();
            fila[2] = frecuenciaObservada;
            fila[3] = frecuenciaEsperada;
            fila[4] = CalcularC(frecuenciaObservada, frecuenciaEsperada);
            fila[5] = acumulada + fila[4];

            return fila;
        }

        private double CalcularC(double frecuenciaObservada, double frecuenciaEsperada)
        {
            return Math.Pow(frecuenciaEsperada - frecuenciaObservada, 2) / frecuenciaEsperada;
        }

        protected override double CalcularValorCritico()
        {
            int gradosLibertad = GetCantidadIntervalos() - 1;

            if (gradosLibertad <= 30)
                return valoresCriticos[gradosLibertad - 1];

            gradosLibertad /= 10;
            return valoresCriticosGrandes[gradosLibertad];
        }

        public override string GetNombre()
        {
            return "Chi Cuadrado";
        }

        public override string[] GetColumnasProcedimiento()
        {
            return new string[]
            {
                "Desde",
                "Hasta",
                "F. Observadas",
                "F. Esperadas",
                "C",
                "C Acumulado"
            };
        }
    }
}
