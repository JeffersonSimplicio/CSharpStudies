class Conficionais
{
    static void Main(string[] args)
    {
        int idade = 17;
        int qntPessoas = 2;

        if (idade >= 18)
        {
            Console.WriteLine("Pode entrar.");
        }
        else
        {
            if (qntPessoas > 0)
            {
                Console.WriteLine("Esta acompanhado pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entar.");
            }
        };

        //Operador ternario
        string response = (idade >= 18) ? "Pode entrar."  : "Não pode entar.";
        Console.WriteLine(response);

        //Descomente o trecho a baixo caso execute o arquivo "buildado"
        //Console.WriteLine("Precione Enter para finalizar...");
        //Console.readline();
    }
}