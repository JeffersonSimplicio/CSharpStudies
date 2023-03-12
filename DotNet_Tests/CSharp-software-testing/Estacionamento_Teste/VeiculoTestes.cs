using Estacionamento.Modelos;
using Estacionamento.Modulos;

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

        [Fact]
        public void DadosVeiculoTeste()
        {
            //Arrange
            Veiculo carro = new Veiculo();
            carro.Proprietario = "Pedro Ferreira";
            carro.Tipo = TipoVeiculo.Automovel;
            carro.Placa = "abc-4321";
            carro.Modelo = "Golf";
            carro.Cor = "Preto";

            //Act
            string dados = carro.ToString();

            //Assert
            Assert.Contains("Tipo do Veículo: Automovel", dados);
        }
    }
}