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
            cmbIntervalos.Items.AddRange(new string[] {"5", "10", "15", "20" });
            cmbIntervalos.SelectedIndex = 1;

            lblResultado.Text = "";
            lblValoresResultado.Text = "";

            pbResultado.Image = null;
            HabilitarCopiado(false);
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
            return Convert.ToInt32(cmbIntervalos.Text.ToString());
        }

        public void ResultadoPositivo()
        {
            pbResultado.Image = Properties.Resources.cheque;
            lblResultado.Text = "No se rechaza la hipótesis nula.";
        }

        public void ResultadoNegativo()
        {
            pbResultado.Image = Properties.Resources.cancelar;
            lblResultado.Text = "Se rechaza la hipótesis nula.";
        }

        public int GetCantidadNumeros()
        {
            return txtCantidadNumeros.Valor;
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

        public void HabilitarCopiado(bool habilitar)
        {
            btnCopiar.Enabled = habilitar;
        }

        public void MostrarProcedimiento(string[][] procedimiento)
        {
            tablaProcedimiento.Rows.Clear();

            foreach (string[] fila in procedimiento)
                tablaProcedimiento.Rows.Add(fila);
        }

        public void LimpiarHistograma()
        {
            histograma.Series.Clear();
            histograma.Titles.Clear();
            histograma.Series.Add("Fo");
            histograma.Series.Add("Fe");
        }

        public void MostrarSerieAleatoria(string serie)
        {
            txtSerie.Text = serie;
        }

        private void ClickBtnGenerar(object sender, EventArgs e)
        { 
            gestor.Generar();
        }

        private void ClickBtnCopiar(object sender, EventArgs e)
        {
            gestor.Copiar();
        }
    }
}
