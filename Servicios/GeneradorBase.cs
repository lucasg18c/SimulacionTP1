using System;

namespace SimulacionTP1.Servicios
{
    public abstract class GeneradorBase
    {

        public double[] Generar(int semilla, int modulo, int a, int c)
        {
            double[] nums = new double[20];
            int xi = semilla;

            for (int i = 0; i < nums.Length; i++)
            {
                xi = Calcular(xi, a, c) % modulo;
                nums[i] = (double) xi / modulo;
            }

            return nums;
        }

        public double GenerarSiguiente(int x, int modulo, int a, int c)
        {
            return (double) (Calcular(x, a, c) % modulo) / modulo;
        }

        public void Validar(int x0, int m, int a, int c)
        {
            if (x0 <= 0) throw new ApplicationException("Valor de semilla inválido");
            if (m <= 0) throw new ApplicationException("Valor de módulo inválido");
            if (a <= 0) throw new ApplicationException("Valor de constante multiplicativa inválido");
            ValidarC(c);
        }

        public string CalcularM(int g)
        {
            return Math.Pow(2, g).ToString();
        }

        //public void CalcularC(double m)
        //{
        //    int count = 0;
        //    for (ulong i2 = 2; i2 <= m; i2++)
        //    {
        //        for (ulong j = 1; j <= i2; j++)
        //        {
        //            if (i2 % j == 0)
        //            {
        //                count++;
        //            }
        //        }
        //        if (count == 2)
        //        {
        //            return i2;
        //        }
                   
        //        count = 0;
                
        //    }
        //}

        protected abstract void ValidarC(int c);
        protected abstract int Calcular(int x, int a, int c);
        public abstract string CalcularA(int k);
    }
}
