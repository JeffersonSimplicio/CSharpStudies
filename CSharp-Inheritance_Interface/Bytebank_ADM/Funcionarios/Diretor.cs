﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }
        //Equivalente ao super

        public double Bonificacao()
        {
            //return String.Format("{0:N}", this.Salario * 0.5);
            return this.Salario * 0.5;
        }
    }
}
