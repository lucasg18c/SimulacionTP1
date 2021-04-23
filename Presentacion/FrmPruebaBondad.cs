using SimulacionTP1.Servicios;
using System;

namespace SimulacionTP1.Presentacion
{
    public partial class FrmPruebaBondad : FrmBase
    {
        private readonly GestorPruebaBondad gestor; 

        public enum Pruebas
        {
            ChiCuadrado,
            KS
        }

        public FrmPruebaBondad(Pruebas prueba)
        {
            InitializeComponent();
            IniciarFormulario();
            gestor = new GestorPruebaBondad(this, prueba);
        }

        private void IniciarFormulario()
        {
            lblResultado.Text = "";
            lblValoresResultado.Text = "";
            pbResultado.Image = null;
        }

        public void SetColumnasTabla(string[] columnas)
        {
            for (int i = 0; i < columnas.Length; i++)
                tablaProcedimiento.Columns.Add($"col{i}", columnas[i]);
        }

        public void SetTitulo(string titulo)
        {
            Text = $"Prueba de bondad de {titulo}";
        }

        public int GetIntervalos()
        {
            return cmbIntervalo.Valor;
        }

        public void ResultadoExitoso(bool exito)
        {
            if (exito)
            {
                pbResultado.Image = Properties.Resources.cheque;
                lblResultado.Text = "No se rechaza la hipótesis nula.";
            }
            else
            {
                pbResultado.Image = Properties.Resources.cancelar;
                lblResultado.Text = "Se rechaza la hipótesis nula.";
            }
        }

        public int GetCantidadNumeros()
        {
            return txtCantidad.Valor;
        }

        public void SetValoresResultado(string resultado)
        {
            lblValoresResultado.Text = resultado;
        }

        public void MostrarHistograma(double x, int frecuenciaObservada, double frecuenciaEsperada)
        {
            histograma.Series["Fo"].Points.AddXY( x, frecuenciaObservada);
            histograma.Series["Fe"].Points.AddXY( x, frecuenciaEsperada);
        }

        public void MostrarProcedimiento(string[][] procedimiento)
        {
            tablaProcedimiento.Rows.Clear();

            foreach (string[] fila in procedimiento)
                tablaProcedimiento.Rows.Add(fila);
        }

        public void LimpiarHistograma()
        {
            histograma.Series["Fo"].Points.Clear();
            histograma.Series["Fe"].Points.Clear();
            histograma.Titles.Clear();
        }

        public void MostrarSerieAleatoria(string serie)
        {
            txtSerie.Text = serie;
        }

        private void ClickBtnGenerar(object sender, EventArgs e)
        { 
            gestor.Generar();
            PrepararVentana();
        }

        private void PrepararVentana()
        {
            lblGUIVacio.Visible = false;
            pbGUIVacio.Visible = false;
            tablaProcedimiento.Visible = true;
            histograma.Visible = true;
            txtSerie.Visible = true;
        }

        private void ClickBtnCopiar(object sender, EventArgs e)
        {
            gestor.Exportar();
        }

        private void ClickBtnVolver(object sender, EventArgs e)
        {
            Close();
        }

        public void HabilitarExportar(bool habilitar)
        {
            btnExportar.Visible = habilitar;
        }
    }
}
