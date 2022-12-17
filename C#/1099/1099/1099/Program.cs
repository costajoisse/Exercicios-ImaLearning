using System;

class URI
{

    static void Main(string[] args)
    {


        int total;

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {

            string[] entrada = Console.ReadLine().Split(' ');
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);


            total = 0;
            int menor;
            int maior;
            if (x < y)
            {
                menor = x;
                maior = y;
            }
            else
            {
                menor = y;
                maior = x;
            }
            int h;
            for (h = menor + 1; h < maior; h++)
            {
                if (h % 2 != 0)
                    total += h;
            }
            Console.WriteLine(total);

        }

    }


}




