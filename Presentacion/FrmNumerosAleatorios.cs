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
            PrepararVentana();
        }

        private void PrepararVentana()
        {
            pbGUIVacio.Visible = false;
            lblGUIVacio.Visible = false;
            tablaNumeros.Visible = true;
        }

        public void AgregarFila(string iteracion, string xi, string xi1, string rnd)
        {
            tablaNumeros.Rows.Add(new string[]
            {
                iteracion,
                xi,
                xi1,
                rnd                
            });
        }

        public void SetA(int valor)
        {
            txtA.Valor = valor;
        }

        public void SetM(int valor)
        {
            txtM.Valor = valor;
        }

        public int GetX()
        {
            return txtX.Valor;
        }

        public void SetK(int valor)
        {
            txtK.Valor = valor;
        }

        public void SetG(int valor)
        {
            txtG.Valor = valor;
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
            txtC.Visible = !txtC.Visible;
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

        private void ClickBtnVolver(object sender, EventArgs e)
        {
            Close();
        }

        private void ClickBtnExportar(object sender, EventArgs e)
        {
            gestor.Exportar();
        }

        public void HabilitarExportar(bool habilitar)
        {
            btnExportar.Visible = habilitar;
        }

        public void SetC(int valor)
        {
            txtC.Valor = valor;
        }

        public void SetX(int valor)
        {
            txtX.Valor = valor;
        }
    }
}
