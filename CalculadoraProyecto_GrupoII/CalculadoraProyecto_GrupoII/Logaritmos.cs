using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProyecto_GrupoII
{
    internal class Logaritmos
    {
      
        public static double CalcularNatural(double numero)
        {
            if (numero <= 0)
            {
                throw new ArgumentOutOfRangeException("El número debe ser mayor que cero para calcular el logaritmo natural.");
            }
            return Math.Log(numero);
        }

   
        public static double CalcularBase10(double numero)
        {
            if (numero <= 0)
            {
                throw new ArgumentOutOfRangeException("El número debe ser mayor que cero para calcular el logaritmo en base 10.");
            }
            return Math.Log10(numero); 
        }
    }
}