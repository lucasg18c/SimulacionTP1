using System;

namespace SimulacionTP1.Presentacion
{
    public partial class FrmMain : FrmBase
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abrir(new FrmNumerosAleatorios());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abrir(new FrmJiCuadrado());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abrir(new FrmKS());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
