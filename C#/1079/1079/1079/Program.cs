using System;

class URI
{

    static void Main(string[] args)
    {

        int n;

        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {

            string[] valores = Console.ReadLine().Split(' ');
            double nota1 = double.Parse(valores[0]);
            double nota2 = double.Parse(valores[1]);
            double nota3 = double.Parse(valores[2]);


            double media = (nota1 / 10 * 2) + (nota2 / 10 * 3) + (nota3 / 10 * 5);

            Console.WriteLine($"{media:F1}");

        }

    }
}