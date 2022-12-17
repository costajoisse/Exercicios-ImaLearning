using System;

class URI
{

    static void Main(string[] args)
    {

        int N = 0;

        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10000; i++)
            if (i % 2 == 2)
            {
                N ++;
                Console.WriteLine(N);
            }
    }

}
