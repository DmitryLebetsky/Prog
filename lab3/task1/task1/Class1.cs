using System;

public class Digits
{
	static public inputNumber()
    {
		int number;
		Console.WriteLine("Enter a: ");
		number = Convert.ToInt32(Console.ReadLine());
		return number;
	}
	public Digits()
	{
		Digits.swapDigits(Digits.inputNumber());
	}
	static public swapDigits(int number)
    {
		Console.WriteLine("Получилось {1}", number);
    }
}
