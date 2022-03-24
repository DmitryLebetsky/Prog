using System;

namespace task1
{
    public class Program
    {
        public static bool check(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Треугольник равносторонний");
                return true;
            }
            else
            {
                Console.WriteLine("Треугольник не является равносторонним");
                return false;
            }
        }
        static bool isTriangleRight()
        {
            int a, b, c;
            Console.WriteLine("Введите первую сторону: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третью сторону: ");
            c = Convert.ToInt32(Console.ReadLine());
            return check(a, b, c);
        }
        static void Main(string[] args)
        {
            bool shouldContinue = true;
            while (shouldContinue) {
                isTriangleRight();
                Console.WriteLine("Введите 1 если хотите продолжить. Для выхода из программы нажмите любую другую клавишу");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option) {
                    case 1:
                        break;
                    default:
                        shouldContinue = false;
                        break;
                }
            }
        }
    }
}
