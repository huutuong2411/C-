using System;

namespace Bai31
{
    class Program
    {
        static void Main(string[] args)
        {
            long i, j;
            Console.WriteLine("Bang cuu chuong\n");
            for (i = 1; i <= 10; ++i)
            {
                for (j = 2; j <= 9; ++j)
                    Console.WriteLine($"| {i} * {j} = {i*j} |");
                Console.WriteLine("\t");
            }
            Console.ReadKey();

        }
    }
}
