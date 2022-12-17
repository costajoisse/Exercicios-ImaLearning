using System;

class URI
{

    static void Main(string[] args)
    {

        int n;

        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int n1;
            n1 = int.Parse(Console.ReadLine());
            if (n1 == 0)
            {
                Console.WriteLine("NULL");
            }

            if (n1 % 2 == 0)
            {
                if (n1 > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                if (n1 < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
            }

            if (n1 % 2 != 0)
            {
                if (n1 > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }

        }

    }
}
   