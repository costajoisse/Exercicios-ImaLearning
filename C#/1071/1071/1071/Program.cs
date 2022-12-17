using System;

class URI
{

    static void Main(string[] args)
    {
        int x;
        int y;
        int aux;
        int aux1;
        int total;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x < y)
        {
            aux = x;
            aux1 = y;
        }
        else
        {
            aux = y;
            aux1 = x;
        }
        total = 0;
        for (int i = aux + 1; i < aux1; i++)
        { 
            if (i % 2 != 0)
            {
                total = total + i;
            }

        }
        Console.WriteLine(total);
    }

}
