using System;
class URI
{

    static void Main(string[] args)
    {

        string[] valores = Console.ReadLine().Split(' ');
        double a = double.Parse(valores[0]);
        double b = double.Parse(valores[1]);
        double c = double.Parse(valores[2]);

        double perimetro = a + b + c;
        double area = (a + b) * c / 2;
        if (a < (b + c) && c < (a + b) && b < (a + c))
        {
            Console.WriteLine($"Perimetro = {perimetro:F1}");
        }
        else
        {
            Console.WriteLine($"Area = {area:F1}");
        }
    }

}