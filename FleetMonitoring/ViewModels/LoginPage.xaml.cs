using Microsoft.Maui.Controls;

namespace FleetMonitoring.ViewModels;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    private async void FormLoginBtn_Clicked(object sender, EventArgs e)
    {
        var login = FormLogin.Text;
        var password = FormPassword.Text;

        if (IsCredentialCorrect(login, password))
        {
            await Shell.Current.GoToAsync("///dashboard");
        }
        else
        {
            await DisplayAlert("Login failed", "Username or password is invalid", "Try again");
        }
    }

    bool IsCredentialCorrect(string login, string password)
    {
        return login == "user" && password == "123";
    }
}

