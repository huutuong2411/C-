using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a160, b160, x160, y160, kq160;
            Console.Write("Nhap toa do diem A  ");
            a160 = double.Parse(Console.ReadLine());
            b160 = double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do diem B  ");
            x160 = double.Parse(Console.ReadLine());
            y160 = double.Parse(Console.ReadLine());
            kq160 = Math.Sqrt((x160 - a160) * (x160 - a160) + (y160 - b160) * (y160 - b160));
            Console.WriteLine($"Khoang cach AB = {kq160}");
            Console.ReadKey();
        }
    }
}
