using Calculadora.Services;

var calculadora = new CalculadoraOperacoes();

int resultadosoma = calculadora.Somar(2, 2);

int resultadosubtracao = calculadora.Subtrair(3, 3);

int resultadomultiplicacao = calculadora.Multiplicar(5, 5);

int resultadodivisao = calculadora.Dividir(5, 3);

Console.WriteLine($"Soma: {resultadosoma}\nSubtração: {resultadosubtracao}\nMultiplicação: {resultadomultiplicacao}\nDivisão: {resultadodivisao}\n");

var historico = calculadora.GetHistorico();

Console.WriteLine("Histórico de Operações: ");
foreach (CalculadoraHistorico operacao in historico)
{
    Console.WriteLine(operacao);
}