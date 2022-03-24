using System;

namespace _153501_Lebetsky
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a / b;
            Console.WriteLine("a / b = {0}", c);
        }
    }
}
