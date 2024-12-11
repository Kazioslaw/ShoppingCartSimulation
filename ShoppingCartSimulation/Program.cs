﻿using ShoppingCartSimulation.Models;

namespace ShoppingCartSimulation
{
	internal class Program
	{
		public static List<OrderItem> orderList = new List<OrderItem>();
		static readonly List<Product> products = new List<Product>
			{
				new Product("Laptop", 2500),
				new Product("Klawiatura", 120),
				new Product("Mysz", 90),
				new Product("Monitor", 1000),
				new Product("Kaczka debuggująca", 66)
			};
		static void Main(string[] args)
		{
			Menu();
		}

		static void Menu()
		{
			bool isExit = false;
			do
			{
				Console.WriteLine("1. Dodaj produkt do koszyka");
				Console.WriteLine("2. Usuń produkt z koszyka");
				Console.WriteLine("3. Podsumuj koszyk");
				Console.WriteLine("4. Wyjście");
				Console.Write("Witaj. Wybierz opcję z menu: ");
				bool isValid = int.TryParse(Console.ReadLine(), out int userPick);
				if (!isValid)
				{
					Console.WriteLine("Nie wprowadzono poprawnej opcji. Wybierz jeszcze raz.");
				}
				else
				{

					switch (userPick)
					{
						case 1:
							Console.Clear();
							AddingProducts();
							break;
						case 2:
							Console.Clear();
							DeletingProducts();
							break;
						case 3:
							Console.Clear();
							GetTotal();
							break;
						case 4:
							isExit = true;
							break;
						default:
							Console.Clear();
							Console.WriteLine("Wybrano niepoprawną pozycję. Spróbuj jeszcze raz. \n");
							Menu();
							break;
					}
				}
			} while (!isExit);
		}

		static void AddingProducts()
		{

		}

		static void DeletingProducts() { }

		static void GetTotal()
		{

		}
	}
}
