using MAUItest.Views;
namespace MAUItest;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	void Button_Clicked(System.Object sender, System.EventArgs e)
	{
		if (username.Text == passcode.Text)
		{
            Shell.Current.GoToAsync(nameof(AccountingPage));
        }
			
    }

}


