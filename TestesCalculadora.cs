namespace TestCalculadora
{
    public class CalculadoraTeste
    {

        [Theory]
        [InlineData(4, 6, 10)] // 4 + 6 = 10
        [InlineData(10, 3, 13)] // 10 + 3 = 13
        [InlineData(7, 10, 17)] // 7 + 10 = 17
        [InlineData(25, 5, 30)] // 25 + 5 = 30
        public void ValidarOperacoesComTheory(int a, int b, int resultadoEsperado)
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultadoSoma = calculadora.Somar(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoSoma);
        }


        [Fact]
        public void SomaDoisNumeros()
        {
            // Arrange

            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Somar(3, 5);

            // Assert
            Assert.Equal(8, resultado);

        }


        [Fact]
        public void SubtrairDoisNumeros()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Subtrair(8, 3);

            // Assert
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void MultiplicarDoisNumeros()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Multiplicar(3, 8);

            // Assert
            Assert.Equal(24, resultado);
        }

        [Fact]
        public void DividirDoisNumeros()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Dividir(10, 2);

            // Assert
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void DividirPorZeroThrowsException()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
        }

    }
}