using Bytebank.Contas;
using Bytebank.Clientes;
 

try
{
    Titular Iasmin = new Titular("Iasmin Ferreira", "12345678910");
    ContaCorrente conta1 = new ContaCorrente(0, "1234-X", Iasmin);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro: " + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.Message);
}
