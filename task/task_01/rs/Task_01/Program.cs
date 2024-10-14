using System;

namespace Task_01
{
    class Program
    { static void Main(string[] args)
      {
        Console.Write("Введите число: ");
        double n = Convert.ToDouble(Console.ReadLine());
            n = (Math.Pow(-1,n) * (1 - (n + 1) / (n + 1)));
            Console.WriteLine(n);
      }
    }
}

