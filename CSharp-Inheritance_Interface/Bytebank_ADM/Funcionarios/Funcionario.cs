using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public static int quantidadeFuncionarios { get; private set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Salario = salario;
            quantidadeFuncionarios += 1;
        }

        public virtual double Bonificacao()
        {
            return this.Salario * 0.1;
        }
    }
}
