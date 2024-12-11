namespace ShoppingCartSimulation.Models
{
	class Order
	{
		private static int _nextID = 1;
		public Order()
		{
			ID = _nextID++;
			OrderDate = DateTime.Now;
			OrderItems = new List<OrderItem>();
		}
		public int ID { get; private set; }
		public DateTime OrderDate { get; private set; }
		public ICollection<OrderItem> OrderItems { get; private set; }
	}
}
