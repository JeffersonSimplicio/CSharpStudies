using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class GerenteContas : Funcionario
    {
        static double salarioPadrao = 4000;
        public GerenteContas(string nome, string cpf) : base(nome, cpf, salarioPadrao)
        {
        }
        //base - Equivalente ao super

        public override double Bonificacao()
        {
            return this.Salario * 0.25 + base.Bonificacao();
        }

        public override void aumentoSalario()
        {
            this.Salario *= 1.05;
        }
    }
}
