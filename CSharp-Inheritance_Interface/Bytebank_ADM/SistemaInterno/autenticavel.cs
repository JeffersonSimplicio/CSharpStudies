using Bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        protected Autenticavel(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario)
        {
            this.Senha = senha;
        }
        public string Senha { get; private set; }
        public abstract bool Autenticar(string senha);

    }
}
