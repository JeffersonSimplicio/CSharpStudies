using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        static double salarioPadrão = 2000;
        public Auxiliar(string nome, string cpf) : base(nome, cpf, salarioPadrão)
        {
        }
        //base - Equivalente ao super

        public override double Bonificacao()
        {
            return this.Salario * 0.2 + base.Bonificacao();
        }

        public override void aumentoSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
