using Bytebank;
ContaCorrente contaJefferson =  new ContaCorrente(
    "Jefferson Simplicio",
    "1010-1",
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
contaJefferson.Depositar(100);
Console.WriteLine("saldo pos-deposito: " + contaJefferson.saldo);
Console.WriteLine();
Console.WriteLine("saldo pre-saque: " + contaJefferson.saldo);
bool check = contaJefferson.Sacar(100);
string response = check ? "Saque bem sucedido" : "Não possui saldo suficiente";
Console.WriteLine(response);
Console.WriteLine("saldo pos-saque: " + contaJefferson.saldo);
Console.WriteLine();
ContaCorrente contaAna = new ContaCorrente(
    "Ana Leticia",
    "1010-1",
    1,
    250
);
Console.WriteLine("saldo pre-transferencia - Ana: " + contaAna.saldo);
Console.WriteLine("saldo pre-transferencia - Jeffeson: " + contaJefferson.saldo);
bool check2 = contaAna.Transferir(25, contaJefferson);
string response2 = check2 ? "Transferencia bem sucedida" : "Não possui saldo suficiente";
Console.WriteLine(response2);
Console.WriteLine("saldo pos-transferencia - Ana: " + contaAna.saldo);
Console.WriteLine("saldo pos-transferencia - Jeffeson: " + contaJefferson.saldo);
