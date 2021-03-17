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
    public partial class FrmBase : Form
    {
        private FrmBase anterior;

        public FrmBase()
        {
            InitializeComponent();
        }

        public void Abrir(FrmBase formulario)
        {
            formulario.anterior = this;
            formulario.Show();
            Hide();
        }

        private void FrmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (anterior != null)
                anterior.Show();
        }
    }
}
