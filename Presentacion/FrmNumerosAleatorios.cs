using SimulacionTP1.Servicios;
using System;
using System.Windows.Forms;

namespace SimulacionTP1.Presentacion
{
    public partial class FrmNumerosAleatorios : FrmBase
    {
        bool desdeCero = true;
        GeneradorBase generador;

        public FrmNumerosAleatorios()
        {
            InitializeComponent();
        }

        private void btnGenerar_click(object sender, EventArgs e)
        {
            double[] nums;
            ulong x0 = txtX.Valor,
                m = txtM.Valor,
                a = txtA.Valor,
                c = txtC.Valor;

            try
            {
                generador.Validar(x0, m, a, c);

                if (desdeCero)
                    nums = generador.Generar(x0, m, a, c);
                else
                    nums = new double[] { generador.GenerarSiguiente(
                        (ulong)Convert.ToInt64( Convert.ToDouble( tablaNumeros.Rows[tablaNumeros.Rows.Count - 1].Cells[1].Value.ToString()) * m), 
                        m, 
                        a, 
                        c) };

                Popular(nums);
                if (!desdeCero)
                    ScrollUltimo();

                desdeCero = false;
            }
            catch(Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        private void ScrollUltimo()
        {
            tablaNumeros.CurrentCell = tablaNumeros.Rows[tablaNumeros.Rows.Count - 1].Cells[0];
        }

        private void Popular(double[] nums)
        {
            if (nums.Length == 20) tablaNumeros.Rows.Clear();

            foreach ( double d in nums )
            { 
                tablaNumeros.Rows.Add(new string[] { 
                    (tablaNumeros.Rows.Count + 1).ToString(), 
                    Math.Round(d, 4).ToString() 
                });
            } 
        }

        private void FrmNumerosAleatorios_Load(object sender, EventArgs e)
        {
            tablaNumeros.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            rbLineal.Checked = true;
            generador = new GeneradorLineal();
        }

        private void DatoModificado()
        {
            desdeCero = true;
        }

        private void rbLineal_CheckedChanged(object sender, EventArgs e)
        {
            DatoModificado();
            if (rbLineal.Checked) generador = new GeneradorLineal();
        }

        private void rbMultiplicativo_CheckedChanged(object sender, EventArgs e)
        {
            DatoModificado();
            if (rbMultiplicativo.Checked) generador = new GeneradorMultiplicativo();
        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {
            DatoModificado();
            if (txtK.TextLength == 0)
            {
                txtA.Clear();
                return;
            }
            txtA.Text = generador.CalcularA(txtK.Valor);
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            DatoModificado();
            if (txtG.TextLength == 0)
            {
                txtM.Clear();
                return;
            }
            txtM.Text = generador.CalcularM(txtG.Valor);
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {
            DatoModificado();
            
        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {
            DatoModificado();
            //txtG.Clear();
            //txtC.Text = generador.CalcularC(txtM.Valor).ToString;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            DatoModificado();
            //txtK.Clear();
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            DatoModificado();
        }
    }
}
