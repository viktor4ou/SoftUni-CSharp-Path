namespace Login
{
	using System;

	public class Login
	{
		static void Main()
		{

			string username = Console.ReadLine();
			string reversedUsername = string.Empty;

			for (int i = username.Length - 1; i >= 0; i--)
			{
				reversedUsername += username[i];
			}
			int passwordsAttemptCounter = 0;
			string passwordAttempt = string.Empty;
			while ((passwordAttempt = Console.ReadLine()) != reversedUsername)
			{
				passwordsAttemptCounter++;
				if (passwordsAttemptCounter == 4)
				{
					Console.WriteLine($"User {username} blocked!");
					Environment.Exit(0);
				}

				Console.WriteLine("Incorrect password. Try again.");
			}
			Console.WriteLine($"User {username} logged in.");

		}
	}
}