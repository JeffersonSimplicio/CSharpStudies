using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.SistemaInterno;
using Bytebank_ADM.Utilidades;

#region
//Funcionario pedro = new Funcionario("Pedro", "12345678901", 1234.56);
//Log.Funcionario(pedro);

//Diretor roberta = new Diretor("Roberta", "98765432101");
//Log.Funcionario(roberta);

//Console.WriteLine("Total de funcionaios: " + Funcionario.quantidadeFuncionarios);

//Bonificacao bonificacao = new Bonificacao();
//bonificacao.Registrar(roberta);
//bonificacao.Registrar(pedro);
//Console.WriteLine(string.Format("Total de bonificação: R${0:N}", bonificacao.TotalBonificacao));
#endregion

#region "Funcionarios"
Diretor roberta = new Diretor("Roberta Sousa", "0001", "1234");
Log.Funcionario(roberta);

Designer paulo = new Designer("Paulo Martiz", "0002");
Log.Funcionario(paulo);

GerenteContas fernanda = new GerenteContas("Fernanda Vasconcelos", "0003", "4321");
Log.Funcionario(fernanda);

Auxiliar pedro = new Auxiliar("Pedro Martinels", "0004");
Log.Funcionario(pedro);
#endregion

void CalculoBonificação()
{
    Console.WriteLine("Total de funcionaios: " + Funcionario.quantidadeFuncionarios);

    Bonificacao bonificacao = new Bonificacao();
    bonificacao.Registrar(roberta);
    bonificacao.Registrar(paulo);
    bonificacao.Registrar(fernanda);
    bonificacao.Registrar(pedro);
    Console.WriteLine(string.Format("Total de bonificação: R${0:N}", bonificacao.TotalBonificacao));
}

void UsarSistema()
{
    Sistema sistema = new Sistema();

    sistema.Login(roberta, "1234");
    sistema.Login(fernanda, "5678");
}

CalculoBonificação();
UsarSistema();
