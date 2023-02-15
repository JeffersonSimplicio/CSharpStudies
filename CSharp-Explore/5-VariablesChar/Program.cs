class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Estuando variaveis do tipo 'char'");
        // Armazenão apenas um caracter
     
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

        Console.WriteLine("Estuando variaveis do tipo 'string'");

        string frase = "Estudando varios tipos de C#";
        Console.WriteLine(frase);

        string cursos = @"
Devo estudar:
 - C#
 - Java
 - Typescript(aprofundar)
 - Python(aprofundar)
 - Etc.";
        Console.WriteLine(cursos);

        //Dscomente o trecho a baixo caso execute o arquivo "buildado"
        //Console.WriteLine("Precione Enter para finalizar...");
        //Console.readline();
    }
}