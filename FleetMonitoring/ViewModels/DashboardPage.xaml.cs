using Microsoft.Maui.Controls;

namespace FleetMonitoring.ViewModels;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}

    private async void LogoutBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///login");
    }

    private async void DashboardAddRecordBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///add_record");
    }

    private async void DashboardViewRecordBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///view_record");
    }

    private async void DashboardViewDriverBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///view_driver");
    }

    private async void DashboardViewInfoBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///view_info");
    }

}
