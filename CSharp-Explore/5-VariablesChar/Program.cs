class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Estuando varia veis do tipo 'char'");

        // Observer que o caracter cgar usa aspas simplesm diferente do writeline
        // Aspas duoplas representão texto
        // Aspas simples, o caracter char
        char letra  = 'a';
        Console.WriteLine(letra);

        // C# usa tabela ASCII, logo é possivel usar numero nas represnetações, via casting
        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        //Dscomente o trecho a baixo caso execute o arquivo "buildado"
        //Console.WriteLine("Precione Enter para finalizar...");
        //Console.readline();
    }
}