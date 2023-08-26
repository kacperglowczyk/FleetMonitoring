using Microsoft.Maui.Controls;

namespace FleetMonitoring.ViewModels;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();
	}
    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///dashboard");
    }

}
