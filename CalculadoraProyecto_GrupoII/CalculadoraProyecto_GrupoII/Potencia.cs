using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProyecto_GrupoII
{
    public class Potencia
    {
        public static double Calcular(double baseNumero, double exponente)
        {
            return Math.Pow(baseNumero, exponente);
        }
    }
}
