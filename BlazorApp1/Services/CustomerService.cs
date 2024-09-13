using BlazorApp1.Models;

namespace BlazorApp1.Services
{
	public class CustomerService : ICustomerService
	{
		public IEnumerable<Order> GetOrders()
		{
			return _orders;
		}
		private List<Order> _orders = new List<Order>
		{
			new Order
			{
				Employee = new Employee
				{
					FirstName = "lucain",
					CompanyName = "Gotik",
					LastName = "OPham"
				},
				ShipCountry = "Nation",
				ShipName = "Huien"
			},
				new Order
			{
				Employee = new Employee
				{
					FirstName = "Mango",
					CompanyName = "Gotik",
					LastName = "OPham"
				},
				ShipCountry = "Nation",
				ShipName = "Sydney"
			}
		};

	}
}
