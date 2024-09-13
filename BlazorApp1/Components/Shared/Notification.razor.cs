using Microsoft.AspNetCore.Components;
using Radzen;
namespace BlazorApp1.Components.Shared
{
	public partial class Notification
	{
		[Parameter]
		public NotificationMessage notification1 { get; set; } = new NotificationMessage();
		[Parameter]
		public bool isShow { get; set; } = false;

		private NotificationMessage _noti { get; set; } = new NotificationMessage();
		void ShowNotification()
		{
			if (isShow)
			{
				_noti = notification1;
			}
			return;
		}
	}
}
