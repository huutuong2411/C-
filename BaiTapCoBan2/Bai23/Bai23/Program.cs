using System;

namespace Bai23
{
    class Program
    {
        static void Main(string[] args)
        {
            long n160, sum160;
            Console.WriteLine("Nhap n: ");
            n160 = long.Parse(Console.ReadLine());
            for (int number = 1; number <= n160; number++)
            {
                sum160 = 0;
                for (int i160 = 1; i160 <= number; i160++)
                    if (number % i160 == 0)
                        sum160 += i160;
                if (sum160 / 2.0 == number)
                    Console.WriteLine($"{number} ");
            }
            Console.ReadKey();
        }
    }
}
