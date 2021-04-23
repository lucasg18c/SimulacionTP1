using SimulacionTP1.Presentacion;
using System;
using System.Collections.Generic;

namespace SimulacionTP1.Servicios
{
    public class GestorPseudoaleatorios
    {
        private readonly FrmNumerosAleatorios form;
        private GeneradorBase generador;
        private int x, xIngresado, a, c, k, g, m;
        private bool datosModificados = true;
        private List<double> serie;

        private static readonly int CANTIDAD_GENERACION = 20;

        public GestorPseudoaleatorios(FrmNumerosAleatorios form)
        {
            this.form = form;
            generador = new GeneradorLineal();
        }

        public void CambiarGenerador()
        {
            if (typeof(GeneradorLineal).IsInstanceOfType(generador))
                generador = new GeneradorMultiplicativo();
            else
                generador = new GeneradorLineal();

            datosModificados = true;
            UsarBuenasPracticas();
        }

        public void Generar()
        {
            try
            {
                form.Esperar(true);
                GetDatos();

                if (datosModificados)
                {
                    datosModificados = false;

                    generador.Validar(x, m, a, c, k, g);

                    // EDIT
                    // Puse el código sobre c primo en el método UsarBuenasPrácticas, ya que ahí se
                    // calculan a y m según las buenas praácticas, sería bueno que c también se calcule ahí.
                    UsarBuenasPracticas();
                    form.LimpiarTabla();
                    serie = new List<double>();
                    GenerarYMostrar(CANTIDAD_GENERACION);
                }

                else
                {
                    GenerarYMostrar(1);
                    form.IrAlUltimo();
                }
                form.HabilitarExportar(true);
            }
            catch (Exception e)
            {
                form.MostrarError(e.Message);
                form.HabilitarExportar(false);
            }
            finally
            {
                form.Esperar(false);
            }
        }

        // EDIT
        // Le cambié el nombre (CalcularPrimerPrimoRelativoDe) y saqué el parámetro (c)
        // Entiendo la idea de plantearlo como un método genérico, y que le pases como parámetro 
        // lo que usa para calcular (c), pero si ves el código, realmente no es genérico, ni necesita serlo;
        // solo hace falta que C sea relativamente primo a M
        private void CalcularCPrimo()
        {
            int a, b, res;

            for (int i = 3; i < 100; i++)
            {

                // EDIT
                // Ejecutalo con congruencial multiplicativo :D

                a = Math.Max(c, i);
                b = Math.Min(c, i);
                do
                {
                    res = b; // guardamos el divisor en el resultado
                    b = a % b; // Guardamos el resto en el divisor
                    a = res; // El divisor pasa a dividendo
                } while (b != 0);

                if (res == 1)
                {
                    //son relativamente primos

                    // EDIT
                    // En este punto ya se habría abierto una ventana preguntando si calcular C, y el usuario dijo si
                    // Realmente hace falta avisarle que ya se calculó? Si total ya te dió el OK para hacerlo
                    //form.MostrarInformacion("Se calculo un valor, que es primo relativo de C.", "C y M, COMO PRIMOS RELATIVOS");

                    // EDIT
                    // Por qué modificás M? No era c lo que hay que calcular?

                    //form.SetM(i);
                    //m = i;
                    form.SetC(i);
                    c = i;
                    break;
                }
            }
        }

        // EDIT
        // Saqué los parámtros (c y m), por la misma razón que en el método CalcularCPrimo
        public void VerificarPrimaje()
        {
            int a = Math.Max(c, m);
            int b = Math.Min(c, m);
            int res;
            do
            {
                res = b; // guardamos el divisor en el resultado
                b = a % b; // Guardamos el resto en el divisor
                a = res; // El divisor pasa a dividendo
            } while (b != 0);

            // EDIT
            // Te parece cómodo que CADA VEZ que generés un número te avise que el c está bien ?
            // No sería más lógico que avise SOLO cuando NO ?

            //if (res == 1)
            //{
                //son relativamente primos
                // 
                //form.MostrarInformacion("De lujo!, sus numeros C y M ingresados, son relativamente primos\n" +
                //    "El calculo obtendra la mayor periocicidad", "C y M, COMO PRIMOS RELATIVOS");
            //}
            if (res != 1)
                // no son relativamente primos
                //me gustaria agregar una pregunta si desea calcular un valor de M que sea relativamente primo o dejarlo asi pero ahora pongo esto
                    
                // PREGUNTA LISTA
                if (form.Preguntar("Desea calcular un valor de \"c\" relativamente primo a \"m\"?"))
                    CalcularCPrimo();
        }

        public void UsarBuenasPracticas()
        {
            // si k es algun valor y a es cero , preguntaremos al user si desea usar la k para calcular a
            if (k != 0)
            {
                if (a == 0)
                    CalcularA();
                
                else
                {
                    if (form.Preguntar("Desea un valor de \"a\" recomendado?"))
                        CalcularA();

                    else
                    {
                        k = 0;
                        form.SetK(0);
                    }
                }
            }

            if (g != 0)
            {
                if (m == 0)
                    CalcularM();

                else
                {
                    if (form.Preguntar(
                        "Desea un valor de \"m\" recomendado?"))
                        CalcularM();

                    else
                    {
                        g = 0;
                        form.SetG(0);
                    }
                }
            }
            // EDIT
            // Rearmé los if, por tres motivos:
            //   1. Si tu if solo ejecuta una línea, no necesita llaves (acorta el archivo y es más fácil de leer)
            //   2. Se pregunta 2 veces si c != 0; con una vez, alcanza.
            //   3. Realmente no hace falta ver que c sea != 0, ya que para este punto, ya se validó que no lo sea
            //     (si vas a implementar que cuando el usuario no ingrese C, este se calcule solo, hay que rearmar esto)

            //if (m == 0 && c != 0)
            //{
            //    CalcularCPrimo();
            //}
            //else
            //{
            //    if (c != 0)
            //    {
            //        VerificarPrimaje();
            //    }
            //}
            //prueba
            if (m == 0)
                CalcularCPrimo();
            else
                VerificarPrimaje();
        }  

        public void Exportar()
        {
            string nums = "";
            foreach (double d in serie)
                nums += $"{d}\n";

            form.CopiarPortapapeles(nums);
        }

        private void CalcularM()
        {
            m = generador.CalcularM(g);
            form.SetM(m);
            form.SetG(0);
            g = 0;
        }

        private void CalcularA()
        {
            a = generador.CalcularA(k);
            form.SetA(a);
            form.SetK(0);
            k = 0;
        }

        public void TextoModificado()
        {
            datosModificados = true;
        }

        private void GetDatos()
        {
            int nX, nM, nA, nC, nK, nG;
            nX = form.GetX();
            nM = form.GetM();
            nA = form.GetA();
            nC = form.GetC();
            nK = form.GetK();
            nG = form.GetG();

            if (xIngresado != nX || nM != m || nA != a || nC != c || nK != k || nG != g)
            {
                datosModificados = true;
                x = nX;
            }  

            xIngresado = nX;
            m = nM;
            a = nA;
            c = nC;
            k = nK;
            g = nG;
        }

        private void GenerarYMostrar(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                generador.Generar(x, m, a, c);
                x = generador.GetSiguienteSemilla();
                form.AgregarFila(generador.GetRandom().ToString());
                serie.Add(generador.GetRandom());
            }
        }
    }
}
