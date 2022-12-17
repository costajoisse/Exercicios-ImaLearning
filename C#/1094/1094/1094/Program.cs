using System;

class URI
{

    static void Main(string[] args)
    {



        double ratos = 0;
        double sapos = 0;
        double coelhos = 0;
        double porcentoRatos = 0;
        double porcentoSapos = 0;
        double porcentoCoelhos = 0;
        double total = 0;

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] cobaias = Console.ReadLine().Split(' ');
            double quantidade = double.Parse(cobaias[0]);
            string tipo = (cobaias[1]);

            if (tipo == "R")
            {
                ratos = ratos + quantidade;
            }
            else if (tipo == "S")
            {
                sapos = sapos + quantidade;
            }
            else if (tipo == "C")
            {
                coelhos = coelhos + quantidade;
            }
            total = ratos + sapos + coelhos;
            porcentoRatos = ratos / total * 100.00;
            porcentoSapos = sapos / total * 100.00;
            porcentoCoelhos = coelhos / total * 100.00;

    }
        Console.WriteLine($"Total: {total} cobaias");
        Console.WriteLine($"Total de coelhos: {coelhos}");
        Console.WriteLine($"Total de ratos: {ratos}");
        Console.WriteLine($"Total de sapos: {sapos}");
        Console.WriteLine($"Percentual de coelhos: {porcentoCoelhos:F2} %");
        Console.WriteLine($"Percentual de ratos: {porcentoRatos:F2} %");
        Console.WriteLine($"Percentual de sapos: {porcentoSapos:F2} %");
    }
}

