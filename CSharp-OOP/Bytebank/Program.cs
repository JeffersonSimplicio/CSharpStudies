using Bytebank;
ContaCorrente contaJefferson =  new ContaCorrente(
    "Jefferson Simplicio",
    "1010 - 1",
    1,
    200
);
//contaJefferson.titular = "Jefferson Simplicio";
//contaJefferson.conta = "1010-1";
//contaJefferson.agencia = 1;
//contaJefferson.saldo = 200;

Console.WriteLine("Titular: " + contaJefferson.titular);
Console.WriteLine();
Console.WriteLine("saldo pre-deposito: " + contaJefferson.saldo);
contaJefferson.Deposito(100);
Console.WriteLine("saldo pos-deposito: " + contaJefferson.saldo);
Console.WriteLine();
Console.WriteLine("saldo pre-saque: " + contaJefferson.saldo);
bool check = contaJefferson.Saque(200);
string response = check ? "Saque bem sucedido" : "Não possui saldo suficiente";
Console.WriteLine(response);
Console.WriteLine("saldo pos-saque: " + contaJefferson.saldo);
