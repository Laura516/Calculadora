using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.clases
{
    class Porcentaje
    {
        public double porcentaje(string proceso,double N1, double N2)
        {
            
            double result = 0;

            switch (proceso)
            {
                case "+":
                    result = N1 + ((N1 * N2) / 100);
                    break;
                case "-":
                    result = N1 - ((N1 * N2) / 100);
                    break;
                case "/":
                    result = N1 / ((N1 * N2) / 100);
                    break;
                case "*":
                    result = N1 * ((N1 * N2) / 100);
                    break;
            }
                
           

            return result;
        }
    }
}
