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

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transferir(double valor, ContaCorrente usuario)
        {
            //bool check = usuario.Sacar(valor);
            bool check = this.Sacar(valor);
            if (check)
            {
                usuario.Depositar(valor);
                return true;
            }
            return false;
        }
    }
}
