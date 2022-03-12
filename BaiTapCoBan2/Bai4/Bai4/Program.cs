using System;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a160, b160, c160, tg160;
            Console.Write("Nhap 3 so a, b, c = ");
            a160 = double.Parse(Console.ReadLine());
            b160 = double.Parse(Console.ReadLine());
            c160 = double.Parse(Console.ReadLine());
            /* a < b thì hoán chuyển, vậy a  b */
            if (a160 < b160) { tg160 = a160; a160 = b160; b160 = tg160; }
            /* a < c thì hoán chuyển, vậy a  c, kết quả a lớn nhất */
            if (a160 < c160) { tg160 = a160; a160 = c160; c160 = tg160; }
            /* b < c thì hoán chuyển, vậy b  c, kết quả c nhỏ nhất */
            if (b160 < c160) { tg160 = b160; b160 = c160; c160 = tg160; }
            Console.WriteLine($"Tang dan: {c160} {b160} {a160}");
            Console.ReadKey();
        }
    }
}
