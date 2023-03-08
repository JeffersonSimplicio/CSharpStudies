class VariablesDouble
{
    static void Main(string[] args)
    {
        double salary = 4000.20;
        Console.WriteLine(7 / 5);
        Console.WriteLine(7.0 / 5.0);
        Console.WriteLine(string.Format("Salario de R$ {0:N} reais", salary)); // 2 casas decimais
        Console.WriteLine(string.Format("Salario de R$ {0:N0} reais", salary)); // 0 casas decimais
        Console.WriteLine(string.Format("Salario de R$ {0:N5} reais", salary)); // 5 casas decimais
        //Dscomente o trecho a baixo caso execute o arquivo "buildado"
        //Console.WriteLine("Precione Enter para finalizar...");
        //Console.readline();
    }
}
