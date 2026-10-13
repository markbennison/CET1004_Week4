using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CET1004_Week4
{
	internal class Menus
	{
		public static int GetMainMenuOption()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\n\n {0} \n\n", Assembly.GetCallingAssembly().GetName().Name);
			Console.ForegroundColor = ConsoleColor.White;

			Console.WriteLine("(1) Exercise 1");
			Console.WriteLine("(2) Exercise 2");
			Console.WriteLine("(3) Exercise 3");
			Console.WriteLine("(4) Exercise 4");
			Console.WriteLine("(5) Exercise 5");

			Console.WriteLine("(0) Exit");

			int input = Convert.ToInt32(Console.ReadLine());

			return input;
		}

	}
}
