using System;

class URI
{

    static void Main(string[] args)
    {
        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;
        for (int i = 0; i < 5; i++)
        {
            double number = double.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                pares++;
            }
            if (number > 0)
            {
                positivos++;
            }

            if (number % 2 > 0)
            {
                impares++;

            }
            if (number % 2 < 0)
            {
                impares++;

            }
            if (number < 0)
            {
                negativos++;
            }

        }
        Console.WriteLine($"{pares} valor(es) par(es)");
        Console.WriteLine($"{impares} valor(es) impar(es)");
        Console.WriteLine($"{positivos} valor(es) positivo(s)");
        Console.WriteLine($"{negativos} valor(es) negativo(s)");
    }
}
