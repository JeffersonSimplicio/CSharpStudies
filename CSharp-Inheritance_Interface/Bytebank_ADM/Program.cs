using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.Utilidades;

Funcionario pedro = new Funcionario("Pedro", "12345678901", 1234.56);
Console.WriteLine(
    string.Format(
        "{0}: salário de R${1:N}; bonificação de R${2:N}", pedro.Nome, pedro.Salario, pedro.Bonificacao()
    )
);

Diretor roberta = new Diretor("Roberta", "98765432101");
Console.WriteLine(
    string.Format(
        "{0}: salário de R${1:N}; bonificação de R${2:N}", roberta.Nome, roberta.Salario, roberta.Bonificacao()
    )
);

Console.WriteLine("Total de funcionaios: " + Funcionario.quantidadeFuncionarios);

GerenciadorBonificacao bonificacao = new GerenciadorBonificacao();
bonificacao.Registrar(roberta);
bonificacao.Registrar(pedro);
Console.WriteLine(string.Format("Total de bonificação: R${0:N}", bonificacao.TotalBonificacao));
