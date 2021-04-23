using SimulacionTP1.Modelo;
using SimulacionTP1.Modelo.PruebasBondad;
using SimulacionTP1.Presentacion;
using System;
using System.Windows.Forms;

namespace SimulacionTP1.Servicios
{
    public class GestorPruebaBondad
    {
        private readonly FrmPruebaBondad form;
        private PruebaBondad pruebaBondad;
        private double[] serie;

        public GestorPruebaBondad(FrmPruebaBondad form, FrmPruebaBondad.Pruebas prueba)
        {
            this.form = form;
            ElegirPruebaBondad(prueba);
            form.SetTitulo(pruebaBondad.GetNombre());
            form.SetColumnasTabla(pruebaBondad.GetColumnasProcedimiento());
        }

        private void ElegirPruebaBondad(FrmPruebaBondad.Pruebas prueba)
        {
            if (prueba == FrmPruebaBondad.Pruebas.ChiCuadrado)
                pruebaBondad = new PruebaChiCuadrado();
            else
                pruebaBondad = new PruebaKS();
        }

        public void Generar()
        {
            try
            {
                int cantidadNumeros, cantidadIntervalos;

                form.Esperar(true);

                cantidadNumeros = form.GetCantidadNumeros();
                cantidadIntervalos = form.GetIntervalos();
                Validar(cantidadNumeros, cantidadIntervalos);

                serie = GenerarSerieAleatoria(cantidadNumeros);

                pruebaBondad.Calcular(serie, cantidadIntervalos);

                form.MostrarSerieAleatoria(MostrarSerie());

                MostrarHistograma();

                form.MostrarProcedimiento(pruebaBondad.GetProcedimiento());
                form.SetValoresResultado(pruebaBondad.GetValoresResultado());

                form.ResultadoExitoso(pruebaBondad.ResultadoPositivo());

                form.HabilitarExportar(true);
            }
            catch(Exception e)
            {
                form.MostrarError(e.Message);
                form.HabilitarExportar(false);
            }
            finally
            {
                form.Esperar(false);
            }
        }

        private void MostrarHistograma()
        {
            ConteoFrecuencia[] conteo = pruebaBondad.GetFrecuenciasObservadas();
            double frecuenciaEsperada = pruebaBondad.GetFrecuenciaEsperada();

            form.LimpiarHistograma();
            
            foreach (ConteoFrecuencia fo in conteo)
                form.MostrarHistograma(Math.Round(fo.Desde, 4), fo.Cantidad, frecuenciaEsperada); 
        }

        private string MostrarSerie()
        {
            string serieString = "";

            foreach (double d in serie)
                serieString += $"{Math.Round(d, 4)}\t";
            
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

        public void Exportar()
        {
            string serieString = "";

            foreach (double d in serie)
                serieString += $"{Math.Round(d, 4)}\n";

            form.CopiarPortapapeles(serieString);
        }
    }
}
