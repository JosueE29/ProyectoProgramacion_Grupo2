using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProyecto_GrupoII
{
    internal class RaizCuadrado
    {
        public static double Calcular(double numero)
        {
            if (numero < 0)//En caso de que el numero sea menor a 0 dara error gracias al uso de un exception
            {
                throw new ArgumentOutOfRangeException("El numero es negativo.");
            }
            return Math.Sqrt(numero); //Invocamos el Math.sqrt el cual se encarga de usar la raiz cuadrada en el numero digitado
        }
    }
}
