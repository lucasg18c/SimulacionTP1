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
            UsarBuenasPracticas();
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

                    generador.Validar(x, m, a, c, k, g);
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

        public void UsarBuenasPracticas()
        {
            if (k != 0)
            {
                if (a == 0)
                    CalcularA();
                
                else
                {
                    bool res = form.Preguntar($"Desea usar la el valor de \"k\" ({k}) para calcular un nuevo \"a\"?");
                    if (res)
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
                    bool res = form.Preguntar($"Desea usar la el valor de \"g\" ({g}) para calcular un nuevo \"m\"?");
                    if (res)
                        CalcularM();

                    else
                    {
                        g = 0;
                        form.SetG(0);
                    }
                }
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
                x = generador.GetSiguienteSemilla();
                form.AgregarFila(generador.GetRandom().ToString());
                serie.Add(generador.GetRandom());
            }
        }
    }
}
