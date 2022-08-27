using ToDoApp.MAUI.Pages;

namespace ToDoApp.MAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(ManageToDoPage), typeof(ManageToDoPage));
	}
}
