using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProyecto_GrupoII
{
    internal class Borrar
    {
        public static void BorrarUltimoCaracter(ref string valor, ref TextBox salidaTextBox)
        {
            if (valor.Length > 0)//Esto solo sucedera en caso de que el valor ingrsado en el textbox sea mayor a 0
            {
                valor = valor.Substring(0, valor.Length - 1); // con uso del valor.length borramos en este caso solo 1 valor y el ultimo de la cadena substring
                salidaTextBox.Text = salidaTextBox.Text.Substring(0, salidaTextBox.Text.Length - 1); // Por ultimo actualizamos el valor ingresado en el TextBox
            }
        }
    }
}
