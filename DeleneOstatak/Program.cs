using System;

namespace DeleneOstatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c2 = 0;
            int c3 = 0;
            int c5 = 0;
            for(int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0) c2++;
                if (a % 3 == 0) c3++;
                if (a % 5 == 0) c5++;
            }
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c5);
        }
    }
}
