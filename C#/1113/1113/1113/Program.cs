using System;

class URI
{

    static void Main(string[] args)
    {
        while (true)
        {

            string[] entrada = Console.ReadLine().Split(' ');
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);

            if (x == y)
            {
                break;

            }
            if (x < y)
            { Console.WriteLine("Crescente"); }
            else
            {
                Console.WriteLine("Decrescente");

            }


        }
    }
}