using System;
class URI
{

    static void Main(string[] args)
    {
        string[] valor = Console.ReadLine().Split(' ');

        double salario = double.Parse(valor[0]);

        if (salario > 0 && salario <= 2000.00)
        {
            Console.WriteLine("Isento");
        }
        else if (salario > 2000.01 && salario <= 3000.00)
        {
            double resultado = (salario - 2000) * 0.08;
            Console.WriteLine($"R$ {resultado:F2}");
        }
        else if (salario > 3000.01 && salario <= 4500.00)
        {
            double imposto = (salario - 3000) * 0.18 + (1000 * 0.08);
            Console.WriteLine($"R$ {imposto:F2}");
        }
        else if (salario > 4500.01)
        {
            double imposto = (salario - 4500) * 0.28 + (1500 * 0.18) + (1000 * 0.08);
            Console.WriteLine($"R$ {imposto:F2}");
        }

    }

}