using System;

namespace Bai18
{
    class Program
    {
        static void Main(string[] args)
        {
            long h160, t160, n160;
            Console.Write("Nhap so gio: ");
            h160 = long.Parse(Console.ReadLine());

            t160 = h160 / (24 * 7);
            n160 = (h160 % (24 * 7)) / 24;
            h160 = (h160 % (24 * 7)) % 24;

            Console.WriteLine($"{t160} tuan, {n160} ngay, {h160} gio");
            Console.ReadKey();
        }
    }
}
