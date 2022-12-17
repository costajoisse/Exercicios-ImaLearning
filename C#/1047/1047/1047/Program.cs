using System;

class URI
{

    static void Main(string[] args)
    {

        string[] valores = Console.ReadLine().Split(' ');

        int horaInicio = int.Parse(valores[0]);
        int minutoInicio = int.Parse(valores[1]);
        int horaFim = int.Parse(valores[2]);
        int minutoFim = int.Parse(valores[3]);


        if (horaFim <= horaInicio && minutoFim <= minutoInicio)
        {
            horaFim = horaFim + 24;
        }
        else if (minutoFim <= minutoInicio)
        { minutoFim = minutoFim + 60;
            horaFim = horaFim - 1;
        }
        int segundos1 = (horaInicio * 3600) + (minutoInicio * 60);
        int segundos2 = (horaFim * 3600) + (minutoFim * 60);

        int tempo = (segundos2 - segundos1);

        int hora = tempo / 3600;
        int minuto = (tempo - (hora * 3600)) / 60;


        Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {minuto} MINUTO(S)");
    }

}