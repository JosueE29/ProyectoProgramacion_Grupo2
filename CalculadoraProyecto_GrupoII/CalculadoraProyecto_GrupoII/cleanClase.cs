using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProyecto_GrupoII
{
    public class cleanClase
    {
        public void Limpiar(ref double num1, ref double num2, ref string valor2, ref TextBox salidaTextBox, ref bool activado)
        {
            num1 = 0;
            num2 = 0;
            valor2 = "";
            salidaTextBox.Text = "";
            activado = false;
        }
    }
}



