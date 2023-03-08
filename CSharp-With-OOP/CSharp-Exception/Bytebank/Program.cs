using Bytebank.Contas;
using Bytebank.Clientes;
using Bytebank.Exceptions;
using ByteBank;

#region
/*
try
{
    Titular Iasmin = new Titular("Iasmin Ferreira", "12345678910");
    ContaCorrente conta1 = new ContaCorrente(100, "1234-X", Iasmin);
    Console.WriteLine(conta1.GetSaldo());
    conta1.Sacar(50);
    Console.WriteLine(conta1.GetSaldo());
    conta1.Sacar(100);
    Console.WriteLine(conta1.GetSaldo());
}
catch (ArgumentException ex)
{
    //Console.WriteLine("Parâmetro com erro: " + ex.ParamName);
    Console.WriteLine($"Parâmetro com erro: {ex.ParamName}"); //Usando interpolação de strings
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
}
*/
#endregion

LeitorDeArquivo lido = new LeitorDeArquivo("conta1.txt");
try
{
    lido.LerProximaLinha();
}
catch (IOException)
{
    Console.WriteLine("Leitura do aquivo interrompida");
}
finally
{
    lido.Dispose();
}

// using é o syntax sugar e faz o papel de try/finally
/*
using(LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}
*/
