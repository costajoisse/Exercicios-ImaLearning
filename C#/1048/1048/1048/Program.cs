using System;

class URI
{

    static void Main(string[] args)
    {
        string[] valor = Console.ReadLine().Split(' ');

        double salario = double.Parse(valor[0]);

        if (salario >= 0 && salario <= 400.00)
        {
            double salarioN = (salario * 0.15) + salario;
            double reajuste = salarioN - salario;

            Console.WriteLine($"Novo salario: {salarioN:F2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
            Console.WriteLine($"Em percentual: 15%");
        }
        else if (salario >= 400.01 && salario <= 800.00)
        {
            double salarioN = (salario * 0.12) + salario;
            double reajuste = salarioN - salario;

            Console.WriteLine($"Novo salario: {salarioN:F2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
            Console.WriteLine($"Em percentual: 12%");
        }
        else if (salario >= 800.01 && salario <= 1200.00)
        {
            double salarioN = (salario * 0.10) + salario;
            double reajuste = salarioN - salario;

            Console.WriteLine($"Novo salario: {salarioN:F2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
            Console.WriteLine($"Em percentual: 10%");
        }
        else if (salario >= 1200.01 && salario <= 2000.00)
        {
            double salarioN = (salario * 0.07) + salario;
            double reajuste = salarioN - salario;

            Console.WriteLine($"Novo salario: {salarioN:F2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
            Console.WriteLine($"Em percentual: 7%");
        }
        else if (salario > 2000.00)
        {
            double salarioN = (salario * 0.04) + salario;
            double reajuste = salarioN - salario;

            Console.WriteLine($"Novo salario: {salarioN:F2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
            Console.WriteLine($"Em percentual: 4%");
        }
    }

}