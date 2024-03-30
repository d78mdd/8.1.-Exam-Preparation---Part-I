using System;

namespace _10.Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numRows = n;
            if (n % 2 == 0)
            {
                numRows--;
            }

            Console.WriteLine(new string('%', n * 2));

            for (int i = 0; i < numRows; i++)
            {
                Console.Write('%');

                bool middle = i == numRows / 2;

                if (middle)
                {
                    Console.Write(new string(' ', n - 2));
                    Console.Write(new string('*', 2));
                    Console.Write(new string(' ', n - 2));
                }
                else
                {
                    Console.Write(new string(' ', n * 2 - 2));
                }


                Console.Write('%');
                Console.WriteLine();
            }

            Console.WriteLine(new string('%', n*2));
        }
    }
}
