using System;

class URI
{

    static void Main(string[] args)
    {

        int distancia = int.Parse(Console.ReadLine());
        double combustivel = double.Parse(Console.ReadLine());

        double resultado = distancia / combustivel;


        Console.WriteLine($" {resultado:F3} km/l"); 

    }

}