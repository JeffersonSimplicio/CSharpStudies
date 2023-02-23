using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.Utilidades;

Funcionario pedro = new Funcionario("Pedro", "12345678901", 1234.56);
Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.Bonificacao());

Diretor roberta = new Diretor("Roberta", "98765432101", 4321.09);
Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.Bonificacao());

GerenciadorBonificacao bonificacao = new GerenciadorBonificacao();
bonificacao.Registrar(roberta);
bonificacao.Registrar(pedro);
Console.WriteLine(bonificacao.TotalBonificacao);
