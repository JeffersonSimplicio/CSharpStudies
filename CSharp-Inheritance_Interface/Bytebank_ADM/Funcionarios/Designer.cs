using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }
        //base - Equivalente ao super

        public override double Bonificacao()
        {
            return this.Salario * 0.17 + base.Bonificacao();
        }

        public override void aumentoSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
