using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Дефиниране на променливи
			//int a = 5, b = 0;

			//Въвеждане на входни параметри
			//Console.Write("Моля въведете данни");
			//b = Convert.ToInt32 (Console.ReadLine());


			//Печат на резултат
			//Console.WriteLine("Резултата А + Б е " + (a + b).ToString() + "\n\n\n");


			string test = "1";
			test += ", 2";
			test += ", 100";
			test += ", 4";
			test += ", 5";
			test += ", 6";

			///Console.WriteLine( "Събиране с += " + test + "\n");

			test = test.Replace(",",";");


			Console.WriteLine("Работа с Replace " + test + "\n");


			Console.WriteLine(" 3 ти знак " + test.Split (';') [2] );

			Console.Readln
		}


	}
}
