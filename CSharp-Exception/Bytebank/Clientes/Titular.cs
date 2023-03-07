using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Clientes
{
    public class Titular
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public Titular(string nome,
                       string cpf)
        {
            this.Cpf = cpf;
            this.Nome = nome;
        }
    }
}
