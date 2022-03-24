using System;

namespace task2
{
    public class Program
    {
        public static string check(double x, double y)
        {
            if (y > 0.0 && (x * x + y * y) < 9.0)
            {
                Console.WriteLine("Точка внутри");
                return "Точка внутри";
            }
            else if (((x * x + y * y) == 9.0 && y >= 0.0)
              || (y == 0.0 && x >= -3.0 && x <= 3.0))
            {
                Console.WriteLine("Точка на границе");
                return "Точка на границе";
            }
            else
            {
                Console.WriteLine("Точка снаружи");
                return "Точка снаружи";
            }
        }
        static void isDotInside()
        {
            double x, y;
            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());
            check(x, y);
        }
        static void Main(string[] args)
        {
            bool shouldContinue = true;
            while (shouldContinue)
            {
                isDotInside();
                Console.WriteLine("Введите 1 если хотите продолжить. Для выхода из программы нажмите любую другую клавишу");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
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
