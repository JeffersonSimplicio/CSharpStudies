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

Console.WriteLine(contaJefferson.titular);
Console.WriteLine(contaJefferson.saldo);
contaJefferson.Deposito(100);
Console.WriteLine(contaJefferson.saldo);
