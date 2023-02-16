using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Bytebank
//{
//    public class ContaCorrente
//    {
//        public string titular;
//        public string conta;
//        public int agencia;
//        public double saldo;
//    }
//}

//Usando "constructor"
namespace Bytebank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int agencia;
        public double saldo;

        public ContaCorrente(string titular, string conta, int agencia, double saldo)
        {
            this.titular = titular;
            this.conta = conta;
            this.agencia = agencia;
            this.saldo = saldo;
        }

        public void Deposito(double valor)
        {
            this.saldo += valor;
        }
    }
}
