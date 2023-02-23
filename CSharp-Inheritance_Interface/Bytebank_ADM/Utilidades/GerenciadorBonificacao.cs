using Bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Utilidades
{
    public class GerenciadorBonificacao
    {
        public double TotalBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            TotalBonificacao += funcionario.Bonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            TotalBonificacao += diretor.Bonificacao();
        }
    }
}
