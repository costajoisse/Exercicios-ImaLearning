using System;

class URI
{

    static void Main(string[] args)
    {
        string[] pedido = Console.ReadLine().Split(' ');
        int codigo = int.Parse(pedido[0]);
        int quantidade = int.Parse(pedido[1]);


        if (codigo == 1)

        {
            double total1 = quantidade * 4.00;
            Console.WriteLine($"Total: R$ {total1:f2}");
        }
        else if (codigo == 2)
        {
            double total2 = quantidade * 4.50;
            Console.WriteLine($"Total: R$ {total2:f2}");
        }
        else if (codigo == 3)
        {
            double total3 = quantidade * 5.00;
            Console.WriteLine($"Total: R$ {total3:f2}");
        }
        else if (codigo == 4)
        {
            double total4 = quantidade * 2.00;
            Console.WriteLine($"Total: R$ {total4:f2}");
        }
        else if (codigo == 5)
        {
            double total5 = quantidade * 1.50;
            Console.WriteLine($"Total: R$ {total5:f2}");
        }
    }

}