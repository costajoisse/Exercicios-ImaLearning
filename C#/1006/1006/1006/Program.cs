using System;

class URI
{

    static void Main(string[] args)
    {

        double valorA = double.Parse(Console.ReadLine());
        double pesoA = 3.5;
        double valorB = double.Parse(Console.ReadLine());
        double pesoB = 7.5;
        double C = (valorA * pesoA) + (valorB * pesoB);
        double MEDIA = C / 11;
        Console.WriteLine($"MEDIA = {MEDIA:F5}");

    }

}