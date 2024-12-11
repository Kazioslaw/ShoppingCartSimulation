namespace ShoppingCartSimulation.Models
{
	class Product
	{
		private static int _nextID = 1;
		public Product(string name, decimal price)
		{
			Console.WriteLine($"Before Assignment: _nextId = {_nextID}");
			ID = _nextID++;
			Console.WriteLine($"After Assignment: ProductId = {ID}, _nextId = {_nextID}");
			Name = name;
			Price = price;
		}

		public int ID { get; private set; }
		public string Name { get; private set; }
		public decimal Price { get; private set; }
	}
}
