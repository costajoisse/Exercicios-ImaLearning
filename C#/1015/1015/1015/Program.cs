using System;

class URI
{

    static void Main(string[] args)
    {
        string[] array = Console.ReadLine().Split(' ');
        double x1 = double.Parse(array[0]);
        double y1 = double.Parse(array[1]);
        string[] array1 = Console.ReadLine().Split(' ');
        double x2 = double.Parse(array1[0]);
        double y2 = double.Parse(array1[1]);

        double distancia = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
        distancia = Math.Sqrt(distancia);

        Console.WriteLine($"{distancia:F4}");

    }

}