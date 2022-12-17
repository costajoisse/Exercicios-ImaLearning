using System;


class URI
{

    static void Main(string[] args)
    {


            int cobaias = 0;
            int coelhos = 0;
            int ratos = 0;
            int sapos = 0;

            int testes = int.Parse(Console.ReadLine());

            for (int i = 0; i < testes; i++)
            {
                string[] input = Console.ReadLine().Split();
                cobaias += int.Parse(input[0]);

                if (string.Compare(input[1], "C") == 0) coelhos += int.Parse(input[0]);

                else if (string.Compare(input[1], "R") == 0) ratos += int.Parse(input[0]);

                else if (string.Compare(input[1], "S") == 0) sapos += int.Parse(input[0]);
            }

            Console.WriteLine($"Total: {cobaias} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {sapos}");
            Console.WriteLine($"Percentual de coelhos: {coelhos / cobaias * 100:F2} %");
            Console.WriteLine($"Percentual de ratos: {ratos / cobaias * 100:F2} %");
            Console.WriteLine($"Percentual de sapos: {(sapos / cobaias) * 100:F2} %");
        }

    }


