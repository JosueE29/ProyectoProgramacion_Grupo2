using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProyecto_GrupoII
{
    namespace CalculadoraProyecto_GrupoII
    {
        public class Calculadora
        {
            private double num1;
            private double num2;
            private string operacion;

            public Calculadora(double num1, double num2, string operacion)
            {
                this.num1 = num1;
                this.num2 = num2;
                this.operacion = operacion;
            }

            public double Calcular()
            {
                switch (operacion)
                {
                    case "+":
                        return num1 + num2;
                    case "-":
                        return num1 - num2;
                    case "*":
                        return num1 * num2;
                    case "/":
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException("No se puede dividir por cero.");
                        }
                        return num1 / num2;
                    default:
                        throw new InvalidOperationException("Operación no válida.");
                }
            }
        }
    }
}

