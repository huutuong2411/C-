using System;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1160, b1160, c1160, a2160, b2160, c2160, dx160, dy160, d160, x160, y160;
            Console.Write("Nhap a1, b1, c1: ");
            a1160 = double.Parse(Console.ReadLine());
            b1160 = double.Parse(Console.ReadLine());
            c1160 = double.Parse(Console.ReadLine());

            Console.Write("Nhap a2, b2, c2: ");
            a2160 = double.Parse(Console.ReadLine());
            b2160 = double.Parse(Console.ReadLine());
            c2160 = double.Parse(Console.ReadLine());
    
            d160 = (a1160 * b2160 - a2160 * b1160);
            dx160 = (c1160 * b2160 - c2160 * b1160);
            dy160 = (a1160 * c2160 - a2160 * c1160);
            
            if (d160 == 0)
            {
                if (dx160 + dy160 == 0)
                    Console.WriteLine("He phuong trinh co vo so nghiem");
                else
                    Console.WriteLine("He phuong trinh vo nghiem");
            }
            else
            {
                x160 = dx160 / d160;
                y160 = dy160 / d160;
                Console.WriteLine($"He phuong trinh co nghiem (x, y) = ( {x160} , {y160} )");
            }    
        }
    }
}
