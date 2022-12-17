using System;

class URI
{

    static void Main(string[] args)
    {

        int numero = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {

            int resultado = i * numero;

            Console.WriteLine($"{i} x {numero} = {resultado}");
        }
    }

}