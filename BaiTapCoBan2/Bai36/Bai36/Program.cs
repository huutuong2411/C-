using System;

namespace Bai36
{
    class Program
    {
        static void Main(string[] args)
        {
            long n160, k160, i160, count160;
            Console.WriteLine("Nhap n: ");
            n160 = long.Parse(Console.ReadLine());
            k160 = 2;
            count160 = 0;
            while (count160 < n160)
            { /* vòng lặp kiểm tra k có phải là số nguyên tố */
                for (i160 = 2; i160 * i160 <= k160; ++i160)
                    if (k160 % i160 == 0) break;
                if (i160 * i160 > k160)
                {
                    Console.WriteLine($"{k160}");
                    count160++;
                }
                k160++;
            }
            Console.ReadKey();
        }
    }
}
