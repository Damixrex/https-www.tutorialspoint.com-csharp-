using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141293
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Skladnik> pizza = new List<Skladnik>();

			Skladnik skl1 = new Skladnik("Peperoni",5);
			Skladnik skl2 = new Skladnik("Peperoasni", 2);
			Skladnik skl3 = new Skladnik("Peperodsni", 6);
			Skladnik sos1 = new Sos("Makaroni", 56);
			pizza.Add(skl1);
			pizza.Add(skl2);
			pizza.Add(skl3);
			pizza.Add(sos1);
			Console.WriteLine("dlugosc {0}", pizza.Count());

			try
			{
				
			}
			catch (Exception)
			{
				Console.Write("cena nie może być < 0 ");
			}




			foreach (var e in pizza)
			{
				Console.WriteLine(e);
			}
			pizza.Sort();
			pizza.Reverse();
			Console.WriteLine();
			foreach (var e in pizza)
			{
				Console.WriteLine(e);
			}
			pizza.Reverse();
			Console.WriteLine();

			foreach (var e in pizza)
			{
				Console.WriteLine(e);
			}

			Console.WriteLine();
			foreach (var e in pizza)
			{
				if (pizza.IndexOf(e) % 2 == 0)
					Console.WriteLine(e);
			}

			Console.ReadKey();

			//_________________________________________________________
			Console.WriteLine("\n zadanie 7\n");


			Queue<object> kolejka = new Queue<object>();

			Zamowienie zam1 = new NaWynos();
			zam1.UstawCzasDostawy("jutro");

			Zamowienie zam2 = new NaWynos();
			zam2.UstawCzasDostawy("Pojutrze");

			Zamowienie zam3 = new NaMiejscu();

			Zamowienie zam4 = new NaMiejscu();

			Zamowienie zam5 = new NaWynos();
			zam5.UstawCzasDostawy("jutro");

			kolejka.Enqueue(zam1);
			kolejka.Enqueue(zam2);
			kolejka.Enqueue(zam3);
			kolejka.Enqueue(zam4);
			kolejka.Enqueue(zam5);

			Console.WriteLine(kolejka.Count());
			Console.WriteLine();
			foreach (Object obj in kolejka)
			{
		
				Console.WriteLine("{0}", obj);
				
			}
			kolejka.Clear();

			Console.WriteLine("Podaj Czas Dla Pieca");


			Piec pieczenie1 = new Piec();

			pieczenie1.NastawCzas(Convert.ToInt32(Console.ReadLine()));


			Console.ReadKey();
		}

	}
}