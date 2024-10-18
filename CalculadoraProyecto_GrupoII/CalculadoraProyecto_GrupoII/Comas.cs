using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProyecto_GrupoII
{
    internal class Comas
    {
        public static void AgregarComa(ref string valor, ref TextBox salidaTextBox)
        {
            // Si ya hay una coma en el valor, no se agrega otra paar evitar errores
            if (!valor.Contains(","))
            {
                valor += ","; // Agregamos la coma al valor
                salidaTextBox.Text += ","; // Mostramos la coma en el TextBox
            }
        }

        public static double ObtenerDecimal(string valor)
        {
            // Reemplazamos la coma por un punto para convertir a decimal
            if (double.TryParse(valor.Replace(",", "."), out double numeroDecimal))
            {
                return numeroDecimal;
            }
            throw new FormatException("El valor no es un número decimal válido.");
        }
    }
}

