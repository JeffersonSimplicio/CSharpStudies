using Bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Utilidades
{
    public class Log
    {
        static public void Funcionario(Funcionario funcionario)
        {
            Console.WriteLine(
                string.Format(
                    "{0}: salário de R${1:N}; bonificação de R${2:N}",
                    funcionario.Nome,
                    funcionario.Salario,
                    funcionario.Bonificacao()
                )
            );
        }
    }
}
