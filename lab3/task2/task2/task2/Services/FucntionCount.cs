using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Services
{
    public class FunctionCount
    {
        static int inputInt(string variableName)
        {
            int number;
            Console.WriteLine($"Введите {variableName}:");
            number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public FunctionCount()
        {
            count(inputInt("z"), inputInt("b"));
        }
        public static string count(int z, int b)
        {
            int xBranch;
            double x;
            if (z < 1)
            {
                x = z / b;
                xBranch = 1;
            } else
            {
                x = Math.Sqrt(Math.Pow(b * z, 3));
                xBranch = 2;
            }
            double y = 0 - Math.PI + Math.Pow(Math.Cos(Math.Pow(x, 3)), 2) + Math.Pow(Math.Sin(Math.Pow(x, 2)), 3);
            string result = $"y = {y}. Вычислиние проходило по {xBranch}й ветке";
            Console.WriteLine(result);
            return result;
        }
    }
}
