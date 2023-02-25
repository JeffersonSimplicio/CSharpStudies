using Bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Diretor : Autenticavel
    {
        private static double _salarioPadrao = 5000;
        public Diretor(string nome, string cpf, string senha) : base(nome, cpf, _salarioPadrao, senha)
        {
        }
        //base - Equivalente ao super

        public override double Bonificacao()
        {
            return this.Salario * 0.5;
        }

        public override void AumentoSalario()
        {
            this.Salario *= 1.15;
        }

        public override bool Autenticar(string senha)
        {
            return senha == this.Senha;
        }
    }
}
