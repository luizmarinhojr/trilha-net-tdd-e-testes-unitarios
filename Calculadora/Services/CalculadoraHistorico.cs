using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraHistorico
    {
        private string Operations {get; set;}

        public CalculadoraHistorico()
        {
        }

        public CalculadoraHistorico(int num1, string operador, int num2, int resultado)
        {
            Operations = $"{num1} {operador} {num2} = {resultado}";
        }


        public override string ToString()
        {
            return Operations;
        }
    }
}