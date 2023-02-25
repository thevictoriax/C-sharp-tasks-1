
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;


Task1();
Task2();
Task3();


static void Task1()
{
    string res = "";
    int counter = 0;
    Console.WriteLine("----First task-----");
    Console.Write("Enter a real decimal number between 0 and 1: ");
    double number = double.Parse(Console.ReadLine());
    int intPart = (int)number;
    double fractionalPart = number - intPart;

    if(number>0 && number<1)
    {
        while (fractionalPart != 0 && counter < 12)
        {
            fractionalPart *= 2;
            if (fractionalPart >= 1)
            {
                res += "1";
                fractionalPart -= 1;
                counter++;
            }
            else
            {
                res += "0";
                counter++;
            }
        }
        Console.WriteLine($"{number} in binary system = {res}");
    }

    else
    {
        Console.WriteLine("You have entered incorrect values");
    }
}

static void Task2()
{
    Console.WriteLine("----Second task-----");
    Console.Write("Enter x: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Enter y: ");
    double y = double.Parse(Console.ReadLine());
    Console.Write("Enter z: ");
    double z = double.Parse(Console.ReadLine());

    double a = (Math.Pow(x, 2) / 2) - (Math.Pow(x, 4) / 24) + (Math.Pow(x, 6) / 720);
    double b = Math.Sin(3 * Math.PI / 4) + x * Math.Cos(z) - z * Math.Cos(y) + y * Math.Cos(x);
    double c = 5 * (x * Math.Cos(z) - z * Math.Cos(y) + y * Math.Cos(x));
    double result = Math.Max(a, Math.Min(b, c));

    Console.WriteLine($"max(a, min(b,c)) = {result}");
}

static void Task3()
{
    Console.WriteLine("----Third task-----");
    int[,] matrix = new int[7, 6];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"Enter [{i}][{j}]: ");
            matrix[i, j] = int.Parse(Console.ReadLine());

        }
    }
    int[] b = new int[6];
    
    for (int i = 0; i < matrix.GetLength(1); i++) 
    {
        int counter = 0;
        for (int j = 0; j<matrix.GetLength(0); ++j)
        {
            if (matrix[j, i] > 0)
            {
                counter++;
            }
        }
        b[i] = counter; 
    }
    Console.WriteLine("Vector b: ");
    foreach (int i in b) 
    {
        Console.WriteLine(i);
    }
    Console.WriteLine($"Max element of b vector is: [{Array.IndexOf(b, b.Max())}] {b.Max()}");
    }