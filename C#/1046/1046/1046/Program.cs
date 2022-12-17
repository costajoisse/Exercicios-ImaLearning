using System;

class URI
{

    static void Main(string[] args)
    {

        string[] valores = Console.ReadLine().Split(' ');

        int inicio = int.Parse(valores[0]);
        int fim = int.Parse(valores[1]);

        int dia = 24;

        if (inicio > fim)
        {
            int tempo = dia - inicio + fim;
            Console.WriteLine($"O JOGO DUROU {tempo} HORA(S)");
        }
        else if (fim > inicio)

        {
            int tempo2 = fim - inicio;
            Console.WriteLine($"O JOGO DUROU {tempo2} HORA(S)");
        }
        else
        {
            Console.WriteLine($"O JOGO DUROU 24 HORA(S)");
        }

    }

}