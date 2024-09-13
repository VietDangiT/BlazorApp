using BlazorApp1.Models;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages.ProgramDetail
{
    public partial class ProgramDetail
    {
        [Inject] private ICustomerService _customerService { get; set; }
        private IEnumerable<Order> _orders { get; set; } = new List<Order>();

        protected override async Task OnInitializedAsync()
        {
            _orders = _customerService.GetOrders();
            await base.OnInitializedAsync();
        }
    }
}
