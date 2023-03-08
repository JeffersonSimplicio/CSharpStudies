using Bytebank.Contas;
using Bytebank.Clientes;
using Bytebank.Exceptions;

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
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
}