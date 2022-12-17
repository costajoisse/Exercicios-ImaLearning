using System;
class URI
{

    static void Main(string[] args)
    {

        int positivo = 0;
        double media = 0;
        for (int i = 0; i < 6; i++)
        {
            double number = double.Parse(Console.ReadLine());
            if (number > 0)
            {
                positivo++;
               media += number;
            }

        }
        double mediatotal = media / positivo;
        Console.WriteLine($"{positivo} valores positivos");
        Console.WriteLine($"{mediatotal:F1}");
    }
}

