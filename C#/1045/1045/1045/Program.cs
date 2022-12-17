using System;

class URI
{

    static void Main(string[] args)
    {

        string[] valores = Console.ReadLine().Split(' ');

        double a = double.Parse(valores[0]);
        double b = double.Parse(valores[1]);
        double c = double.Parse(valores[2]);
        // para a ser o primeiro
        if (a < b)
        {
            double aux = a;
            a = b;
            b = aux;
        }
        if (a < c)
        {
            double aux = a;
            a = c;
            c = aux;
        }
        // para b ser o primeiro
        if (b < c)
        {
            double aux = b;
            b = c;
            c = aux;
        }
        if (c > a)
        {
            double aux = c;
            c = a;
                c = aux;
        }


        // condições
        if (a >= (b + c))
        {
            Console.WriteLine("NAO FORMA TRIANGULO");

        }
        else if ((a * a) == ((b * b) + (c * c)))
        {
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        else if ((a * a) > (b * b) + ((c * c)))
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        else if ((a * a) < ((b * b) + (c * c)))
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }
        if (a == b && a == c && b == c)
        {
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        else if (a == b || b == c || a == c)
        { Console.WriteLine("TRIANGULO ISOSCELES"); }
    }

}