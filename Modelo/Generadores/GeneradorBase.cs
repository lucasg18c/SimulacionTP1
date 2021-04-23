using System;

namespace SimulacionTP1.Servicios
{
    public abstract class GeneradorBase
    {
        private int semilla;
        private decimal random;
        private static readonly int DECIMALES_REDONDEO = 4;

        public void Generar(int semilla, double modulo, int a, int c)
        {
            this.semilla = (int) (Calcular(semilla, a, c) % modulo);
            random = (decimal) (this.semilla / modulo);            
        }

        public void Validar(int x, double m, int a, int c, int k, int g)
        {
            if (x <= 0) 
                throw new ApplicationException("El valor de la semilla es inválido");

            if (m <= 0 && g <= 0) 
                throw new ApplicationException("Debe ingresar un valor válido de M ó G");

            if (a <= 0 && k <= 0) 
                throw new ApplicationException("Debe ingresar un valor válido de A ó K");

            ValidarC(c);
        }

        public int CalcularM(int g)
        {
            return (int) Math.Pow(2, g);
        }

        public int GetSiguienteSemilla()
        {
            return semilla;
        }

        public double GetRandom()
        {
            return Math.Abs((double) Math.Round(random, DECIMALES_REDONDEO));
        }

        protected abstract void ValidarC(int c);
        protected abstract int Calcular(int x, int a, int c);
        public abstract int CalcularA(int k);
    }
}
