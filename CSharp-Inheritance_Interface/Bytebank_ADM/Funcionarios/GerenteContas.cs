using Bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class GerenteContas : Funcionario, Autenticavel
    {
        readonly static double _salarioPadrao = 4000;
        public string Senha { get; set; }

        public GerenteContas(string nome, string cpf, string senha) : base(nome, cpf, _salarioPadrao)
        {
            this.Senha = senha;
        }
        //base - Equivalente ao super

        public override double Bonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentoSalario()
        {
            this.Salario *= 1.05;
        }

        public bool Autenticar(string senha)
        {
            return senha == this.Senha;
        }
    }
}
