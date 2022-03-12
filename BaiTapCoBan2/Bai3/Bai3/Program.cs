using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            double xC160, yC160, R160, xM160, yM160, d160;
            Console.Write("Nhap toa do tam C  ");
            xC160 = double.Parse(Console.ReadLine());
            yC160 = double.Parse(Console.ReadLine());

            Console.Write("Nhap ban kinh R  ");
            R160 = double.Parse(Console.ReadLine());

            Console.Write("Nhap toa do diem M  ");
            xM160 = double.Parse(Console.ReadLine());
            yM160 = double.Parse(Console.ReadLine());

            d160 = R160 - Math.Sqrt((xM160 - xC160) * (xM160 - xC160) + (yM160 - yC160) * (yM160 - yC160));

            if (d160 > 0)
                Console.WriteLine("M nam trong C()\n");
            else if (d160 < 0)
                Console.WriteLine("M nam ngoai C()\n");
            else 
                Console.WriteLine("M nam tren C()\n");
            Console.ReadKey();
        }
    }
}
