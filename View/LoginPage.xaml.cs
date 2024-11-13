namespace Module02Exercise01.View;
using Microsoft.Maui.Controls;
using Module02Exercise01.Services;

public partial class LoginPage : ContentPage
{
	private readonly IMyService _myService; //Field for the service
	public LoginPage(IMyService myService)
	{
		InitializeComponent();
		_myService = myService;

		var message = _myService.GetMessage();
		MyLabel.Text = message;
	}

	private async void OnClickLogin(Object sender, EventArgs e)
	{
        Application.Current.MainPage = new NavigationPage(new AddEmployee());
    }
}