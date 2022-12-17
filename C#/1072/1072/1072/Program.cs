using System;

class URI
{

    static void Main(string[] args)
    {
        int x = 0;
        int y = 0;
        int n;

        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int n1;
            n1 = int.Parse(Console.ReadLine());
            if ( n1 >= 10 && n1 <= 20 )
            {
                 x++;
            }
            else
            {
                y++;
            }

        }
        Console.WriteLine($"{x} in");
        Console.WriteLine($"{y} out");

    }

}
