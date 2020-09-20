using System;

namespace replace
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Please give a number as 1st variable :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please give a number as 2nd variable :");
            b = Convert.ToInt32(Console.ReadLine());
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("The value of 1st variable : " + a);
            Console.WriteLine("The value of 2nd variable : " + b);
            Console.ReadKey();
        }
    }
}
