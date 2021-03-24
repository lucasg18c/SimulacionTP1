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


            validarHipotesis(cantNum, maximo);

        }

        private void validarHipotesis(double n, double maximo)
        {
            int i = (int)n;
            double estPrueba = maximo;
            double valorCritico = 0;
            double[] valCriticos = { 0.9750, 0.8418, 0.7076, 0.6239, 0.5632, 0.5192, 0.4834, 0.4542, 0.4300
            , 0.4092, 0.3912, 0.3754, 0.3614, 0.3489 , 0.3375, 0.3273, 0.3179, 0.3093, 0.3014, 0.2940, 0.2872
            , 0.2808, 0.2749, 0.2693, 0.2640, 0.2590, 0.2543, 0.2499, 0.2457, 0.2417, 0.2378, 0.2342, 0.2307
            , 0.2274, 0.2242};
           
            if (n > 35)
            {
                valorCritico =  Math.Round((1.36 / Math.Sqrt(n)),4);

            }
            else
            {
                valorCritico = valCriticos[i - 1];
            }

            if (valorCritico > estPrueba)
            {
                MessageBox.Show( "Valor Critico = " + valorCritico +
                    "Estadisitico de prueba = " + estPrueba +
                    "La hipotesis nula NO SE PUEDE RECHAZAR, con un nivel de significancia" +
                    "del 0.05");
            }
            else
            {
                MessageBox.Show("Valor Critico = " + valorCritico +
                    "Estadisitico de prueba = " + estPrueba +
                    "  La hipotesis nula  SE PUEDE RECHAZAR, con un nivel de significancia" +
                    "del 0.05");
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
