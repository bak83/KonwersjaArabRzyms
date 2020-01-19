using System;

namespace KonwersjaArabRzyms
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] liczba1 = { 1000, 900, 500, 400, 100, 90, 50, 40, 10,9,5,4,1 };
			string[] rzymskie1 = { "M", "CM", "D" , "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV","I"};
			int liczba = 0;
			string rzymskie = "";
			Console.WriteLine("Podaj liczbę z zakresu 1 -3999");
			liczba = int.Parse(Console.ReadLine());
			int i = 0;
			while (i < liczba1.Length)
			{
				if (liczba >= liczba1[i])
				{
					rzymskie += rzymskie1[i];
					liczba -= liczba1[i];
				}
				else
					i++;
			}
			Console.WriteLine("Zapis w formacie rzymskim: " + rzymskie);
		}
	}
}
