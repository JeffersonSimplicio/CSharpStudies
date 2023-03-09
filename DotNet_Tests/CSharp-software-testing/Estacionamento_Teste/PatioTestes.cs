using Estacionamento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento_Teste
{
    public class PatioTestes
    {
        [Fact]
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
    }
}
