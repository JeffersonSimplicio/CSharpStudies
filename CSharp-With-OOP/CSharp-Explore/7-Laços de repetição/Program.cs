class Loops
{
    static void Main(string[] args)
    {
        Console.WriteLine("While - Do While");
        //double investimento = Convert.ToDouble(Console.ReadLine());
        //int meses = Convert.ToInt32(Console.ReadLine());

        // While primeiro verifica, depois executa
        Console.WriteLine("- While");
        double investimento = 1000;
        int meses = 10;
        int controle = 0;
        while (controle < meses) // condiçao de parada
        {
            controle++;
            investimento *= 1.05;
            Console.WriteLine(investimento);
        }
        Console.WriteLine(investimento);

        // Do primeiro executa depois verifica
        Console.WriteLine("- Do While");
        investimento = 1000;
        meses = 10;
        controle = 0;
        do
        {
            controle++;
            investimento *= 1.05;
            Console.WriteLine(investimento);
        } while (controle < meses);
        Console.WriteLine(investimento);

        Console.WriteLine("For - Foreach");

        Console.WriteLine("- For");

        for (int i = 0; i < 5; i++)//inicio/ fim/ passo
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("- Foreach");

        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }
        //Dscomente o trecho a baixo caso execute o arquivo "buildado"
        //Console.WriteLine("Precione Enter para finalizar...");
        //Console.readline();
    }
}