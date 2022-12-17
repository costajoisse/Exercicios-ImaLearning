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

            if (x == 0 || y == 0)
            {
                break;

            }
            else if (x > 0 && y > 0)
            { Console.WriteLine("primeiro"); }
            else if (x < 0 && y > 0 )
            {
                Console.WriteLine("segundo");

            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("terceiro");

            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("quarto");

            }


        }
    }
}