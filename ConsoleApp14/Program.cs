using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a user Name Please:");
            string temp = Console.ReadLine();
            Console.WriteLine("Times to Repeat:");
            int r = int.Parse(Console.ReadLine());

            for (int i=0;i<r;i++)
            {
                Console.Write(temp);

            }
            Console.WriteLine();

            Console.WriteLine("Times to Repeat:");
            int s = int.Parse(Console.ReadLine());

            for (int j=s; j>0; j--)
            {
                Console.WriteLine();
                for (int i = j; i > 0; i--)
                {
                    Console.Write("*");
                    
                }
            }



            Console.WriteLine();
            Console.WriteLine("Times to Repeat:");
            int t = int.Parse(Console.ReadLine());

            for (int j = 1; j <=t; j++)
            {
                Console.WriteLine();
                for (int i = j; i > 0; i--)
                {
                    Console.Write("*");

                }
            }

            Console.WriteLine();
            Console.WriteLine("Times to Repeat:");
            int v = int.Parse(Console.ReadLine());

            for (int j = v; j >= 0; j--)
            {
                Console.WriteLine();
                for (int i = v - j; i > 0; i--)
                {
                    Console.Write(" ");

                }
                for (int i = 2 * j + 1; i > 0; i--)
                {
                    Console.Write("*");

                }
            }

                Console.WriteLine();
            Console.WriteLine("Times to Repeat:");
            int u = int.Parse(Console.ReadLine());

            for (int j = 0; j <= u; j++)
            {
                Console.WriteLine();
                for (int i = u-j; i > 0; i--)
                {
                    Console.Write(" ");

                }
                for (int i = 2*j+1; i > 0; i--)
                {
                    Console.Write("*");

                }

            }
        }
    }
}
