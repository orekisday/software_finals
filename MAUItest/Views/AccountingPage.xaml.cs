namespace MAUItest.Views;
using MAUItest.Models;


public partial class AccountingPage : ContentPage
{
	public AccountingPage()
	{
		InitializeComponent();
        List<Contact> contacts = ContactRepo.GetContacts();

        listContacs.ItemsSource = contacts;
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
    }

    async void listContacs_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        if (listContacs.SelectedItem != null)
        {
            await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={((Contact)listContacs.SelectedItem).ContactId}");
        }
    }

    void listContacs_ItemTapped(System.Object sender, Microsoft.Maui.Controls.ItemTappedEventArgs e)
    {
        listContacs.SelectedItem = null;
    }
}

