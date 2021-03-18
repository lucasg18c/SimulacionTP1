using SimulacionTP1.Servicios;
using System;

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
            int x0 = txtX0.Valor,
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
                        Convert.ToInt32( Convert.ToDouble( tablaNumeros.Rows[tablaNumeros.Rows.Count - 1].Cells[0].Value.ToString()) * m), 
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

            foreach (double f in nums)
            {
                tablaNumeros.Rows.Add(new string[] { Math.Round(f, 4).ToString() });
            } 
        }

        private void FrmNumerosAleatorios_Load(object sender, EventArgs e)
        {
            cmbMetodo.Items.AddRange(new string[] { "Congruencial Lineal", "Congruencial Multiplicativo" });
            cmbMetodo.SelectedIndex = 0;
            tablaNumeros.Columns[0].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        }

        private void cmbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatoModificado(null, null);

            switch (cmbMetodo.SelectedIndex)
            {
                case 0:
                    generador = new GeneradorLineal();
                    txtC.Enabled = true;
                    break;
                case 1:
                    generador = new GeneradorMultiplicativo();
                    txtC.Enabled = false;
                    break;
            }
        }

        private void DatoModificado(object sender, EventArgs e)
        {
            desdeCero = true;
        }
    }
}
