using System;

class URI
{

    static void Main(string[] args)
    {

        string name = Convert.ToString(Console.ReadLine());
        double fixo = double.Parse(Console.ReadLine());
        double vendas = double.Parse(Console.ReadLine());
        double salario = fixo + (0.15 * vendas) ;
        Console.WriteLine($"TOTAL = R$ {salario:F2}");
          }

}