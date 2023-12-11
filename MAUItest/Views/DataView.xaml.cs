namespace MAUItest.Views;
using MAUItest.Models;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
	}

    void btnAdd_Clicked(System.Object sender, System.EventArgs e)
    {
		ContactRepo.AddContact(new Contact
		{
			Name = entryName.Text,
            PhoneNum = entryPhone.Text,
            Email = entryEmail.Text,
        });
        Shell.Current.GoToAsync(nameof(AccountingPage));
    }
}
