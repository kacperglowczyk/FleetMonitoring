using FleetMonitoring.Models;
using Microsoft.Maui.Controls;

namespace FleetMonitoring.ViewModels;

public partial class ViewDriverPage : ContentPage
{
    public ViewDriverPage()
    {
        InitializeComponent();

    }
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///dashboard");
        }

}
