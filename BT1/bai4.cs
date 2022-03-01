using System;

namespace baitap
{
    class bai4
    {
        static void Main(string[] args)
        {

            int a160, b160, c160;
            Console.Write("Nhap canh a: ");
            a160 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap canh b: ");
            b160 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap canh c: ");
            c160 = Convert.ToInt32(Console.ReadLine());

            /* Kiem tra xem tong ba goc co bang 180 do */
            if (a160 <= 0 || b160 <= 0 || c160 <= 0)
                Console.Write("Day khong phai la 3 canh cua tam giac\n");
            else
            {
                    {
                        if (a160 * a160 + b160 * b160 == c160 * c160 || a160 * c160 + c160 * c160 == b160 * b160 || b160 * b160 + c160 * c160 == a160 * c160)
                        {
                            Console.Write("Day la tam giac vuong.\n");
                        }
                        else
                            Console.Write("Day la tam giac thuong.\n");
                    }
                }
            
            Console.ReadKey();
        }
    }
}

