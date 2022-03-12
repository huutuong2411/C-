using System;

namespace Bai22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            long n160, i160, count160, sum160;
            Console.WriteLine("Nhap n: ");
            n160 = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhap cac uoc so: ");
            for (count160 = sum160 = 0, i160 = 1; i160 <= n160; ++i160)
                if (n160 % i160 == 0)
                {
                    Console.WriteLine($"{i160}");
                    count160++;
                    sum160 += i160;
                }
            Console.WriteLine($"\nCo {count160} uoc so, tong la: {sum160}\n");

        }
    }
}
