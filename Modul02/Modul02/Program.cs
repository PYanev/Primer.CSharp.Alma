using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			//дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;
			string program_name = "Modul02 - Примери";
			string program_version = "1.0";


			//За програмата
			Console.WriteLine(program_name);
			Console.WriteLine("Версия" + program_version + "\n\n");



			//Събиране на числа
			a = 10;
			b = 5;
			sum = a+b;



			//Писане в конзолата
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write ( b ) ;
			Console.Write(" = ");
			Console.WriteLine (sum);

			//Допълнителни оператори
			Console.WriteLine("\nИзползване на +=");
			a += b;
			Console.WriteLine( a );

			Console.WriteLine("\nИзползване на -=");
			a -= b;
			Console.WriteLine(a);

			Console.WriteLine("\nИзползване на *=");
			a *= b;
			Console.WriteLine(a);

			Console.WriteLine("\nИзползване на ++");
			a++;

			Console.WriteLine(a);

			//Console.WriteLine("\nИзползване на ");
			//a++;

			//Console.WriteLine(a);

			//Console.WriteLine("\nИзползване на ++");
			//a++;

			Console.WriteLine("Стандартно делене:" + (7 / 4 ).ToString());
			Console.WriteLine("Остатък от делене:" + (7 % 4).ToString());



			Console.WriteLine(program_name);


		}
	}
}
