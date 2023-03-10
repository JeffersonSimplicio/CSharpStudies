using Estacionamento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento_Teste
{
    public class PatioTestes
    {
        [Fact(DisplayName = "Testa o faturamento")]
        public void FaturamentoTeste()
        {
            //Arrange
            Patio estacionamento = new Patio();

            Veiculo carro = new Veiculo();
            carro.Proprietario = "Jefferson";
            carro.Placa = "abc-1234";
            carro.Modelo = "Belina";
            carro.Cor = "Branco";

            estacionamento.RegistrarEntradaVeiculo(carro);
            estacionamento.RegistrarSaidaVeiculo("abc-1234");

            //Act
            double faturado = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2, faturado);
        }

        [Theory]
        [InlineData("Carlos Silva", "abc-1234", "Civic", "preto")]
        [InlineData("Vitoria Magno", "xyz-9876", "Corolla", "prata")]
        [InlineData("Clara Fernandes", "qaz-4567", "2008", "azul")]
        public void FaturamentoMultVeiculosTestes(
            string propietario,
            string placa,
            string modelo,
            string cor
        )
        {
            //Arrange
            Patio estacionamento = new Patio();

            Veiculo carro = new Veiculo();
            carro.Proprietario = propietario;
            carro.Placa = placa;
            carro.Modelo = modelo;
            carro.Cor = cor;

            estacionamento.RegistrarEntradaVeiculo(carro);
            estacionamento.RegistrarSaidaVeiculo(placa);

            //Act
            double faturado = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2, faturado);
        }

        [Theory]
        [InlineData("Vitoria Magno", "xyz-9876", "Corolla", "prata")]
        public void BuscaVeiculoTeste(
            string proprietario,
            string placa,
            string modelo,
            string cor
        )
        {
            //Arrange
            Patio estacionamento = new Patio();
            Veiculo carro = new Veiculo();
            carro.Proprietario = proprietario;
            carro.Placa = placa;
            carro.Cor = cor;
            carro.Modelo = modelo;
            estacionamento.RegistrarEntradaVeiculo(carro);

            //Act
            Veiculo result = estacionamento.PesquisaVeiculo(placa);

            //Assert
            Assert.Equal(placa, result.Placa);
        }
    }
}
