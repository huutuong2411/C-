using System;

namespace baitap
{
    class bai1
    {
        static void Main(string[] args)
        {
            int a160;
            Console.Write("Nhap so a = ");
            a160 = int.Parse(Console.ReadLine());
            if (a160 > 0)
                Console.WriteLine($"{a160} la so nguyen duong");
            if (a160 < 0)
                Console.WriteLine($"{a140} la so nguyen am");
            Console.ReadKey();
        }
    }
}
