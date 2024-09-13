using Radzen;
using BlazorApp1.Models;

namespace BlazorApp1.Components.Pages.NewFolder
{
	public partial class Login
	{
		private string _username { get; set; }= string.Empty;
		private string _password { get; set; } = string.Empty;
		private bool _isRemember { get; set; } = true;
		private bool _isShow {  get; set; } = false;
		private NotificationMessage _notification { get; set; } = new NotificationMessage();

		Authen auth = new Authen();
		void OnLogin(LoginArgs args, string name)
		{
			if (_username == "admin" && _password == "admin123")
			{
				_isShow = true;
				_notification = new NotificationMessage { Severity = NotificationSeverity.Info, Summary = "Info Summary", Detail = "Login succesfull", Duration = 4000 };
			}
		}
		void OnRegister(string name)
		{
		}
		void OnResetPassword(string value, string name)
		{ }
		void IsRemember()
		{
			_isRemember = !_isRemember;
		}
	}
}
