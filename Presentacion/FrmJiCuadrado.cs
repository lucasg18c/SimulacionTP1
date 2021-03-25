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
    public partial class FrmJiCuadrado : FrmBase
    {
        
        public FrmJiCuadrado()
        {
            InitializeComponent();
            
        }

        public void btnGenerar_Click(object sender, System.EventArgs e)
        {
            double[] ser;
            int x0 = int.Parse(txtCan.Text.Trim());
            int inter = int.Parse(txtInter.Text.Trim());

            try
            {
                Validacion(x0, inter);               
                btnReiniciar.Enabled = true;
                btnGenerar.Enabled = false;
                histo.Series.Clear();
                histo.Titles.Clear();
                histo.Series.Add("Fo");
                histo.Series.Add("Fe");
                histo.Titles.Add("Relacion entre Frecuencia observada y esperada");
                MostrarGrilla(ser = GenerarSerie(x0));
                calcularIntervalos(x0, inter);                                   
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        public void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Validacion(int x0, int inter)
        {
            if (x0 <= 0) throw new ApplicationException("Ingrese un valor de numeros validos");
            if (inter <= 0) throw new ApplicationException("Ingrese un valor de intervalos validos");
        }

        public double[] GenerarSerie(int ser)
        {
            double[] num = new double[ser];
            Random ran = new Random();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = ran.NextDouble();
            }
            return num;
        }


        public void MostrarGrilla(double[] ser)
        {
            tablaNumeros.Rows.Clear();
            foreach (double i in ser)
            {
                tablaNumeros.Rows.Add(new string[] {
                    (tablaNumeros.Rows.Count + 1).ToString(),Math.Round(i, 4).ToString() }
                );
            }
        }

        public void calcularIntervalos(double x0, double inter)
        {
            double cantidadInter = x0 / inter;
            double valorInter = 1 / inter;
            double c1 = valorInter;
            double intMin = 0;
            double intMay = valorInter;
            double ultimo = 0;
            double c2 = 0;

            for (int i = 1; i <= inter; i++)
            {               
                int contadorNumeros = 0;
                for (int i2 = 0; i2 <= (x0 - 1); i2++)
                {
                    double var = double.Parse(tablaNumeros.Rows[i2].Cells[1].Value.ToString());

                    if (var <= intMay && var > intMin)
                    {
                        contadorNumeros = contadorNumeros + 1;
                    }                  
                }
                histo.Series["Fo"].Points.AddXY(c1, contadorNumeros);
                histo.Series["Fe"].Points.AddXY(c1, cantidadInter);
                double c = calcularC(contadorNumeros, cantidadInter);
                
                c2 = c2 + c;
                ultimo = c2;
                gdrDesde.Rows.Add(Math.Round(intMin, 4), Math.Round(intMay, 4), contadorNumeros, cantidadInter, Math.Round(c, 4), Math.Round(c2, 4));

                c1 = c1 + valorInter;
                intMin = intMay;
                intMay = intMay + valorInter;           
            }            
            calcularChi(inter, ultimo);
        }

        private void calcularChi(double inter, double ultimo)
        {
            int i = (int)inter;
            double valorC = 0;
            double val = inter - 1;
            bool fla = false;

            if (inter <= 30)
            {
                double[] valCriticos = { 3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9
                , 18.3, 19.7, 21.0, 22.4, 23.7 , 25.0, 26.3, 27.6, 28.9, 30.1, 31.4, 32.7
                , 33.9, 35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8};
                valorC = valCriticos[i - 1];
            }

            if (inter <= 30)
                if (valorC > ultimo)
                {
                    MessageBox.Show("La prueba no puede ser rechazada, el valor " + valorC +
                        " es mayor al valor de C: " + Math.Round(ultimo, 4), "Resultado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fla = true;
                }
                else
                {
                    MessageBox.Show("La prueba a sido rechazada, el valor " + valorC +
                        " es menor al valor de C: " + Math.Round(ultimo, 4), "Resultado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fla = true;

                }
            if (40 > val && val > 30)
            {
                valorC = 43.8;
            }
            if (50 > val && val >= 40)
            {
                valorC = 55.8;
            }
            if (60 > val && val >= 50)
            {
                valorC = 67.5;
            }
            if (70 > val && val >= 60)
            {
                valorC = 79.1;
            }
            if (80 > val && val >= 70)
            {
                valorC = 90.5;
            }
            if (90 > val && val >= 80)
            {
                valorC = 101.9;
            }
            if (100 > val && val >= 90)
            {
                valorC = 113.1;
            }
            if (val > 100)
            {
                valorC = 124.3;
            }

            if (fla == false)
            {
                if (valorC > ultimo)
                {
                    MessageBox.Show("La prueba no puede ser rechazada, el valor " + valorC +
                        " es mayor al valor de C: " + Math.Round(ultimo, 4), "Resultado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La prueba a sido rechazada, el valor " + valorC +
                        " es menor al valor de C: " + Math.Round(ultimo, 4), "Resultado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        public double calcularC(double contadorNumeros, double cantidadInter)
        {
            double c = Math.Pow((cantidadInter - contadorNumeros), 2) / cantidadInter;
            return c;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            gdrDesde.Rows.Clear();
            tablaNumeros.Rows.Clear();
            btnGenerar.Enabled = true;
            btnReiniciar.Enabled = false;
            txtCan.Text = "";
            txtInter.Text = "";
            histo.Series.Clear();
        }
    }
}
