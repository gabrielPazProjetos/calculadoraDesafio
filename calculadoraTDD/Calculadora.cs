using System;
using System.Collections.Generic;

namespace CalculadoraTDD
{
    public class Calculadora
    {
        private List<string> _historico;

        public Calculadora()
        {
            _historico = new List<string>();
        }

        public int Somar(int a, int b)
        {
            int resultado = a + b;
            _historico.Add($"{a} + {b} = {resultado}");
            return resultado;
        }

        public int Subtrair(int a, int b)
        {
            int resultado = a - b;
            _historico.Add($"{a} - {b} = {resultado}");
            return resultado;
        }

        public int Multiplicar(int a, int b)
        {
            int resultado = a * b;
            _historico.Add($"{a} * {b} = {resultado}");
            return resultado;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");

            int resultado = a / b;
            _historico.Add($"{a} / {b} = {resultado}");
            return resultado;
        }

        public List<string> Historico()
        {
            return _historico;
        }
    }
}
