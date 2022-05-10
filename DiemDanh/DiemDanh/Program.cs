using System;

namespace DiemDanh
{
    class Program
    {
        public static void Main()
        {

            int[] arr160 = new int[100];
            int i160, mx160, mn160, n160;


            Console.Write("\nTim phan tu lon nhat, phan tu nho nhat trong mang trong C#:\n");
            Console.Write("-----------------------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n160 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i160 = 0; i160 < n160; i160++)
            {
                Console.Write("Phan tu - {0}: ", i160);
                arr160[i160] = Convert.ToInt32(Console.ReadLine());
            }


            mx160 = arr160[0];
            mn160 = arr160[0];

            for (i160 = 1; i160 < n160; i160++)
            {
                if (arr160[i160] > mx160)
                {
                    mx160 = arr160[i160];
                }


                if (arr160[i160] < mn160)
                {
                    mn160 = arr160[i160];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", mx160);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", mn160);

            Console.ReadKey();
        }
    }
}
