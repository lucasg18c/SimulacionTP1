using System;
using System.Windows.Forms;

namespace SimulacionTP1.Presentacion.ControlesUsuario
{
    public class NumTextBox : TextBox
    {
        public int Valor { get { return valor(); } }

        public NumTextBox()
        {
            KeyPress += new KeyPressEventHandler(ValidarTecla);
            AllowDrop = false;
            ShortcutsEnabled = false;
        }

        public void ValidarTecla(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Para permitir decimales
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private int valor()
        {
            if (Text.Length == 0) return 0;
            return Convert.ToInt32(Text);
        }
    }
}
