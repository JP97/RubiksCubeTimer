using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace RubiksCubeTimer
{
	public class Menu
	{
		public void Show()
		{
			bool keeprunning = true;

			do
			{
				Console.Clear();

				Console.WriteLine("Hallo zum SpeedTimer");
				Console.WriteLine("1: SpeedTimer");
				Console.WriteLine("2: Letzten Zeiten");
				Console.WriteLine("3: Exit");

				string userInput = UserInput();

				switch (userInput)
				{
					case "1":
						ChooseMenuPoint(userInput);
						break;
					case "2":
						Console.Clear();
						SecondMenu();
						break;
					case "3":
						keeprunning = false;
						break;
					default:
						break;
				}
			}
			while (keeprunning);
		}


		//the last menu
		public void ChooseMenuPoint(string userInput)
		{
			Binding bin = new Binding();

			switch (userInput)
			{
				case "1":
					Console.WriteLine("Starte den Timer...");
					bin.ChoseTimer();
					break;
				case "2":
					Console.WriteLine("Gespeicherte Zeiten");
					bin.ChoseLastTimes();
					break;
				default:
					break;
			}
		}

		//takes a normal string input
		public string UserInput()
		{
			string userInput;
			//do
			//{
				userInput = Console.ReadLine();
				return userInput;
			//}
			//while (userInput != null);
		}


		//takes normal string inputs and checkes if it can be parsed, if yes it does
		public int UserInputNumbers()
		{
			string userInput = Console.ReadLine();
			int numberInput;

			bool b  = int.TryParse(userInput, out numberInput);

			if (b == true)
			{
				numberInput = int.Parse(userInput);
			}
			else
			{
				Console.WriteLine("Keine richtige Eingabe!");
				Console.WriteLine("versuche es nochmal");
				return 0;
			}

			return numberInput;
		}


		public void SecondMenu()
		{
			Binding bin = new Binding();
			bool keeprunning = true;

			do
			{
				Console.Clear();

				Console.WriteLine("1: Die letzten 10 Zeiten?");
				Console.WriteLine("2: Oder alle?");
				Console.WriteLine("3: Zurück");

				string userInput = UserInput();

				switch (userInput)
				{
					case "1":
						Console.WriteLine(bin.Last10Times());
						break;
					case "2":
						Console.WriteLine(bin.AllTimes());
						break;
					case "3":
						keeprunning = false;
						break;
					default:
						break;
				}
			}
			while (keeprunning);
	
		}
	}
}
