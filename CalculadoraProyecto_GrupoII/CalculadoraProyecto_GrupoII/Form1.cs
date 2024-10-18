using CalculadoraProyecto_GrupoII.CalculadoraProyecto_GrupoII;
using System;
using static CalculadoraProyecto_GrupoII.Factorial;
using static System.Runtime.InteropServices.JavaScript.JSType;
//Grupo 2 Porgramacion 2
//Universidad Hispanoamericana
//Prof. Alexander Curling
//Estudiantes:
//Josue Espinoza Castillo
//Zulliany Juarez Naranjo
//Kevin Lezcano Luna
//Ian Malespin Palacios
namespace CalculadoraProyecto_GrupoII
{

    public partial class Form1 : Form
    {


        static double num1 = 0, num2 = 0;
        static System.Boolean activado = false;
        static string valor2 = "";
        private string operacion = "";
        static bool ingresoPermitido = true;

        public Form1()


        {
            InitializeComponent();
            {
            }



        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            cleanClase limpiarClase = new cleanClase();
            limpiarClase.Limpiar(ref num1, ref num2, ref valor2, ref SalidaTextBox, ref activado);

            ingresoPermitido = true; // Permite la entrada de más números en caso de ser true en caso de ser false va a cancelar todos los numeros
        }


        private void equalButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(valor2))
            {
                try
                {
                    double numero = Comas.ObtenerDecimal(valor2); // Invocamos la clase Comas para obtener numeros decimales
                    double resultado;

                    // Verificar si la operación es potencia
                    if (operacion == "^")
                    {
                        resultado = Potencia.Calcular(num1, numero); //Realizamos el calculo de las potencias mediante la clase
                    }
                    else
                    {
                      //En caso de no ser potencia se sigue con otras operaciones
                        Calculadora calc = new Calculadora(num1, numero, operacion); 
                        resultado = calc.Calcular();
                    }

                    SalidaTextBox.Text = resultado.ToString(); // Mostrar el resultado
                    valor2 = ""; 
                    activado = false;

                   
                    ingresoPermitido = false; 
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }
        private void comaButton_Click(object sender, EventArgs e)
        {
            //Invocamos la clase Comas, para realizar las operaciones
            Comas.AgregarComa(ref valor2, ref SalidaTextBox);
        }

        private void sieteButton_Click(object sender, EventArgs e)
        {
            {
                if (ingresoPermitido) //Con este if verificamos si el ingreso del numero al textBox esta permitido en caso de, realizar la accion
                {
                    valor2 += "7"; 
                    SalidaTextBox.Text += "7"; 
                    activado = true;
                }
            }
        }

        private void ochoButton_Click(object sender, EventArgs e)
        {
            {
                if (ingresoPermitido) //Con este if verificamos si el ingreso del numero al textBox esta permitido en caso de, realizar la accion
                {
                    valor2 += "8"; //Se Actualiza el valor de valor2
                    SalidaTextBox.Text += "8"; 
                    activado = true;
                }
            }
        }

        private void nueveButton_Click(object sender, EventArgs e)
        {
            {
                if (ingresoPermitido) //Con este if verificamos si el ingreso del numero al textBox esta permitido en caso de, realizar la accion
                {
                    valor2 += "9"; 
                    SalidaTextBox.Text += "9"; 
                    activado = true; 
                }
            }
        }

        private void cuatroButton_Click(object sender, EventArgs e)
        {
            {
                if (ingresoPermitido) //Con este if verificamos si el ingreso del numero al textBox esta permitido en caso de, realizar la accion
                {
                    valor2 += "4"; 
                    SalidaTextBox.Text += "4"; 
                    activado = true; 
                }
            }
        }

        private void cincoButton_Click(object sender, EventArgs e)
        {
            {
                if (ingresoPermitido) //Con este if verificamos si el ingreso del numero al textBox esta permitido en caso de, realizar la accion
                {
                    valor2 += "5"; 
                    SalidaTextBox.Text += "5"; 
                    activado = true; 
                }
            }
        }

        private void seisButton_Click(object sender, EventArgs e)
        {
            {
                if (ingresoPermitido) //Con este if verificamos si el ingreso del numero al textBox esta permitido en caso de, realizar la accion
                {
                    valor2 += "6"; 
                    SalidaTextBox.Text += "6"; 
                    activado = true; 
                }
            }
        }

        private void unoButton_Click(object sender, EventArgs e)
        {
            {
                if (ingresoPermitido) //Con este if verificamos si el ingreso del numero al textBox esta permitido en caso de, realizar la accion
                {
                    valor2 += "1"; 
                    SalidaTextBox.Text += "1"; 
                    activado = true; 
                }
            }
        }

        private void dosButton_Click(object sender, EventArgs e)
        {
            {
                if (ingresoPermitido) //Con este if verificamos si el ingreso del numero al textBox esta permitido en caso de, realizar la accion
                    valor2 += "2";
                SalidaTextBox.Text += "2";
                activado = true;
            }
        }

        private void tresButton_Click(object sender, EventArgs e)
        {
            {
                if (ingresoPermitido) //Con este if verificamos si el ingreso del numero al textBox esta permitido en caso de, realizar la accion
                    valor2 += "3";
                SalidaTextBox.Text += "3";
                activado = true;
            }
        }

        private void ceroButton_Click(object sender, EventArgs e)
        {
            {
                if (ingresoPermitido)
                {
                    valor2 += "0"; //Con este if verificamos si el ingreso del numero al textBox esta permitido en caso de, realizar la accion
                    SalidaTextBox.Text += "0"; 
                    activado = true; 
                }
            }
        }



        private void diezxButton_Click(object sender, EventArgs e)
        {
            // un if el cual Verifica si activado es verdadero
            if (activado)
            {
                // convertimos el valor2  a un parse esto se intenta mediante un tryparse
                if (int.TryParse(valor2, out int exponente))
                {
                    // Llamamos a la clase Potencia10 para calcular 10^exponente
                    double resultado = Potencia10.PotenciaDiez(exponente);
                    SalidaTextBox.Text = resultado.ToString();

                    //Limpiamos las variables
                    valor2 = ""; 
                    activado = false; // El boton se desactiva hasta que se ingrese otro numero

                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número antes de usar la función 10^x.");//En caso de no haber un numero enseña este mensaje de error
            }
        }

        private void sumaButton_Click(object sender, EventArgs e)
        {
            {
                if (double.TryParse(valor2, out num1)) // Cambiamos los datos a double
                {
                    operacion = "+";
                    SalidaTextBox.Text += "+"; // Se ingresa la operacion al textbox en este caso la suma
                    valor2 = ""; 
                    activado = true;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido.");//En caso de no haber un numero enseña este mensaje de error
                }
            }
        }

        private void restaButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(valor2, out num1)) // Cambiamos los datos a double
            {
                operacion = "-";
                SalidaTextBox.Text += "-"; 
                valor2 = "";
                activado = true; 
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");//En caso de no haber un numero enseña este mensaje de error
            }
        }

        private void MultiplButton_Click(object sender, EventArgs e)
        {
            // Cambiamos de int.TryParse a double.TryParse
            if (double.TryParse(valor2, out num1))
            {
                operacion = "*";
                SalidaTextBox.Text += "*";
                valor2 = "";
                activado = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");//En caso de no haber un numero enseña este mensaje de error
            }
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(valor2, out num1)) 
            {
                operacion = "/";
                SalidaTextBox.Text += "/"; 
                valor2 = ""; 
                activado = true; 
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");//En caso de no haber un numero enseña este mensaje de error
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cuadradoButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(valor2, out double numero))//Se cambia el valor a un parse mediante el tryparse
            {
                double resultado = Cuadrado.Calcular(numero);
                SalidaTextBox.Text = resultado.ToString();
                valor2 = ""; 
                activado = false;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");//En caso de no haber un numero enseña este mensaje de error
            }

        }

        private void logButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(valor2, out double numero))//Se cambia el valor a un parse mediante el tryparse
            {
                try
                {
                    double resultado = Logaritmos.CalcularBase10(numero); 
                    SalidaTextBox.Text = resultado.ToString();
                    valor2 = ""; 
                    activado = false;
                }
                catch (ArgumentOutOfRangeException ex)//Se usa un ArgumentOutOfRangeException en caso de haber errores pueda capturar la excepcion 
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");//En caso de ser otro error se va a ver este mensaje
            }
        }


        private void PotenciaButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(valor2, out num1)) // El valor dos con un tryParse se cambia de valor y pasa al num1
            {
                operacion = "^"; 
                SalidaTextBox.Text += "^"; 
                valor2 = ""; 
                activado = true; 
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void raizButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(valor2, out double numero))
            {
                try
                {
                    double resultado = RaizCuadrado.Calcular(numero);
                    SalidaTextBox.Text = resultado.ToString();
                    valor2 = ""; 
                    activado = false;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void FactorialButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(valor2, out int numero))
            {
                try
                {
                    long resultado = Factorial.Calcular(numero);
                    SalidaTextBox.Text = resultado.ToString();
                    valor2 = ""; 
                    activado = false;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.");
            }
        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            // Llamamos al método para borrar el último carácter
            Borrar.BorrarUltimoCaracter(ref valor2, ref SalidaTextBox);
        }

        private void simboloButton_Click(object sender, EventArgs e)
        {
            // Llamamos al método para cambiar el signo
            SignosChange.CambiarSigno(ref valor2, ref SalidaTextBox);
        }

    }
}
    