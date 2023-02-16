class Conficionais
{
    static void Main(string[] args)
    {
        Console.WriteLine("if e else(ternario)");

        int idade = 17;
        int qntPessoas = 2;

        if (idade >= 18)
        {
            Console.WriteLine("Pode entrar.");
        }
        else
        {
            if (qntPessoas > 1)
            {
                Console.WriteLine("Esta acompanhado pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entar.");
            }
        };

        //Operador ternario
        string response = (idade >= 18) ? "Pode entrar." : "Não pode entar.";
        Console.WriteLine(response);

        Console.WriteLine("Switch case");

        int opc = 6;

        switch (opc)
        {
            case 1:
                Console.WriteLine("Caso 1");
                break;
            case 2:
                Console.WriteLine("Caso 2");
                break;
            case 3:
                Console.WriteLine("Caso 3");
                break;
            default:
                Console.WriteLine("Nem dos casos satisfez.");
                break;
        }

        //Descomente o trecho a baixo caso execute o arquivo "buildado"
        //Console.WriteLine("Precione Enter para finalizar...");
        //Console.readline();
    }
}