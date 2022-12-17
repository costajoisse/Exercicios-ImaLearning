using System;

class Programa
{
    static void Main(string[] args)
    {
        double R = double.Parse(Console.ReadLine());
        double pi = 3.14159;
        double A = (Math.Pow(R, 3) * pi * (4/3.0));
        Console.WriteLine($"VOLUME = {A:F3}");
    }
}