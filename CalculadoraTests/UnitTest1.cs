using Calculadora.Services;

namespace CalculadoraTests;

public class UnitTest1
{
    [Theory]
    [InlineData(3, 1, 4)]
    [InlineData(10, 4, 14)]
    [InlineData(900, 129, 1029)]
    public void TestSomar(int num1, int num2, int resultadoEsperado)
    {
        var calculadora = new CalculadoraOperacoes();
        int resultado = calculadora.Somar(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(3, 1, 2)]
    [InlineData(10, 4, 6)]
    [InlineData(900, 129, 771)]
    public void TestSubtrair(int num1, int num2, int resultadoEsperado)
    {
        var calculadora = new CalculadoraOperacoes();
        int resultado = calculadora.Subtrair(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(3, 1, 3)]
    [InlineData(10, 4, 40)]
    [InlineData(900, 129, 116100)]
    public void TestMultiplicar(int num1, int num2, int resultadoEsperado)
    {
        var calculadora = new CalculadoraOperacoes();
        int resultado = calculadora.Multiplicar(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(3, 1, 3)]
    [InlineData(10, 4, 2)]
    [InlineData(900, 129, 6)]
    public void TestDividir(int num1, int num2, int resultadoEsperado)
    {
        var calculadora = new CalculadoraOperacoes();
        int resultado = calculadora.Dividir(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void TestDivisaoPorZero()
    {
        var calculadora = new CalculadoraOperacoes();

        Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(3,0));
    }

    [Fact]
    public void TestHistorico()
    {
        var calculadora = new CalculadoraOperacoes();
        
        calculadora.Somar(3,5);
        calculadora.Somar(3,2);
        calculadora.Somar(5,10);
        calculadora.Somar(1,1);

        var resultado = calculadora.GetHistorico();

        Assert.Equal(3, resultado.Count);
    }
}