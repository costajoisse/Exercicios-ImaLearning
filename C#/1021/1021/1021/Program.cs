using System;

class URI
{
    public static void Main(string[] args)
    {
        double valor = double.Parse(Console.ReadLine());
        int nota100 = (int)(valor / 100);
        valor -= 100 * nota100;

        int nota50 = (int)(valor / 50);
        valor -= 50 * nota50;

        int nota20 = (int)(valor / 20);
        valor -= 20 * nota20;

        int nota10 = (int)(valor / 10);
        valor -= 10 * nota10;

        int nota5 = (int)(valor / 5);
        valor -= 5 * nota5;

        int nota2 = (int)(valor / 2);
        valor -= 2 * nota2;

        valor *= 100;

        int moeda100 = (int)(valor / 100);
        valor -= 100 * moeda100;

        int moeda50 = (int)(valor / 50);
        valor -= 50 * moeda50;

        int moeda25 = (int)(valor / 25);
        valor -= 25 * moeda25;

        int moeda10 = (int)(valor / 10);
        valor -= 10 * moeda10;

        int moeda5 = (int)(valor / 5);
        valor -= 5 * moeda5;

        int moeda1 = (int)(valor / 1);
        valor -= 1 * moeda1;

        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
        Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
        Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
        Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
        Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
        Console.WriteLine($"{nota2} nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{moeda100} moeda(s) de R$ 1.00");
        Console.WriteLine($"{moeda50} moeda(s) de R$ 0.50");
        Console.WriteLine($"{moeda25} moeda(s) de R$ 0.25");
        Console.WriteLine($"{moeda10} moeda(s) de R$ 0.10");
        Console.WriteLine($"{moeda5} moeda(s) de R$ 0.05");
        Console.WriteLine($"{moeda1} moeda(s) de R$ 0.01");
    }
}