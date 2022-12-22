using System;

namespace perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Program of the Perfect Numbers ##");
            Console.Write("\n");

            Console.Write("Enter the First Number : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.Write("Enter the End Number : ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine("The Perfect Number :");
            Console.Write("\n");

            int r, i;

            for (r = n1; r <= n2; r++)
            {
                int sum = 0;
                for (i = 1; i < r; i++)
                {
                    if (r % i == 0)
                    {
                        sum = sum + i;
                    }
                        
                }
                if (sum == r)
                {
                    
                    Console.WriteLine(r);
                    Console.Write("\n");
                }
                    
            }

            Console.ReadKey();

        }
    }
}
