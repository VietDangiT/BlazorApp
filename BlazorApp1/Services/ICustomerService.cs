﻿using BlazorApp1.Models;

namespace BlazorApp1.Services
{
	public interface ICustomerService
	{
		public IEnumerable<Order> GetOrders() ;
	}
}
