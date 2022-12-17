using System;

class URI
{

    static void Main(string[] args)
    {
        string[] Compra1 = Console.ReadLine().Split(' ');
        int cod1 = int.Parse(Compra1[0]);
        int num1 = int.Parse(Compra1[1]);
        double valorUni1 = double.Parse(Compra1[2]);

        double valor1 = num1 * valorUni1;

        string[] Compra2 = Console.ReadLine().Split(' ');
        int cod2 = int.Parse(Compra2[0]);
        int num2 = int.Parse(Compra2[1]);
        double valorUni2 = double.Parse(Compra2[2]);

        double valor2 = num2 * valorUni2;

        double totalcompra = valor1 + valor2;
  

        Console.WriteLine($"VALOR A PAGAR: R$ {totalcompra:F2}");

    }
}