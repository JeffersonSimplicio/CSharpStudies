using Bytebank.Clientes;
using Bytebank.Contas;

Titular clinteJefferson = new Titular(
    "Jefferson Simplicio",
    "123.456.789-10",
    "Web Developer"
);
ContaCorrente contaJefferson = new ContaCorrente(
    clinteJefferson,
    "1010-1",
    1
);
contaJefferson.ExibirDadosDaConta();

Titular clinteAna = new Titular(
    "Ana Leticia",
    "887.654.321-01",
    "Web Developer"
);
ContaCorrente contaAna = new ContaCorrente(
    clinteAna,
    "1011-1",
    1
);

//Console.WriteLine("Titular: " + contaJefferson.titular);
//Console.WriteLine();
//Console.WriteLine("saldo pre-deposito: " + contaJefferson.saldo);
//contaJefferson.Depositar(100);
//Console.WriteLine("saldo pos-deposito: " + contaJefferson.saldo);
//Console.WriteLine();
//Console.WriteLine("saldo pre-saque: " + contaJefferson.saldo);
//bool check = contaJefferson.Sacar(100);
//string response = check ? "Saque bem sucedido" : "Não possui saldo suficiente";
//Console.WriteLine(response);
//Console.WriteLine("saldo pos-saque: " + contaJefferson.saldo);
//Console.WriteLine();
//Console.WriteLine("saldo pre-transferencia - Ana: " + contaAna.saldo);
//Console.WriteLine("saldo pre-transferencia - Jeffeson: " + contaJefferson.saldo);
//bool check2 = contaAna.Transferir(25, contaJefferson);
//string response2 = check2 ? "Transferencia bem sucedida" : "Não possui saldo suficiente";
//Console.WriteLine(response2);
//Console.WriteLine("saldo pos-transferencia - Ana: " + contaAna.saldo);
//Console.WriteLine("saldo pos-transferencia - Jeffeson: " + contaJefferson.saldo);
//contaJefferson.ExibirDadosDaConta();
