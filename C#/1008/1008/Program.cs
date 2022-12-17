using System;

class URI
{

    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        double s = double.Parse(Console.ReadLine());
        double salario = h * s;
        Console.WriteLine($"NUMBER = {num}");
        Console.WriteLine($"SARALY = U$ {salario:F2}");

    }

}