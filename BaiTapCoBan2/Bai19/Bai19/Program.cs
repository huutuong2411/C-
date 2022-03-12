using System;

namespace Bai19
{
    class Program
    {
        static void Main(string[] args)
        {
            int h160, m160, s160;
            long time160, hh160, hm160, hs160;
            Console.WriteLine("Nhap gio, phut, giay [1]: ");
            h160 = int.Parse(Console.ReadLine());
            m160 = int.Parse(Console.ReadLine());
            s160 = int.Parse(Console.ReadLine());

            time160 = 3600 * h160 + 60 * m160 + s160;

            Console.WriteLine("Nhap gio, phut, giay [2]: ");
            h160 = int.Parse(Console.ReadLine());
            m160 = int.Parse(Console.ReadLine());
            s160 = int.Parse(Console.ReadLine());

            time160 -= 3600 * h160 + 60 * m160 + s160;
            if (time160 < 0) { 
                time160 = -time160; 
            }

            hh160 = time160 / 3600;
            hm160 = (time160 % 3600) / 60;
            hs160 = (time160 % 3600) % 60;

            Console.WriteLine($"Hieu thoi gian: {hh160} gio, {hm160} phut, {hs160} giay");
            Console.ReadKey();
        }
    }
}
