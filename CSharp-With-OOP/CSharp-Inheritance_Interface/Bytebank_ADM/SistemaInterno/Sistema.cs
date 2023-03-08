using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.SistemaInterno
{
    public class Sistema
    {
        public bool Login(IAutenticavel funcionario, string senha)
        {
            if (funcionario.Autenticar(senha))
            {
                Console.WriteLine("Bem vindo ao sitema!");
                return true;
            }
            Console.WriteLine("Senha incorreta!");
            return false;
        }
    }
}
