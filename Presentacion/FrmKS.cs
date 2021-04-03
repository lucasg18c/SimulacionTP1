using SimulacionTP1.Modelo;
using SimulacionTP1.Servicios;

namespace SimulacionTP1.Presentacion
{
    public partial class FrmKS : FrmBase, IFrmPruebaBondad
    {
        private GestorPruebaBondad gestor;

        public FrmKS()
        {
            InitializeComponent();
            gestor = new GestorPruebaBondad(this);
        }

        private void ClickBtnGenerar(object sender, System.EventArgs e)
        {
            gestor.Generar();
        }

        public int GetCantidadNumeros()
        {
            return txtCantidadNum.Valor;
        }

        public int GetCantidadIntervalos()
        {
            return txtCantidadInt.Valor;
        }

        public void MostrarSerieAleatoria(string[] serie)
        {
            dgvTabla.Rows.Clear();
            for (int i = 0; i < serie.Length; i++)

                dgvTabla.Rows.Add(new string[]
                {
                    (i + 1).ToString(),
                    serie[i]
                });
        }

        public void MostrarHistograma(ConteoFrecuencia[] conteos, int frecuenciaEsperada)
        {
            LimpiarHistograma();
            foreach (ConteoFrecuencia conteoFrecuencia in conteos)
            {
                histograma.Series["Fo"].Points.AddXY(conteoFrecuencia.GetIntervalo(), conteoFrecuencia.GetConteo());
                histograma.Series["Fe"].Points.AddXY(conteoFrecuencia.GetIntervalo(), frecuenciaEsperada);
            }
        }

        public void LimpiarHistograma()
        {
            histograma.Series.Clear();
            histograma.Titles.Clear();
            histograma.Series.Add("Fo");
            histograma.Series.Add("Fe");
            histograma.Titles.Add("Histograma Kolmogorov-Smirnov");
        }

        public void MostrarProcedimiento(string[][] procedimiento)
        {
            dgvIntervalos.Rows.Clear();

            foreach (string[] fila in procedimiento)
                dgvIntervalos.Rows.Add(fila);
        }
    }
}
