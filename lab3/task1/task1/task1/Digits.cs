using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	using System;

	public class Digits
	{
		public static int inputNumber()
		{
			int number;
			Console.WriteLine("Enter number: ");
			number = Convert.ToInt32(Console.ReadLine());
			return number;
		}
		public Digits()
		{
			Digits.swapDigits(Digits.inputNumber());
		}
		public static int swapDigits(int number)
		{
			int digitsCount = number.ToString().Length;
			if (digitsCount == 2)
            {
				int firstDigit = number / 10;
				int secondDigit = number % 10;
				int swappedNumber = secondDigit * 10 + firstDigit;
				Console.WriteLine($"Swapped number = {swappedNumber}");
				return swappedNumber;
            } else
            {
				Console.WriteLine($"Digits' count != 2. Result: {number}");
				return number;
            }
		}
	}

}
