using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class DateService
    {
        public DateService()
        {
            GetDay(inputString());
            GetDaysSpan(
                inputInt("год"), inputInt("месяц"), inputInt("день"));
        }
        public static DayOfWeek GetDay(string dateString)
        {
            DayOfWeek dayOfWeek;
            string[] dateParts = dateString.Split('.');
            int day, month, year;
            day = Int32.Parse(dateParts[0]);
            month = Int32.Parse(dateParts[1]);
            year = Int32.Parse(dateParts[2]);
            DateTime date = new DateTime(year, month, day);
            dayOfWeek = date.DayOfWeek;
            Console.WriteLine(dayOfWeek);
            return dayOfWeek;
        }
        public static int GetDaysSpan(int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day);
            TimeSpan substractFromNow = DateTime.Now.Subtract(date);
            int daysDifference = substractFromNow.Days;
            Console.WriteLine($"С этой даты прошло {daysDifference} дней");
            return daysDifference;
        }
        static string inputString()
        {
            Console.WriteLine("Введите дату в формате день.месяц.год");
            string dateString = Console.ReadLine();
            return dateString;
        }
        static int inputInt(string variableName)
        {
            Console.WriteLine($"Введите {variableName}");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
    }
}
