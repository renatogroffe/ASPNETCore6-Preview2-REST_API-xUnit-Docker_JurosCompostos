using Xunit;

namespace APIFinancas.Testes
{
    public class TestesCalculoFinanceiro
    {
        [Theory]
        [InlineData(10000, 12, 2, 12682.42)]
        [InlineData(11937.28, 24, 4, 30598.88)]
        [InlineData(15000, 36, 6, 122208.78)]
        [InlineData(10000, 2, 2, 10404)]
        [InlineData(20000, 36, 6, 162945.04)]
        [InlineData(25000, 48, 6, 409846.79)]
        [InlineData(30000, 3, 3, 32781.81)]
        public void TestarJurosCompostos(
            double valorEmprestimo, int numMeses, double percTaxa,
            double valorEsperado)
        {
            double valorCalculado = CalculoFinanceiro
                .CalcularValorComJurosCompostos(
                    valorEmprestimo, numMeses, percTaxa);

            Assert.Equal(valorEsperado, valorCalculado);
        }
    }
}
