using System;

namespace KonwersjaArabRzyms
{
	class Program
	{
		static void Main(string[] args)
		{
			int liczba = 0;
			string licznik;
			string rzymskie = "";
			Console.WriteLine("Podaj liczbę z zakresu 1 -3999");
			licznik = Console.ReadLine();
			Console.WriteLine(licznik.Length);
			liczba = int.Parse(licznik);
			//string licznik = liczba.ToString();
			while (liczba != 0)
			{
				if (liczba > 1000)
				{
					rzymskie += "M";
					liczba -= 1000;
				}
				else if (liczba >= 900 & liczba < 1000)
				{
					rzymskie += "CM";
					liczba -= 900;
				}
				else if (liczba >= 500 & liczba < 900)
				{
					rzymskie += "D";
					liczba -= 500;
				}
				else if (liczba >= 400 & liczba < 500)
				{
					rzymskie += "CD";
					liczba -= 400;
				}
				else if (liczba >= 100 & liczba < 400)
				{
					rzymskie += "C";
					liczba -= 100;
				}
				else if (liczba >= 90 & liczba < 99)
				{
					rzymskie += "XC";
					liczba -= 90;
				}
				else if (liczba >= 50 & liczba < 90)
				{
					rzymskie += "L";
					liczba -= 50;
				}
				else if (liczba >= 40 & liczba < 50)
				{
					rzymskie += "XL";
					liczba -= 40;
				}
				else if (liczba >= 10 & liczba < 40)
				{
					rzymskie += "X";
					liczba -= 10;
				}
				//else liczba = 0;
				else if (liczba == 9)
				{
					rzymskie += "IX";
					liczba -= 9;
				}
				else if (liczba >= 5 & liczba < 9)
				{
					rzymskie += "V";
					liczba -= 5;
				}
				else if (liczba >= 1 & liczba < 5)
				{
					rzymskie += "I";
					liczba -= 1;
				}
			}
			//2945
			Console.WriteLine(liczba);
			Console.WriteLine(rzymskie);
			Console.WriteLine("Hello World!");
		}
	}
}
