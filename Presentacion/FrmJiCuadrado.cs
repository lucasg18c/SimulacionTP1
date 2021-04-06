using SimulacionTP1.Modelo;
using SimulacionTP1.Servicios;
using System;

namespace SimulacionTP1.Presentacion
{
    public partial class FrmJiCuadrado : FrmBase, IFrmPruebaBondad
    {
        private readonly GestorPruebaBondad gestor; 

        public FrmJiCuadrado()
        {
            InitializeComponent();
            gestor = new GestorPruebaBondad(this);
        }

        public int GetCantidadIntervalos()
        {
            return txtCantidadIntervalos.Valor;
        }

        public int GetCantidadNumeros()
        {
            return txtCantidadNumeros.Valor;
        }

        //public void ClickBtnGenerar(object sender, EventArgs e)
        //{
        //    gestor.Generar();
        //}

        public void MostrarHistograma(ConteoFrecuencia[] conteos, int frecuenciaEsperada)
        {
            LimpiarHistograma();
            foreach (ConteoFrecuencia conteoFrecuencia in conteos)
            {
                histo.Series["Fo"].Points.AddXY( conteoFrecuencia.GetIntervalo(), conteoFrecuencia.GetConteo());
                histo.Series["Fe"].Points.AddXY( conteoFrecuencia.GetIntervalo(), frecuenciaEsperada);
            }
        }

        public void MostrarProcedimiento(string[][] procedimiento)
        {
            gdrDesde.Rows.Clear();

            foreach (string[] fila in procedimiento)
                gdrDesde.Rows.Add(fila);
        }

        public void LimpiarHistograma()
        {
            histo.Series.Clear();
            histo.Titles.Clear();
            histo.Series.Add("Fo");
            histo.Series.Add("Fe");
            histo.Titles.Add("Histograma Prueba de Ji-Cuadrada - Relación entre Frecuencia observada y esperada");
        }

        public void MostrarSerieAleatoria(string[] serie)
        {
            tablaNumeros.Rows.Clear();
            for (int i = 0; i < serie.Length; i++)
            
                tablaNumeros.Rows.Add( new string[] 
                {
                    (i + 1).ToString(),
                    serie[i]
                });  
        }

        private void ClickBtnGenerar(object sender, EventArgs e)
        {
            gestor.Generar();
        }
    }
}
