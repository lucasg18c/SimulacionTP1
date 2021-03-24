using System;
using System.Windows.Forms;

namespace SimulacionTP1.Presentacion
{
    public partial class FrmSmirnov : FrmBase
    {

        public FrmSmirnov()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, System.EventArgs e)
        {
            double cantNum = double.Parse(txtCantidadNum.Text);
            double cantInt = double.Parse(txtCantidadInt.Text);
            dgvTabla.Rows.Clear();
            dgvIntervalos.Rows.Clear();
            NumerosAleatorios(cantNum);
            Intervalos(cantInt, cantNum);

        }
        public void NumerosAleatorios(double cantNum)
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);

            for (int i = 1; i <= cantNum; i++)
            {
                var value = random.NextDouble();
                dgvTabla.Rows.Add(i, (Math.Round(value, 4)));
            }
        }

        public void Intervalos(double cantInt, double cantNum)
        {
            double count = 0;
            double totalIntervalos = cantNum / cantInt;
            double valorIntervalo = 1 / cantInt;
            double count2 = valorIntervalo;
            double intervaloInferior = 0;
            double intervaloSuperior = valorIntervalo;
            double acumPo = 0;
            double acumPe = 0;
            double maximo = 0;

            for (int i2 = 1; i2 <= cantInt; i2++)
            {

                int count3 = 0;
                for (int i3 = 0; i3 <= (cantNum - 1); i3++)
                {
                    double var = double.Parse(dgvTabla.Rows[i3].Cells[1].Value.ToString());

                    if (intervaloInferior <= var && intervaloSuperior > var)
                    {
                        count3 = count3 + 1;
                    }

                }

                
                acumPo = Math.Round(count3 / cantNum, 4) + acumPo;
                acumPe = Math.Round((totalIntervalos / cantNum), 4) + acumPe;
                double abs = Math.Round(Math.Abs(acumPo - acumPe), 4);

                if (abs >= maximo)
                {
                    maximo = abs;
                }

                dgvIntervalos.Rows.Add(Math.Round(count, 4), Math.Round(count2, 4), count3, totalIntervalos,
                    Math.Round(count3 / cantNum, 4), Math.Round(totalIntervalos / cantNum, 4), acumPo, acumPe,
                    abs,maximo);

                
                count = count + valorIntervalo;
                count2 = count2 + valorIntervalo;

                intervaloInferior = intervaloInferior + valorIntervalo;
                intervaloSuperior = intervaloSuperior + valorIntervalo;

            }


        }

        private void dgvtablaNumeros_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
