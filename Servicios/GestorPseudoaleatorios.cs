using SimulacionTP1.Presentacion;
using System;
using System.Collections.Generic;

namespace SimulacionTP1.Servicios
{
    public class GestorPseudoaleatorios
    {
        private readonly FrmNumerosAleatorios form;
        private GeneradorBase generador;
        private int x, xIngresado, a, c, k, g, m;
        private bool datosModificados = true;
        private List<double> serie;

        private static readonly int CANTIDAD_GENERACION = 20;

        public GestorPseudoaleatorios(FrmNumerosAleatorios form)
        {
            this.form = form;
            generador = new GeneradorLineal();
        }

        public void CambiarGenerador()
        {
            if (typeof(GeneradorLineal).IsInstanceOfType(generador))
                generador = new GeneradorMultiplicativo();
            else
                generador = new GeneradorLineal();

            datosModificados = true;
        }

        public void Generar()
        {
            try
            {
                form.Esperar(true);
                GetDatos();

                if (datosModificados)
                {
                    datosModificados = false;

                    generador.Validar(x, m, a, k, g);
                    UsarBuenasPracticas();
                    form.LimpiarTabla();
                    serie = new List<double>();
                    GenerarYMostrar(CANTIDAD_GENERACION);
                }

                else
                {
                    GenerarYMostrar(1);
                    form.IrAlUltimo();
                }
                form.HabilitarExportar(true);
            }
            catch (Exception e)
            {
                form.MostrarError(e.Message);
                form.HabilitarExportar(false);
            }
            finally
            {
                form.Esperar(false);
            }
        }

        private void CalcularCPrimo()
        {
            int a, b, res;

            c = 1;
            if (m == 1)
            {
                form.SetC(c);
                return;
            }
            

            for (int i = m - 1; i > 0; i--)
            {
                a = m;
                b = i;

                do
                {
                    res = a % b;
                    a = b;
                    b = res;
                }
                while (b != 0);

                if (a == 1)
                {
                    c = i;
                    break;
                }
            }

            form.SetC(c);
        }

        public void VerificarPrimaje()
        {
            int a = Math.Max(c, m);
            int b = Math.Min(c, m);
            int res;
            do
            {
                res = b;    // guardamos el divisor en el resultado
                b = a % b;  // Guardamos el resto en el divisor
                a = res;    // El divisor pasa a dividendo
            } 
            while (b != 0);
           
            if (res != 1 || c == 1)
                
                if (form.Preguntar("Desea calcular un valor de \"c\" relativamente primo a \"m\"?"))
                    CalcularCPrimo();
        }

        public void UsarBuenasPracticas()
        {
            if (generador.UsaSemillaImpar() && xIngresado % 2 == 0)
                if (form.Preguntar("Desea usar una semilla recomendada?"))
                {
                    x++;
                    form.SetX(x);
                }
            
            if (k != 0)
            {
                if (a == 0)
                    CalcularA();

                else
                {
                    if (form.Preguntar("Desea un valor de \"a\" recomendado?"))
                        CalcularA();

                    else
                    {
                        k = 0;
                        form.SetK(0);
                    }
                }
            }

            if (g != 0)
            {
                if (m == 0)
                    CalcularM();

                else
                {
                    if (form.Preguntar(
                        "Desea un valor de \"m\" recomendado?"))
                        CalcularM();

                    else
                    {
                        g = 0;
                        form.SetG(0);
                    }
                }
            }

            if (generador.NecesitaC())
            {
                if (c == 0)
                    CalcularCPrimo();
                else
                    VerificarPrimaje();
            }
        }  

        public void Exportar()
        {
            string nums = "";
            foreach (double d in serie)
                nums += $"{d}\n";

            form.CopiarPortapapeles(nums);
        }

        private void CalcularM()
        {
            m = generador.CalcularM(g);
            form.SetM(m);
            form.SetG(0);
            g = 0;
        }

        private void CalcularA()
        {
            a = generador.CalcularA(k);
            form.SetA(a);
            form.SetK(0);
            k = 0;
        }

        public void TextoModificado()
        {
            datosModificados = true;
        }

        private void GetDatos()
        {
            int nX, nM, nA, nC, nK, nG;
            nX = form.GetX();
            nM = form.GetM();
            nA = form.GetA();
            nC = form.GetC();
            nK = form.GetK();
            nG = form.GetG();

            if (xIngresado != nX || nM != m || nA != a || nC != c || nK != k || nG != g)
            {
                datosModificados = true;
                x = nX;
            }  

            xIngresado = nX;
            m = nM;
            a = nA;
            c = nC;
            k = nK;
            g = nG;
        }

        private void GenerarYMostrar(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                generador.Generar(x, m, a, c);
                serie.Add(generador.GetRandom());
                form.AgregarFila(
                    serie.Count.ToString(), 
                    x.ToString(),
                    generador.GetSiguienteSemilla().ToString(),
                    generador.GetRandom().ToString());

                x = generador.GetSiguienteSemilla();
            }
        }
    }
}
