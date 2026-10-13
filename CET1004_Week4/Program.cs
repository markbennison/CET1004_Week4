namespace CET1004_Week4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int menuOption = 0;

			do
			{
				Console.Clear();
				menuOption = Menus.GetMainMenuOption();

				switch (menuOption)
				{
					case 1:
						Exercise1();
						break;
					case 4:
						Exercise4();
						break;
				}
			} while (menuOption > 0);
		}
		static void Exercise1()
		{
			double num1, num2, sum;

			Console.WriteLine("Exercise 1: Add two numbers");
			Console.WriteLine("Enter the first number: ");
			num1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter the second number: ");
			num2 = Convert.ToDouble(Console.ReadLine());

			sum = AddNumbers(num1, num2);
			Console.WriteLine("The total = {0}", sum);
			Console.ReadKey();

		}

		static void Exercise4()
		{
			int iBatteryAmount = 50;
			Console.WriteLine("Battery level is: {0}%", iBatteryAmount);
			char input;

			do
			{
				Console.WriteLine("Would you like to [c]harge or [u]se the battery?");
				input = Console.ReadKey().KeyChar;

				switch (input)
				{
					case 'c':
						Console.Write("\nEnter how much to charge: ");
						int chargeAmount = Convert.ToInt32(Console.ReadLine());
						ChargeBattery(ref iBatteryAmount, chargeAmount);
						break;
					case 'u':
						Console.Write("\nEnter how much battery to use (e.g. 10 or 20): ");
						int useAmount = Convert.ToInt32(Console.ReadLine());
						UseBattery(ref iBatteryAmount, useAmount);
						break;
					default:
						Console.WriteLine("\nInvalid input.");
						break;
				}

				Console.Clear();
				Console.WriteLine("\n\nBattery level is: {0}%", iBatteryAmount);
			} while (input != '0');
		}

		static void ChargeBattery(ref int batteryLevel, int chargeAmount)
		{
			batteryLevel += chargeAmount;
			if(batteryLevel > 100)
			{
				batteryLevel = 100;
			}

			Console.WriteLine("Battery level is: {0}%", batteryLevel);
		}

		static void UseBattery(ref int batteryLevel, int useAmount)
		{
			batteryLevel -= useAmount;
			if (batteryLevel < 0)
			{
				batteryLevel = 0;
			}

			Console.WriteLine("Battery level is: {0}%", batteryLevel);

		}

		static double AddNumbers(double a, double b)
		{
			return a + b;
		}
	}
}
