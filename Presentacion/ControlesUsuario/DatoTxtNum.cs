using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimulacionTP1.Presentacion.ControlesUsuario
{
    public partial class DatoTxtNum : UserControl
    {
        public Color ColorHover { get; set; } = Color.FromArgb(57, 70, 87);
        public Color ColorFondo { get; set; } = Color.FromArgb(48, 61, 77);
        public string Texto { 
            get { return lblNombreCampo.Text; }
            set { lblNombreCampo.Text = value; } 
        }
        public int Valor { 
            get { return txtValor.Valor; } 
            set 
            {
                if (value == 0) txtValor.Text = "";
                else txtValor.Text = value.ToString(); 
            }
        }

        public NumTextBox.TipoDato TipoDato {
            get { return txtValor.Tipo; }
            set { txtValor.Tipo = value; }
        }

        public DatoTxtNum()
        {
            InitializeComponent();
            pnlLineaBase.BackColor = ColorHover;
        }

        private void Hover(object sender, EventArgs e)
        {
            BackColor = ColorHover;
            txtValor.BackColor = ColorHover;
        }

        private void CambioDimensiones(object sender, EventArgs e)
        {
            txtValor.Height = lblNombreCampo.Height;
        }

        private void MouseSale(object sender, EventArgs e)
        {
            BackColor = ColorFondo;
            txtValor.BackColor = ColorFondo;
        }

        private void ClickValor(object sender, EventArgs e)
        {
            txtValor.Focus();
            txtValor.SelectAll();
        }
    }
}
