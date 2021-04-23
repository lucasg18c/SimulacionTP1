using System;
using System.Windows.Forms;

namespace SimulacionTP1.Presentacion.ControlesUsuario
{
    public class NumTextBox : TextBox
    {
        public enum TipoDato
        {
            Reales,
            Enteros,
            RealesNegativos
        }

        public int Valor { get { return CalcularValor(); } }
        public TipoDato Tipo { get; set; }

        public NumTextBox()
        {
            KeyPress += new KeyPressEventHandler(TeclaPresionada);
            AllowDrop = false;
            ShortcutsEnabled = false;
        }

        public void TeclaPresionada(object sender, KeyPressEventArgs evento)
        {
            if (char.IsDigit(evento.KeyChar) || char.IsControl(evento.KeyChar))
                return;

            switch (Tipo)
            {
                case TipoDato.Enteros:
                    ValidarEntero(evento);
                    break;

                case TipoDato.Reales:
                    ValidarReal(evento);
                    break;

                case TipoDato.RealesNegativos:
                    ValidarRealNegativo(evento);
                    break;
            }
        }

        private void ValidarRealNegativo(KeyPressEventArgs evento)
        {
            if (evento.KeyChar == '-' && Text.Length == 0)
                return;

            if ((evento.KeyChar == ',' || evento.KeyChar == '.') && !(Text.Contains(",") || Text.Contains(".")))
            {
                if (Text.Contains("-"))
                {
                    if (Text.Length > 1)
                        return;
                }
                else if (Text.Length > 0)
                    return;
            }
            evento.Handled = true;
        }

        private void ValidarReal(KeyPressEventArgs evento)
        {
            if ((evento.KeyChar == '.' || evento.KeyChar == ',') && Text.Length != 0 && !(Text.Contains(".") || Text.Contains(",")))
                return;
            evento.Handled = true;
        }

        private void ValidarEntero(KeyPressEventArgs evento)
        {
            evento.Handled = true;
        }

        private int CalcularValor()
        {
            if (Text.Length == 0) return 0;
            try
            {
                if (Text.Contains("."))
                    return Convert.ToInt32(Text.Replace('.', ','));

                return Convert.ToInt32(Text);
            }
            catch (Exception)
            {
            }
            return 0;
        }
    }
}
