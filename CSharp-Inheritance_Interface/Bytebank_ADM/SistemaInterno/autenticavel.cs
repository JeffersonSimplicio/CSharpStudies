using Bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.SistemaInterno
{
    public interface Autenticavel
    {
        public string Senha { get; set; }
        public abstract bool Autenticar(string senha);
    }
}
