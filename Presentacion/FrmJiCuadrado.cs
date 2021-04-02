using SimulacionTP1.Modelo;
using SimulacionTP1.Servicios;
using System;

namespace SimulacionTP1.Presentacion
{
    public partial class FrmJiCuadrado : FrmBase
    {
        private readonly GestorJiCuadrado gestor; 

        public FrmJiCuadrado()
        {
            InitializeComponent();
            gestor = new GestorJiCuadrado(this);
        }

        public long GetCantidadIntervalos()
        {
            return txtInter.Valor;
        }

        public long GetCantidadNumeros()
        {
            return txtCan.Valor;
        }

        public void ClickBtnGenerar(object sender, EventArgs e)
        {
            gestor.Generar();
        }

        public void MostrarHistograma(ConteoFrecuencia[] conteos, int frecuenciaEsperada)
        {
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

        public void PrepararHistograma()
        {
            histo.Series.Clear();
            histo.Titles.Clear();
            histo.Series.Add("Fo");
            histo.Series.Add("Fe");
            histo.Titles.Add("Relación entre Frecuencia observada y esperada");
        }

        public void MostrarGrilla(string[] serie)
        {
            tablaNumeros.Rows.Clear();
            for (int i = 0; i < serie.Length; i++)
            
                tablaNumeros.Rows.Add( new string[] 
                {
                    (i + 1).ToString(),
                    serie[i]
                });  
        }
    }
}
