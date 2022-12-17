using System;

class URI
{
    public static void Main(string[] args)
    {
        int valor = int.Parse(Console.ReadLine());
        int cem = valor / 100;
        int resto = valor % 100;
        int cinquenta = resto / 50;
        int vinte = (resto % 50) / 20;
        int dez = ((resto % 50) % 20) / 10;
        int cinco = (((resto % 50) % 20) % 10) / 5;
        int dois = ((((resto % 50) % 20) % 10) % 5) / 2;
        int um = (((((resto % 50) % 20) % 10) % 5) % 2) / 1;

        Console.WriteLine($"{cem} nota (s) de R$ 100,00");
        Console.WriteLine($"{cinquenta} nota (s) de R$ 50,00");
        Console.WriteLine($"{vinte} nota (s) de R$ 20,00");
        Console.WriteLine($"{dez} nota (s) de R$ 10,00");
        Console.WriteLine($"{cinco} nota (s) de R$ 5,00");
        Console.WriteLine($"{dois} nota (s) de R$ 2,00");
        Console.WriteLine($"{um} nota (s) de R$ 1,00");
        Console.Read();
    }
}