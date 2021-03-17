using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Abrir(new FrmSmirnov());
        }
    }
}
