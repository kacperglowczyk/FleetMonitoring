using FleetMonitoring.ViewModels;
using Microsoft.Maui.Controls;

namespace FleetMonitoring;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        
        Routing.RegisterRoute("login", typeof(LoginPage));
        Routing.RegisterRoute("dashboard", typeof(DashboardPage));
        Routing.RegisterRoute("add_record", typeof(AddRecordPage));
        Routing.RegisterRoute("view_record", typeof(ViewRecordPage));
        Routing.RegisterRoute("view_driver", typeof(ViewDriverPage));
        Routing.RegisterRoute("view_info", typeof(InfoPage));

    }
}

