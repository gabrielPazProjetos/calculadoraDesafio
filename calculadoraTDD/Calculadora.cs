using System;
using System.Collections.Generic;

namespace CalculadoraTDD
{
    public class Calculadora
    {
        private List<Operacao> _historico;

        public Calculadora()
        {
            _historico = new List<Operacao>();
        }

        public int Somar(int a, int b)
        {
            int resultado = a + b;
            RegistrarOperacao(a, b, "+", resultado);
            return resultado;
        }

        public int Subtrair(int a, int b)
        {
            int resultado = a - b;
            RegistrarOperacao(a, b, "-", resultado);
            return resultado;
        }

        public int Multiplicar(int a, int b)
        {
            int resultado = a * b;
            RegistrarOperacao(a, b, "*", resultado);
            return resultado;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");

            int resultado = a / b;
            RegistrarOperacao(a, b, "/", resultado);
            return resultado;
        }

        private void RegistrarOperacao(int a, int b, string operador, int resultado)
        {
            _historico.Add(new Operacao
            {
                PrimeiroNumero = a,
                SegundoNumero = b,
                Operador = operador,
                Resultado = resultado
            });
        }

        public List<string> Historico()
        {
            var lista = new List<string>();
            foreach (var op in _historico)
            {
                lista.Add(op.ToString());
            }
            return lista;
        }
    }
}
