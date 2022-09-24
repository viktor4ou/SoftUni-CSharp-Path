namespace Vacation
{
	using System;

	public class Vacation
	{
		static void Main(string[] args)
		{
			int peopleCount = int.Parse(Console.ReadLine());
			string typeOfGroup = Console.ReadLine();
			string dayOfWeek = Console.ReadLine();

			double expensesOnePerson = 0;

			double groupExpenses = 0;

			if (typeOfGroup == "Students")
			{
				if (dayOfWeek == "Friday")
				{
					expensesOnePerson = 8.45;
				}
				else if (dayOfWeek == "Saturday")
				{
					expensesOnePerson = 9.80;
				}
				else if (dayOfWeek == "Sunday")
				{
					expensesOnePerson = 10.46;
				}
			}
			else if (typeOfGroup == "Business")
			{
				if (dayOfWeek == "Friday")
				{
					expensesOnePerson = 10.90;
				}
				else if (dayOfWeek == "Saturday")
				{
					expensesOnePerson = 15.60;
				}
				else if (dayOfWeek == "Sunday")
				{
					expensesOnePerson = 16;
				}
			}
			else if (typeOfGroup == "Regular")
			{
				if (dayOfWeek == "Friday")
				{
					expensesOnePerson = 15;
				}
				else if (dayOfWeek == "Saturday")
				{
					expensesOnePerson = 20;
				}
				else if (dayOfWeek == "Sunday")
				{
					expensesOnePerson = 22.50;
				}
			}
			groupExpenses = expensesOnePerson * peopleCount;
			if (typeOfGroup == "Students" && peopleCount >= 30)
			{
				groupExpenses = groupExpenses - (groupExpenses * 0.15);
			}
			else if (typeOfGroup == "Business" && peopleCount >= 100)
			{
				groupExpenses = groupExpenses - (expensesOnePerson * 10);
			}
			else if (typeOfGroup == "Regular" && peopleCount >= 10 && peopleCount <= 20)
			{
				groupExpenses = groupExpenses - (groupExpenses * 0.05);
			}
			Console.WriteLine($"Total price: {groupExpenses:f2}");
		}
	}
}