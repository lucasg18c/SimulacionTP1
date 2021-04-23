using System;

namespace SimulacionTP1.Presentacion
{
    public partial class FrmMain : FrmBase
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ClickBtnNumerosAleatorios(object sender, EventArgs e)
        {
            Abrir(new FrmNumerosAleatorios());
        }

        private void ClickBtnChiCuadrado(object sender, EventArgs e)
        {
            Abrir(new FrmPruebaBondad(FrmPruebaBondad.Pruebas.ChiCuadrado));
        }

        private void ClickBtnKs(object sender, EventArgs e)
        {
            Abrir(new FrmPruebaBondad(FrmPruebaBondad.Pruebas.KS));
        }

        private void ClickBtnVersion(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/lucasg18c/SimulacionTP1");
        }
    }
}
