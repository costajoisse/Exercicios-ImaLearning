using System;

class URI
{

    static void Main(string[] args)
    {
        int horas = int.Parse(Console.ReadLine());
        int velocidade = int.Parse(Console.ReadLine());

        double consumo = horas * velocidade / 12.0;

        Console.WriteLine($"{consumo:F3}");


    }

}