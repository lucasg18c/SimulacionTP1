using SimulacionTP1.Modelo.PruebasBondad;
using SimulacionTP1.Presentacion;
using System;

namespace SimulacionTP1.Servicios
{
    public class GestorJiCuadrado
    {
        private readonly FrmJiCuadrado form;
        private PruebaBondad pruebaBondad;

        public GestorJiCuadrado(FrmJiCuadrado form)
        {
          this.form = form;
        }

        public void Generar()
        {
            try
            {
                long cantidadNumeros, cantidadIntervalos;
                double[] serie;

                cantidadNumeros = form.GetCantidadNumeros();
                cantidadIntervalos = form.GetCantidadIntervalos();

                Validar(cantidadNumeros, cantidadIntervalos);
                serie = GenerarSerieAleatoria(cantidadNumeros);

                pruebaBondad = new PruebaJiCuadrado();
                pruebaBondad.Calcular(serie, (int)cantidadIntervalos);

                form.PrepararHistograma();
                form.MostrarGrilla(MostrarSerie(serie));

                form.MostrarHistograma(
                    pruebaBondad.GetFrecuenciasObservadas(),
                    pruebaBondad.GetFrecuenciasEsperadas()
                );

                form.MostrarProcedimiento(pruebaBondad.GetProcedimiento());
                form.MostrarInformacion(pruebaBondad.GetConclusion(), "Resultado");
            }
            catch(Exception e)
            {
                form.MostrarError(e.Message);
            }
        }

        private string[] MostrarSerie(double[] serie)
        {
            int n = serie.Length;
            string[] serieString = new string[n];

            for (int i = 0; i < n; i++)
                serieString[i] = Math.Round(serie[i], 4).ToString();

            return serieString;
        }

        private double[] GenerarSerieAleatoria(long cantidadNumeros)
        {
            double[] num = new double[cantidadNumeros];
            Random ran = new Random();
            
            for (int i = 0; i < num.Length; i++)
                num[i] = ran.NextDouble();
            
            return num;
        }

        private void Validar(long numeros, long intervalos)
        {
            if (numeros <= 0)
                throw new ApplicationException("La cantidad de números a generar es inválida.");

            if (intervalos <= 0 || intervalos >= 110)
                throw new ApplicationException("La cantidad de intervalos es inválida.");
        }
    }
}
