using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        public List<string> historico;
        public Calculadora()
        {
            historico = new List<string>();
        }
        public int Somar(int num1, int num2)
        {
            int soma = num1 + num2;
            SubirNoHistorico(soma, num1, num2, "soma");
            return soma;
        }
        public int Subtrair(int num1, int num2)
        {
            int subtracao = num1 - num2;
            SubirNoHistorico(subtracao, num1, num2, "subtracao");
            return subtracao;
        }
        public int Multiplicar(int num1, int num2)
        {
            int multiplicacao = num1 * num2;
            SubirNoHistorico(multiplicacao, num1, num2, "multiplicacao");
            return multiplicacao;
        }
        public int Dividir(int num1, int num2)
        {
            int divisao = num1 / num2;
            SubirNoHistorico(divisao, num1, num2, "divisao");
            return divisao;
        }

        public List<string> SubirNoHistorico(int result, int num1, int num2, string operacao)
        {
            string _symbol;
            switch(operacao)
            {
                case "soma":
                    _symbol = "+";
                    break;
                case "subtracao":
                    _symbol = "-";
                    break;
                case "multiplicacao":
                    _symbol = "x";
                    break;
                case "divisao":
                    _symbol = "/";
                    break;
                default:
                    _symbol = "?";
                    break;
            }

            string _texto = $"{num1} {_symbol} {num2} = {result}";
            historico.Add(_texto);
            if (historico.Count >= 4)
            {
                historico.RemoveRange(3, 1);
            }
            return historico;
        }
    }
}
