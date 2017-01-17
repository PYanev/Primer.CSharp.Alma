using System;

namespace SquareOfStars
{
	class MainClass
	{
		public static void Main(string[] args)
		{

             int number = int.Parse(Console.ReadLine());
			Console.WriteLine(new string('*', number));
			for (int i = 0; i < number - 2; i++)
			{
				Console.Write("*");
				for (int a = 0; a < number - 2; a++)
				{
					Console.Write(" ");
				}
				Console.WriteLine("*");
			}
			Console.WriteLine(new string('*', number));

		}
	}
}
