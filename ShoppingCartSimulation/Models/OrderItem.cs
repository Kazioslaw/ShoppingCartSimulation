namespace ShoppingCartSimulation.Models
{
	class OrderItem
	{
		public Product Product { get; set; }
		public Order Order { get; set; }
		public int Quantity { get; set; }

		internal OrderItem(Product product, Order order, int quantity)
		{
			Order = order;
			Product = product;
			Quantity = quantity;
		}
	}
}
