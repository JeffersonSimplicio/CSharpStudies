using Bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public abstract class FuncionarioAltenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAltenticavel(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario)
        {
            this.Senha = senha;
        }

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
