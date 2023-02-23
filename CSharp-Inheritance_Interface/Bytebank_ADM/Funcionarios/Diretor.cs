using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Diretor
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Diretor(string nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Salario = salario;
        }

        public double Bonificacao()
        {
            //return String.Format("{0:N}", this.Salario * 0.5);
            return this.Salario * 0.5;
        }
    }
}
