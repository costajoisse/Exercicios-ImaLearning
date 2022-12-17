using System;

class URI
{

    static void Main(string[] args)
    {
        double nota1, nota2, nota3, nota4;
        string[] notas = Console.ReadLine().Split(' ');

        nota1 = double.Parse(notas[0]);
        nota2 = double.Parse(notas[1]);
        nota3 = double.Parse(notas[2]);
        nota4 = double.Parse(notas[3]);

        double media = Math.Truncate((nota1 * 2) + (nota2 * 3) + (nota3 * 4) + (nota4 * 1)) / 10;

        Console.WriteLine($"Media: {media:F1}");

        if (media >= 7)

        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5)
        {

            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            double notaExame = double.Parse(Console.ReadLine());

            Console.WriteLine($"Nota do exame: {notaExame:F1}");
            media = (media + notaExame) / 2;
            media = Math.Round(media, 1);

            if (media >= 5)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine($"Media final: {media:F1}");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine($"Media final: {media:F1}");
            }

        }
    }
}