﻿using System;

class URI
{
    static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        int PROD = A * B;

        //Console.WriteLine($"PROD = {PROD}");
        Console.WriteLine("PROD = {0}", PROD);

    }
}