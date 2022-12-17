using System;
class URI
{

    static void Main(string[] args)
    {
        int quadrado;
        int x = int.Parse(Console.ReadLine());
        for (int i = 1; i <= x; i++)
        {
            if (i % 2 == 0)
            {

                quadrado = i * i;
                Console.WriteLine($"{i}^2 = {quadrado}");
            }
        }
    }
}
