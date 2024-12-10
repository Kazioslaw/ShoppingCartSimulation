namespace ShoppingCartSimulation.Models
{
	class Product
	{
		public Product(int id, string name, decimal price)
		{
			ID = id;
			Name = name;
			Price = price;
		}

		public int ID { get; private set; }
		public string Name { get; private set; }
		public decimal Price { get; private set; }
	}
}
