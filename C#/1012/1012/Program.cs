using System;

class URI
{

    static void Main(string[] args)
    {
        double pi = 3.14159;
        string[] array = Console.ReadLine().Split(' ');
        double A = double.Parse(array[0]);
        double B = double.Parse(array[1]);
        double C = double.Parse(array[2]);
        


        double triangulo = A * C / 2;
        double circulo = pi * Math.Pow(C, 2);
        double trapezio = ((A + B) * C) / 2;
        double quadrado = B * B;
        double retangulo = A * B;
        Console.WriteLine($"TRIANGULO: {triangulo:F3}");
        Console.WriteLine($"CIRCULO: {circulo:F3}");
        Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
        Console.WriteLine($"QUADRADO: {quadrado:F3}");
        Console.WriteLine($"RETANGULO: {retangulo:F3}");
    }

}