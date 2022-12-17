using System;

class URI
{
    public static void Main(string[] args)
    {
        int qntdias = int.Parse(Console.ReadLine());
        int anos = qntdias / 365;
        int resto = qntdias % 365;
        int meses = resto / 30;
        int resto1 = resto % 30;
        int dias = resto1;


        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }
}