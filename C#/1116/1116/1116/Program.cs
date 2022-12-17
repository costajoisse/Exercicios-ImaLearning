using System;
using System.Runtime.CompilerServices;

class URI
{

    static void Main(string[] args)
    {

        int testes = int.Parse(Console.ReadLine());

        for (int i = 0; i < testes; i++)
        {

            string[] entrada = Console.ReadLine().Split(' ');
            double primeiro = double.Parse(entrada[0]);
            double segundo = double.Parse(entrada[1]);


            if (segundo == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else if  (primeiro == 0)
            { Console.WriteLine("0.0"); }

            else
            {
                double divisao = primeiro / segundo;

                Console.WriteLine($"{divisao:F1}");

            }

        }
    }
}
