using Estacionamento.Modelos;

namespace Estacionamento_Teste
{
    public class VeiculoTestes
    {
        [Fact]
        [Trait("Funcionalidade", "Acelerar")]
        public void AcelerarTeste()
        {
            Veiculo carro = new Veiculo();
            carro.Acelerar(10);
            Assert.Equal(100, carro.VelocidadeAtual);
        }

        [Fact]
        [Trait("Funcionalidade", "Freiar")]
        public void FreiaTeste()
        {
            Veiculo carro = new Veiculo();
            carro.Frear(10);
            Assert.Equal(-150, carro.VelocidadeAtual);
        }

        [Fact(Skip = "Teste não implementado")]
        public void NomeProprietarioTeste()
        {
        }
    }
}