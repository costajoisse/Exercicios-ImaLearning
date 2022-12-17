using System;
class URI
{
    public static void Main(string[] args)
    {
        string[] linha = Console.ReadLine().Split(' ');

        double a = double.Parse(linha[0]);
        double b = double.Parse(linha[1]);
        double c = double.Parse(linha[2]);

        double delta = (Math.Pow(b,2)) - (4*a*c);
        double raiz1 = (-b + (Math.Sqrt(delta)))/(2*a);
        double raiz2 = (-b - (Math.Sqrt(delta)))/(2*a);


        if (a != 0 && delta > 0)
        {
            Console.WriteLine($"R1 = {raiz1:F5}");
            Console.WriteLine($"R2 = {raiz2:F5}");
            Console.Read();
        }
        else
        {
            Console.WriteLine("Impossivel calcular");
            Console.Read();
        }
    }
}