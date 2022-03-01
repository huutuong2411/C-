using System;

namespace baitap
{
    class bai3

    {
        static void Main(string[] args)
        {
            float a160, b160, c160;
            Console.Write("Nhap canh a: ");
            a160 = float.Parse(Console.ReadLine());

            Console.Write("Nhap canh b: ");
            b160 = float.Parse(Console.ReadLine());

            Console.Write("Nhap canh c: ");
            c160 = float.Parse(Console.ReadLine());

            /* Kiem tra xem tong ba goc co bang 180 do */
            if (a160 <= 0 || b160 <= 0 || c160 <= 0)
                Console.Write("Day khong phai 3 canh cua tam giac\n");
            else
                Console.Write("Day la 3 canh cua tam giac\n");
            Console.ReadKey();

        }
    }
}
