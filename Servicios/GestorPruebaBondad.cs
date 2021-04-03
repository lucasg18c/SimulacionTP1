using SimulacionTP1.Modelo.PruebasBondad;
using SimulacionTP1.Presentacion;
using System;

namespace SimulacionTP1.Servicios
{
    public class GestorPruebaBondad
    {
        private readonly IFrmPruebaBondad form;
        private PruebaBondad pruebaBondad;

        public GestorPruebaBondad(IFrmPruebaBondad form)
        {
          this.form = form;
        }

        public void Generar()
        {
            try
            {
                int cantidadNumeros, cantidadIntervalos;
                double[] serie;

                cantidadNumeros = form.GetCantidadNumeros();
                cantidadIntervalos = form.GetCantidadIntervalos();

                Validar(cantidadNumeros, cantidadIntervalos);
                serie = GenerarSerieAleatoria(cantidadNumeros);

                pruebaBondad = InstanciarPruebaBondad();
                pruebaBondad.Calcular(serie, cantidadIntervalos);

                form.MostrarSerieAleatoria(MostrarSerie(serie));
                
                form.MostrarHistograma(
                    pruebaBondad.GetFrecuenciasObservadas(),
                    pruebaBondad.GetFrecuenciaEsperada()
                );

                form.MostrarProcedimiento(pruebaBondad.GetProcedimiento());
                form.MostrarInformacion(pruebaBondad.GetConclusion(), "RESULTADO DE LA HIPOTESIS");
            }
            catch(Exception e)
            {
                form.MostrarError(e.Message);
            }
        }

        private PruebaBondad InstanciarPruebaBondad()
        {
            if (typeof(FrmJiCuadrado).IsInstanceOfType(form))
                return new PruebaJiCuadrado();

            else
                return new PruebaKS();
        }

        private string[] MostrarSerie(double[] serie)
        {
            int n = serie.Length;
            string[] serieString = new string[n];

            for (int i = 0; i < n; i++)
                serieString[i] = Math.Round(serie[i], 4).ToString();

            return serieString;
        }

        private double[] GenerarSerieAleatoria(int cantidadNumeros)
        {
            double[] num = new double[cantidadNumeros];
            Random r = new Random();
            
            for (int i = 0; i < cantidadNumeros; i++)
                num[i] = r.NextDouble();
            
            return num;
        }

        private void Validar(int numeros, int intervalos)
        {
            if (numeros <= 0)
                throw new ApplicationException("La cantidad de números a generar es inválida.");

            if (intervalos <= 1 || intervalos >= 110)
                throw new ApplicationException("La cantidad de intervalos es inválida.");
        }
    }
}
