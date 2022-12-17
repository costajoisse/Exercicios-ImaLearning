using System;

class URI
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int horas = N / 3600;
        int resto = N % 3600;
        int minutos = resto / 60;
        int resto1 = resto % 60;
        int segundos = resto1;


        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
}