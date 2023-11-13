using NewTalents;

namespace NewTalents.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void DeveraSomarDoisValoresERetornar10()
        {
            // Arrange
            Calculadora calc = new Calculadora();
            int num1 = 3;
            int num2 = 7;

            // Act
            int resultado = calc.Somar(num1, num2);

            // Assert
            Assert.Equal(10, resultado);
        }
        [Fact]
        public void DeveraSubtrairDoisValoresERetornar10()
        {
            // Arrange
            Calculadora calc = new Calculadora();
            int num1 = 17;
            int num2 = 7;

            // Act
            int resultado = calc.Subtrair(num1, num2);

            // Assert
            Assert.Equal(10, resultado);
        }
        [Fact]
        public void DeveraMultiplicarDoisValoresERetornar10()
        {
            // Arrange
            Calculadora calc = new Calculadora();
            int num1 = 2;
            int num2 = 5;

            // Act
            int resultado = calc.Multiplicar(num1, num2);

            // Assert
            Assert.Equal(10, resultado);
        }
        [Fact]
        public void DeveraDividirDoisValoresERetornar10()
        {
            // Arrange
            Calculadora calc = new Calculadora();
            int num1 = 100;
            int num2 = 10;

            // Act
            int resultado = calc.Dividir(num1, num2);

            // Assert
            Assert.Equal(10, resultado);
        }
        [Fact]
        public void DeveraVerificarDivisaoPorZero()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act and Assert
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }
        [Fact]
        public void TesteHistorico()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            int num1, num2;
            num1 = 1;
            num2 = 2;

            calc.Somar(num1, num2);
            calc.Subtrair(num1, num2);
            calc.Multiplicar(num1, num2);
            calc.Dividir(num1, num2);

            // Act and Assert
            Assert.NotEmpty(calc.historico);
            Assert.Equal(3, calc.historico.Count);
        }
    }
}