﻿using System;

namespace SimulacionTP1.Servicios
{
    public abstract class GeneradorBase
    {

        public double[] Generar(ulong semilla, ulong modulo, ulong a, ulong c)
        {
            double[] nums = new double[20];
            ulong xi = semilla;

            for (int i = 0; i < nums.Length; i++)
            {
                xi = Calcular(xi, a, c) % modulo;
                nums[i] = (double) xi / modulo;
            }

            return nums;
        }

        public double GenerarSiguiente(ulong x, ulong modulo, ulong a, ulong c)
        {
            return (double) (Calcular(x, a, c) % modulo) / modulo;
        }

        public void Validar(ulong x0, ulong m, ulong a, ulong c)
        {
            if (x0 <= 0) throw new ApplicationException("Valor de semilla inválido");
            if (m <= 0) throw new ApplicationException("Valor de módulo inválido");
            if (a <= 0) throw new ApplicationException("Valor de constante multiplicativa inválido");
            ValidarC(c);
        }

        public string CalcularM(ulong g)
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

        protected abstract void ValidarC(ulong c);
        protected abstract ulong Calcular(ulong x, ulong a, ulong c);
        public abstract string CalcularA(ulong k);
    }
}