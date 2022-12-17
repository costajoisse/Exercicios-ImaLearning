using System;

class URI
{

    static void Main(string[] args)
    {
     
        int x = int.Parse(Console.ReadLine());
        for (int number = 1; number <= x ; number++)
            if (number % 2 != 0)
            {

                Console.WriteLine($"{number}");
            }
    }

}
