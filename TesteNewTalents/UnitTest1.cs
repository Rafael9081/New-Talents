using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using New_Talents;

namespace TesteNewTalents
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 4, 5)]
        [InlineData(2, 2, 4)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.somar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(9, 5, 4)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.subtrair(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 5, 10)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(6, 2, 3)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestaDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
                );  
        }

        [Fact]
        public void TestaHistorico()
        {
            Calculadora calc = new Calculadora();

            Assert.NotEmpty(calc.historico());
        }





    }

}