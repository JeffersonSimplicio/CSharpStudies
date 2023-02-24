using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.Utilidades;

Funcionario pedro = new Funcionario("Pedro", "12345678901", 1234.56);
Log.Funcionario(pedro);

Diretor roberta = new Diretor("Roberta", "98765432101");
Log.Funcionario(roberta);

Console.WriteLine("Total de funcionaios: " + Funcionario.quantidadeFuncionarios);

GerenciadorBonificacao bonificacao = new GerenciadorBonificacao();
bonificacao.Registrar(roberta);
bonificacao.Registrar(pedro);
Console.WriteLine(string.Format("Total de bonificação: R${0:N}", bonificacao.TotalBonificacao));
