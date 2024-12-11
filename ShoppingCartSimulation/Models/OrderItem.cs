namespace ShoppingCartSimulation.Models
{
	class OrderItem
	{
		private static int _nextID = 1;
		public int ID { get; private set; }
		public Product Product { get; set; }
		public Order Order { get; set; }
		public int Quantity { get; set; }

		internal OrderItem(Product product, Order order, int quantity)
		{
			ID = _nextID++;
			Order = order;
			Product = product;
			Quantity = quantity;
		}
	}
}
