using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a160, b160;
            Console.Write("Nhap dien tich mat cau = ");
            a160 = double.Parse(Console.ReadLine());
            b160 = (4 * 3.14 * Math.Pow(Math.Sqrt(a160 / (4 * 3.14)), 3)) / 3;
            Console.WriteLine($"The tich V = {b160}");
            Console.ReadKey();
        }
    }
}
