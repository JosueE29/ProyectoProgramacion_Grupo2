using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProyecto_GrupoII
{
    public class Factorial
    {
        public static long Calcular(int numero)
        {
            if (numero < 0)
                throw new ArgumentOutOfRangeException("El número debe no debe de ser negativo.");
            if (numero == 0)
                return 1;

            long resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
