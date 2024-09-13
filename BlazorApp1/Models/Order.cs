namespace BlazorApp1.Models
{
	public class Order
	{
		public Employee? Employee { get; set; }
		public string? ShipCountry { get; set; }

		public string? ShipName { get; set; }
	}

	public class Employee
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }

		public string? CompanyName { get; set; }


	}

	public class Authen
	{
		public string? UserName { get; set; }
		public string? UserPassword { get; set; }
	}
}
