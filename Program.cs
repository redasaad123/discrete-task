using System;

namespace prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Program of Prime Numbers ##");
            Console.Write("\n");

            Console.Write(" Enter the First Number = ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.Write(" Enter the End Number = ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine(" The Prime Numbers :");
            Console.Write("\n");

            int r, i ,f=0;
            if (n1 >= 1 && n2>n1)
            {
                for (r = 1; r < n2; r++)
                {
                    for (i = 1; i < n2; i++)
                    {
                        if (r % i == 0)
                        {
                            f++;

                        }

                    }
                    if (f == 2)
                    {
                        Console.WriteLine(r);
                        Console.Write("\n");

                    }
                    f = 0;

                }

            }
            else
                Console.WriteLine("Erroe : Must be the first number >= 1 ");


            Console.ReadKey();
        }
    }
}
