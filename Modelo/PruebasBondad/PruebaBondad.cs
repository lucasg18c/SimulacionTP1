using System;

namespace SimulacionTP1.Modelo.PruebasBondad
{
    public abstract class PruebaBondad
    {
        private double[] serie;
        private int cantidadIntervalos;
        private int[] conteos;
        private double[][] procedimiento;
        private double valorCritico;
        private string conclusion;

        private static readonly int DECIMALES_REDONDEO = 4;

        protected abstract double[] CalcularFila(int iteracion, double[] previa);

        protected abstract double CalcularValorCritico();

        public void Calcular(double[] serie, int cantidadIntervalos)
        {
            this.serie = serie;
            this.cantidadIntervalos = cantidadIntervalos;

            ConteoFrecuencias();
            CalcularEstadisticoPrueba();
            valorCritico = CalcularValorCritico();
            EvaluarHipotesisNula();
        }

        protected int GetCantidadIntervalos()
        {
            return cantidadIntervalos;
        }

        protected double GetTamanioIntervalo()
        {
            return 1d / cantidadIntervalos;
        }

        private void EvaluarHipotesisNula()
        {
            double estadisticoPrueba, valorCritico;

            estadisticoPrueba = GetEstadisticoPrueba();
            valorCritico = GetValorCritico();

            if (estadisticoPrueba <= valorCritico)
                conclusion =
                    $"Valor Critico = {valorCritico}" +
                    $"\nEstadisitico de prueba = {estadisticoPrueba}" + 
                    "\nLa hipotesis nula  NO SE PUEDE RECHAZAR, con un nivel de significancia del 0.05";
            else
                conclusion =
                    $"Valor Critico = {valorCritico}" +
                    $"\nEstadisitico de prueba = {estadisticoPrueba}" +
                    "\nLa hipotesis nula  SE PUEDE RECHAZAR, con un nivel de significancia del 0.05";
        }

        protected int GetTamanioSerie()
        {
            return serie.Length;
        }

        public int GetFrecuenciaEsperada()
        {
            if (serie.Length < cantidadIntervalos) return 1;
            return serie.Length / cantidadIntervalos;
        }

        public ConteoFrecuencia[] GetFrecuenciasObservadas()
        {
            ConteoFrecuencia[] conteoFrecuencias = new ConteoFrecuencia[cantidadIntervalos];

            for (int i = 0; i < cantidadIntervalos; i++)
                conteoFrecuencias[i] = new ConteoFrecuencia(
                    (double)i / cantidadIntervalos, 
                    conteos[i]
                    );

            return conteoFrecuencias;
        }

        public int[] GetConteo()
        {
            return conteos;
        }

        public string[][] GetProcedimiento()
        {
            string[][] proc = new string[cantidadIntervalos][];
            string[] fila;
            int cantidadColumnas = procedimiento[0].Length;

            for (int i = 0; i < cantidadIntervalos; i++)
            {
                fila = new string[cantidadColumnas];

                for (int j = 0; j < cantidadColumnas; j++)
                    fila[j] = procedimiento[i][j].ToString();
                
                proc[i] = fila;
            }
            return proc;
        }

        public string GetConclusion()
        {
            return conclusion;
        }

        private double GetValorCritico()
        {
            return valorCritico;
        }

        private double GetEstadisticoPrueba()
        {
            int columnas = procedimiento[0].Length;
            return procedimiento[cantidadIntervalos - 1][columnas - 1];
        }

        private void CalcularEstadisticoPrueba()
        {
            procedimiento = new double[cantidadIntervalos][];
            procedimiento[0] = CalcularFila(0, null);
            Redondear(procedimiento[0]);

            for (int i = 1; i < cantidadIntervalos; i++)
            {
                procedimiento[i] = CalcularFila(i, procedimiento[i - 1]);
                Redondear(procedimiento[i]);
            }
        }

        private void Redondear(double[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
                lista[i] = Math.Round(lista[i], DECIMALES_REDONDEO);            
        }

        private void ConteoFrecuencias()
        {
            int indiceIntervalo;
            conteos = new int[cantidadIntervalos];

            foreach (double numero in serie)
            {
                indiceIntervalo = (int) (numero * cantidadIntervalos);
                conteos[indiceIntervalo]++;
            }
        }
    }
}
