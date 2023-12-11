using MAUItest.Views;
namespace MAUItest;


public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(AccountingPage), typeof(AccountingPage));
        Routing.RegisterRoute(nameof(DataView), typeof(DataView));
        Routing.RegisterRoute(nameof(EditContactPage), typeof(EditContactPage));
    }
}

