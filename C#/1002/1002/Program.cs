using System;

class Programa
{
    static void Main(string[] args)
    {
        double R = double.Parse(Console.ReadLine());
        double A = (Math.Pow(R, 2) * 3.14159);
        Console.WriteLine($"A={A:F4}");
    }
}