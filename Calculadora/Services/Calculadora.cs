using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraOperacoes : CalculadoraHistorico
    {
        private List<CalculadoraHistorico> Historico = new List<CalculadoraHistorico>();
        
        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            CadastrarNoHistorico(num1, "+" , num2, resultado);
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            CadastrarNoHistorico(num1, "-" , num2, resultado);
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            CadastrarNoHistorico(num1, "*" , num2, resultado);
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            CadastrarNoHistorico(num1, "/" , num2, resultado);
            return resultado;
        }

        private void CadastrarNoHistorico(int num1, string operacao, int num2, int resultado)
        {
            if (Historico.Count > 2)
            {
                Historico.RemoveAt(2);
                Historico.Insert(0, new CalculadoraHistorico(num1, operacao, num2, resultado));
            }
            else
            {
                Historico.Insert(0, new CalculadoraHistorico(num1, operacao, num2, resultado));
            }
        }

        public List<CalculadoraHistorico> GetHistorico()
        {
            return Historico;
        }
    }
}