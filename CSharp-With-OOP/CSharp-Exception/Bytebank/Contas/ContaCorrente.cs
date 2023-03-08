using Bytebank.Clientes;
using Bytebank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Contas
{
    public class ContaCorrente
    {
        public ContaCorrente(int numero_agencia, string numero_conta, Titular cliente)
        {
            if (numero_agencia <= 0)
            {
                throw new ArgumentException("Número de agência menor ou igual a zero!", nameof(numero_agencia));
            }
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            this.Cliente = cliente;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

        }

        public static int TotalDeContasCriadas { get; private set; }
        public static float TaxaOperacao { get; private set; }

        public string Conta { get; set; }
        public Titular Cliente { get; set; }
        private int _numero_agencia;
        public int Numero_agencia
        {
            get { return this._numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    this._numero_agencia = value;
                }
            }
        }

        private double _saldo = 100;
        public double GetSaldo()
        {
            return this._saldo;
        }
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= this._saldo)
            {
                this._saldo -= valor;
                return;
            }
            throw new SaldoInsuficienteException();
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            Sacar(valor);
            destino.Depositar(valor);
            return true;
        }

        public void SetSaldo(double valor)
        {
            if (valor > 0)
            {
                this._saldo = valor;
            }
        }
    }
}
