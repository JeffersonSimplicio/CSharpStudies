class ConversionOtherTypes
{
    static void Main(string[] args)
    {
        double salary = 4500.56;
        Console.WriteLine(salary);
        int otherSalary = (int)salary; //casting
        Console.WriteLine(otherSalary);

        //int -> 2^32
        //bouble -> 2^64
        //short -> 2^16

        //Tabela completa em:
        //https://www.devmedia.com.br/introducao-a-variaveis-e-constantes-no-csharp/29629
        //Também pode ser encontrada na documentação oficial da linguagem.

        //O long é um tipo de variável de 64 bits, sem ponto flutuante
        long x = 2000000000000000000;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.62f; //Coloca-se o f para que o compilador não reclame da tipoagem
        // A IDE recomenda double
        Console.WriteLine(altura);

        //Dscomente o trecho a baixo caso execute o arquivo "buildado"
        //Console.WriteLine("Precione Enter para finalizar...");
        //Console.readline();
    }
}