using Bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Parceiro
{
    public class ParceiroComercial : IAutenticavel
    {
        public ParceiroComercial(string nome, string senha)
        {
            this.Nome = nome;
            this.Senha = senha;
        }

        public string Senha { get; set; }
        public string Nome { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
