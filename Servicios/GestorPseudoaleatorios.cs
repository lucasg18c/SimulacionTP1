using SimulacionTP1.Presentacion;
using System;

namespace SimulacionTP1.Servicios
{
    public class GestorPseudoaleatorios
    {
        private readonly FrmNumerosAleatorios form;
        private GeneradorBase generador;
        private int x, a, c, k, g;
        private double m;
        private bool datosModificados = true;
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
            CalcularDatos();
        }

        public void Generar()
        {
            try
            {
                if (datosModificados)
                {
                    datosModificados = false;
                    
                    GetDatos();
                    generador.Validar(x, m, a, c, k, g);
                    CalcularDatos();
                    form.LimpiarTabla();
                    GenerarYMostrar(CANTIDAD_GENERACION);
                }
                else
                {
                    GenerarYMostrar(1);
                    form.IrAlUltimo();
                }      
            }
            catch (Exception e)
            {
                form.MostrarError(e.Message);
            }
        }

        public void CalcularDatos()
        {
            if (k != 0 && a == 0)
            {
                a = generador.CalcularA(k);
                form.SetA(a.ToString());
            }

            if (g != 0 && m == 0)
            {
                m = generador.CalcularM(g);
                form.SetM(m.ToString());
            }
        }

        public void TextoModificado()
        {
            datosModificados = true;
        }

        private void GetDatos()
        {
            x = form.GetX();
            m = form.GetM();
            a = form.GetA();
            c = form.GetC();
            k = form.GetK();
            g = form.GetG();
        }

        private void GenerarYMostrar(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                generador.Generar(x, m, a, c);
                x = generador.GetSiguienteSemilla();
                form.AgregarFila(generador.GetRandom().ToString());
            }
        }
    }
}
