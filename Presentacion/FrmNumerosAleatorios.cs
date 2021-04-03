using SimulacionTP1.Servicios;
using System;
using System.Windows.Forms;

namespace SimulacionTP1.Presentacion
{
    public partial class FrmNumerosAleatorios : FrmBase
    {
        private readonly GestorPseudoaleatorios gestor;

        public FrmNumerosAleatorios()
        {
            InitializeComponent();
            gestor = new GestorPseudoaleatorios(this);
            tablaNumeros.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        private void ClickBtnGenerar(object sender, EventArgs e)
        {
            gestor.Generar();
        }    

        public void AgregarFila(string valor)
        {
            tablaNumeros.Rows.Add(new string[]
            {
                (tablaNumeros.Rows.Count + 1).ToString(),
                valor
            });
        }

        public void SetA(string valor)
        {
            txtA.Text = valor;
        }

        public void SetM(string valor)
        {
            txtM.Text = valor;
        }

        public int GetX()
        {
            return txtX.Valor;
        }

        public void SetK(string valor)
        {
            txtK.Text = valor;
        }

        public void SetG(string valor)
        {
            txtG.Text = valor;
        }

        public void LimpiarTabla()
        {
            tablaNumeros.Rows.Clear();
        }

        public void IrAlUltimo()
        {
            tablaNumeros.CurrentCell = tablaNumeros.Rows[tablaNumeros.Rows.Count - 1].Cells[0];
        }

        private void ClickRadioButton(object sender, EventArgs e)
        {
            gestor.CambiarGenerador();
        }

        public int GetM()
        {
            return txtM.Valor;
        }

        public int GetC()
        {
            return txtC.Valor;
        }

        public int GetA()
        {
            return txtA.Valor;
        }

        public int GetK()
        {
            return txtK.Valor;
        }

        public int GetG()
        {
            return txtG.Valor;
        }

        private void TextoModificado(object sender, EventArgs e)
        {
            gestor.TextoModificado();
        }
    }
}
