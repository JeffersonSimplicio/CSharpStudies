using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        private static double _salarioPadrao = 2000;
        public Auxiliar(string nome, string cpf) : base(nome, cpf, _salarioPadrao)
        {
        }
        //base - Equivalente ao super

        public override double Bonificacao()
        {
            return this.Salario * 0.2 + base.Bonificacao();
        }

        public override void AumentoSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
