using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Bytebank.Clientes;

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
namespace Bytebank.Contas
{
    public class ContaCorrente
    {
        public Titular ClienteTitular { get; private set; }
        public string Conta { get; set; }
        //Propriedade alto implementada
        //Util quando não é nesseçario realizar validação
        public int Agencia { get; set; }
        private double saldo;
        public static int qntContasCriadas { get; set; }

        public ContaCorrente(Titular titular, string conta, int agencia)
        {
            this.ClienteTitular = titular;
            this.Conta = conta;
            this.Agencia = agencia;
            qntContasCriadas++;
        }

        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                if (value > 0)
                {
                    this.saldo += value;
                }
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transferir(double valor, ContaCorrente usuario)
        {
            //bool check = usuario.Sacar(valor);
            bool check = Sacar(valor);
            if (check)
            {
                usuario.Depositar(valor);
                return true;
            }
            return false;
        }

        public void ExibirDadosDaConta()
        {
            string log = @"Titular: {0}
Conta: {1}
Agência: {2}
Saldo: {3}
";
            Console.WriteLine(string.Format(log, ClienteTitular.Nome, this.Conta, this.Agencia, this.saldo));
        }
    }
}
