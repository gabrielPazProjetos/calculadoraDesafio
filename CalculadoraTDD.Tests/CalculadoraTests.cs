using System;
using Xunit;
using CalculadoraTDD;

namespace CalculadoraTDD.Tests
{
    public class CalculadoraTests
    {
        private readonly Calculadora _calc;

        public CalculadoraTests()
        {
            _calc = new Calculadora();
        }

        [Fact]
        public void Somar_DeveRetornarResultadoCorreto()
        {
            var resultado = _calc.Somar(10, 5);
            Assert.Equal(15, resultado);
        }

        [Fact]
        public void Subtrair_DeveRetornarResultadoCorreto()
        {
            var resultado = _calc.Subtrair(10, 5);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Multiplicar_DeveRetornarResultadoCorreto()
        {
            var resultado = _calc.Multiplicar(4, 3);
            Assert.Equal(12, resultado);
        }

        [Fact]
        public void Dividir_DeveRetornarResultadoCorreto()
        {
            var resultado = _calc.Dividir(20, 4);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Dividir_PorZero_DeveLancarExcecao()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Dividir(10, 0));
        }

        [Fact]
        public void Historico_DeveConterOperacoesRealizadas()
        {
            _calc.Somar(1, 2);
            _calc.Multiplicar(3, 4);
            var historico = _calc.Historico();

            Assert.Contains("1 + 2 = 3", historico);
            Assert.Contains("3 * 4 = 12", historico);
            Assert.Equal(2, historico.Count);
        }
    }
}
