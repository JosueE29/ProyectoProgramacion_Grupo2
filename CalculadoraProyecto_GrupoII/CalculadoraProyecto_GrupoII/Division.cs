using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProyecto_GrupoII
{
    public class Division
    {
        public static double RealizarDivision(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
                throw new DivideByZeroException();
        }
    }
}
