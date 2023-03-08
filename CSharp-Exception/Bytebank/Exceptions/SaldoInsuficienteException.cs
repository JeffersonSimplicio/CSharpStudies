using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Exceptions
{
    public class SaldoInsuficienteException : Exception
    {
        private static string _mensagem_padrao = "Saldo disponivel insuficiente";
        public SaldoInsuficienteException() : base(_mensagem_padrao)
        {
        }
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {
        }
    }
}
