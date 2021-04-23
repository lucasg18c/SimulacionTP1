using System;

namespace SimulacionTP1.Modelo.PruebasBondad
{
    public class PruebaKS : PruebaBondad
    {
        private static readonly double[] valCriticos = { 
            0.9750, 0.8418, 0.7076, 0.6239, 0.5632, 0.5192, 0.4834, 0.4542, 0.4300, 
            0.4092, 0.3912, 0.3754, 0.3614, 0.3489 , 0.3375, 0.3273, 0.3179, 0.3093, 
            0.3014, 0.2940, 0.2872, 0.2808, 0.2749, 0.2693, 0.2640, 0.2590, 0.2543, 
            0.2499, 0.2457, 0.2417, 0.2378, 0.2342, 0.2307, 0.2274, 0.2242
        };

        public override string GetNombre()
        {
            return "Kolmogorov Smirnov";
        }

        protected override double[] CalcularFila(int iteracion, double[] previa)
        {
            double[] fila = new double[10];
            double frecuenciaEsperada, probabilidadEsperada, observadaAC, esperadaAC, mayor;

            if (previa != null)
            {
                fila[0] = previa[1];                        // desde
                frecuenciaEsperada = previa[3];
                probabilidadEsperada = previa[5];
                observadaAC = previa[6];
                esperadaAC = previa[7];
                mayor = previa[9];
            }
            else
            {
                fila[0] = 0;
                frecuenciaEsperada = GetFrecuenciaEsperada();
                probabilidadEsperada = 1d / GetCantidadIntervalos();
                observadaAC = 0;
                esperadaAC = 0;
                mayor = 0;
            }

            fila[1] = fila[0] + GetTamanioIntervalo();      // hasta
            fila[2] = GetConteo()[iteracion];               // frecuencia observada
            fila[3] = frecuenciaEsperada;                   // frecuencia esperada
            fila[4] = fila[2] / GetTamanioSerie();          // probabilidad observada
            fila[5] = probabilidadEsperada;                 // probabilidad esperada
            fila[6] = observadaAC + fila[4];                // p observada acumulada
            fila[7] = esperadaAC + fila[5];                 // p esperada acumulada
            fila[8] = Math.Abs(fila[6] - fila[7]);          // | PoAC - PeAC |
            fila[9] = fila[8] > mayor ? fila[8] : mayor;    // mayor | PoAC - PeAC |

            return fila;
        }

        protected override double CalcularValorCritico()
        {
            int n = GetTamanioSerie();

            if (n > 35)
                return Math.Round(1.36 / Math.Sqrt(n), 4);

            return valCriticos[n - 1];  
        }

        public override string[] GetColumnasProcedimiento()
        {
            return new string[]
            {
                "Desde",
                "Hasta",
                "Fo",
                "Fe",
                "Po",
                "Pe",
                "PoAc",
                "PeAc",
                "|PeAc - PoAc|",
                "max |PeAc - PoAc|",
            };
        }
    }
}
