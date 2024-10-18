using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProyecto_GrupoII
{
    public class SignosChange
    {
        public static void CambiarSigno(ref string valor, ref TextBox salidaTextBox)
        {
            if (!string.IsNullOrEmpty(valor))
            {
                double numero = double.Parse(valor);
                numero = -numero;
                valor = numero.ToString();
                salidaTextBox.Text = valor;
            }
        }
    }
}
